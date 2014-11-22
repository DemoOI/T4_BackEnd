using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeGenerator.Helper;
using CodeGenerator.Model;
using CodeGenerator.Template;
using System.Diagnostics;

namespace CodeGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (Applications.IsExpired()) AreControllersEnable(false);
            comboBox1.SelectedIndex = 0;//设置第一项为默认选择项。
            CBdbName.DataSource = UtilsFunction.getAllDB(); //取得資料表
            lblGeneratePath.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";

        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        #region 預覽程式碼
        private void generate_Click(object sender, EventArgs e)
        {
            //工廠模式 可選擇BLL DLL Controller ViewIndex ViewPage

            //參數
            BaseModel model = new BaseModel();
            model.DBName = CBdbName.SelectedItem.ToString();
            model.TypeName = comboBox1.SelectedItem.ToString();
            model.Namespace = txtNamespace.Text;
            model.ProjectName = txtProjectName.Text;
            model.DataAccessContext = txtdbContext.Text;
            model.ClassName = txtClassName.Text;
            model.ModelName = txtModelName.Text;

            //TODO 工廠模式 
            Factory temp = new Factory(model);
            if (temp.Interface == null) return;
            richTextBox1.Text = temp.Interface.TransformText();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelDLL.Visible = label4.Visible = txtdbContext.Visible = true;

            if (comboBox1.SelectedItem.ToString() == "ViewIndex" || comboBox1.SelectedItem.ToString() == "ViewPage")
            {
                label4.Visible = txtdbContext.Visible = false;
            }

        }
        #endregion

        #region 匯出程式碼

        //資料表下拉選單
        private void CBdbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> tableNames = UtilsFunction.getAllTable(CBdbName.SelectedItem.ToString());

            SetListBox(tableNames, LBoxModel, "model");
            SetListBox(tableNames, LBoxDAL);
            SetListBox(tableNames, LBoxService);
            SetListBox(tableNames, LBoxController);
            SetListBox(tableNames, LBoxViewIndex);
            SetListBox(tableNames, LBoxViewPage);

            txtProjectName.Text = CBdbName.SelectedItem.ToString();
        }


        //指定路徑
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            lblGeneratePath.Text = folderBrowserDialog1.SelectedPath + "\\";
        }

        //匯出cs檔
        private void btnGenerate_Click(object sender, EventArgs e)
        {

            //參數
            BaseModel baseModel = new BaseModel();
            baseModel.TypeName = comboBox1.SelectedItem.ToString();
            baseModel.Namespace = txtNamespace.Text;
            baseModel.DataAccessContext = txtdbContext.Text;
            baseModel.ProjectName = txtProjectName.Text;
            baseModel.ClassName = txtClassName.Text;
            baseModel.ModelName = txtModelName.Text;

            #region 匯出Models allen版本
            List<string> model = new List<string>();
            string tempString = string.Empty;
            string lastString = string.Empty;

            foreach (string item in LBoxModel.SelectedItems)
            {
                tempString = item;
                lastString = tempString.Substring(tempString.Length - 5);
                model.Add(tempString.Substring(0, tempString.Length - 5));
            }



            string filePath = lblGeneratePath.Text + txtProjectName.Text + "/Models/";
            UtilsFunction.isDirectoryExists(filePath);
            for (int i = 0; i < model.Count; i++)
            {
                try
                {
                    ModelTemp m = new ModelTemp();
                    m.Session = new Dictionary<string, object>();
                    m.Session.Add("NameSpace", txtProjectName.Text);
                    m.Session.Add("DbName", CBdbName.SelectedItem.ToString());
                    m.Session.Add("TableName", model[i]);
                    m.Initialize();
                    File.AppendAllText(filePath + model[i] + "Model.cs", m.TransformText());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            #endregion

            if (
                //匯出Dao
                ExportCS(new DALTemp(baseModel), LBoxDAL, "DAL", "Dao") &&
                //匯出Service
                ExportCS(new BLLTemp(baseModel), LBoxService, "BLL", "Service") &&
                //匯出Controller
                ExportCS(new ControllerTemp(baseModel), LBoxController, "Controller", "Controller") &&
                //匯出Index
                ExportCsHtml(new ViewIndexTemp(baseModel), LBoxViewIndex, "Views", "Index") &&
                //匯出Page
                ExportCsHtml(new ViewPageTemp(baseModel) { IsHavePicUpload = chkPicUpload.Checked }, LBoxViewPage, "Views", "Page")
                )
            {
                MessageBox.Show("程式碼產生完成,請愛惜使用,啾咪!!");
                //開啟資料夾
                Process.Start(lblGeneratePath.Text + txtProjectName.Text);
            }
            else
            {
                MessageBox.Show("匯出失敗,請重新匯出!!");
            }

        }

        private void SetListBox(List<string> tableNames, ListBox listbox, string 結尾字串 = "")
        {
            var itemsModel = listbox.Items;
            itemsModel.Clear();
            for (int i = 0; i < tableNames.Count; i++)
            {
                itemsModel.Add(tableNames[i] + 結尾字串);
            }
        }

        private bool ExportCS(Interface t, ListBox listBox, string fileName, string 結尾名稱)
        {
            if (listBox.SelectedItems.Count == 0) return true;

            string filePath = lblGeneratePath.Text + txtProjectName.Text + "/" + fileName + "/";
            UtilsFunction.isDirectoryExists(filePath);
            foreach (string item in listBox.SelectedItems)
            {
                try
                {
                    File.WriteAllText(filePath + item + 結尾名稱 + ".cs", t.TransformText(), Encoding.Unicode);
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return true;
        }

        private bool ExportCsHtml(Interface t, ListBox listBox, string fileName, string ViewType)
        {
            if (listBox.SelectedItems.Count == 0) return true;

            foreach (string item in listBox.SelectedItems)
            {
                try
                {
                    string filePath = lblGeneratePath.Text + txtProjectName.Text + "/" + fileName + "/" + item + "/";
                    UtilsFunction.isDirectoryExists(filePath);
                    File.WriteAllText(filePath + ViewType + ".cshtml", t.TransformText(), Encoding.Unicode);
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region 註冊
        private void menuItem3_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            Form2 settingsForm = new Form2(this);

            // Show the settings form
            settingsForm.Show();
        }

        public void Register(string userName, string key)
        {
            //註冊邏輯
            if (Applications.IsKeyType(key))
            {
                //註冊
                RegisterAppConfig(key);
                if (!Applications.IsExpired(key))
                {
                    AreControllersEnable(true);
                    MessageBox.Show("註冊成功");
                }
                else
                {
                    AreControllersEnable(false);
                    MessageBox.Show("註冊金鑰過期囉~~");
                }
                    
            }
            else
            {
                MessageBox.Show("註冊金鑰不正確");
            }
            
        }

        
        #endregion

        #region 工具
        
        private void AreControllersEnable(bool enbale)
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = enbale;
            }
        }

        private void RegisterAppConfig(string key)
        {
            //Configuration與AppSettingsSection必須引用System.Configuration才可使用！
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            AppSettingsSection app = config.AppSettings;
            //判斷是否第一次註冊
            if (app.Settings["expiredDay"] == null)
            {
                app.Settings.Add("expiredDay", key);
            }
            else
            {
                app.Settings["expiredDay"].Value = key;
                
            }
            config.Save(ConfigurationSaveMode.Modified);
        }
        #endregion



    }
}
