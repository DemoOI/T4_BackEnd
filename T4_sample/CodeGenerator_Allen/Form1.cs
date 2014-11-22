using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeGenerator_Allen.Template;

namespace CodeGenerator_Allen
{
    public partial class BackendGeneratorByAllen : Form
    {
        public BackendGeneratorByAllen()
        {
            InitializeComponent();
            CBdbName.DataSource = UtilsFunction.getAllDB();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            lblGeneratePath.Text = folderBrowserDialog1.SelectedPath + "\\";
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            List<string> model = new List<string>();
            List<string> management = new List<string>();
            List<string> controller = new List<string>();
            string tempString = string.Empty;
            string lastString = string.Empty;
            
            foreach (string item in LBoxModel.SelectedItems)
            {
                tempString = item;
                lastString = tempString.Substring(tempString.Length - 5);
                model.Add(tempString.Substring(0, tempString.Length - Parameters.Model.Length)); 
            }

            foreach (string item in LBoxDAL.SelectedItems)
            {
                tempString = item;
                lastString = tempString.Substring(tempString.Length - 5);
                management.Add(tempString.Substring(0, tempString.Length - Parameters.Management.Length)); 
            }

            foreach (string item in LBoxController.SelectedItems)
            {
                tempString = item;
                lastString = tempString.Substring(tempString.Length - 5);
                controller.Add(tempString.Substring(0, tempString.Length - Parameters.Controller.Length)); 
            }

            #region 開產Models
            string filePath = lblGeneratePath.Text + txtProjectName.Text + "/Models/";
            UtilsFunction.isDirectoryExists(filePath);            
            for (int i = 0; i < model.Count; i++)
            {
                try
                {
                    TableToModel m = new TableToModel();
                    m.Session = new Dictionary<string, object>();
                    m.Session.Add("NameSpace", txtProjectName.Text + ".Models");
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

            #region 開產Managements
            filePath = lblGeneratePath.Text + txtProjectName.Text + "/DAL/";
            UtilsFunction.isDirectoryExists(filePath);
            for (int i = 0; i < management.Count; i++)
            {
                try
                {
                    TableToModel m = new TableToModel();
                    m.Session = new Dictionary<string, object>();
                    m.Session.Add("NameSpace", txtProjectName.Text + ".DAL");
                    m.Session.Add("DbName", CBdbName.SelectedItem.ToString());
                    m.Session.Add("TableName", management[i]);
                    m.Initialize();
                    File.AppendAllText(filePath + management[i] + "Management.cs", m.TransformText());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            #endregion

            #region 開產Controllers
            filePath = lblGeneratePath.Text + txtProjectName.Text + "/Controller/";
            UtilsFunction.isDirectoryExists(filePath);
            for (int i = 0; i < controller.Count; i++)
            {
                try
                {
                    TableToModel m = new TableToModel();
                    m.Session = new Dictionary<string, object>();
                    m.Session.Add("NameSpace", txtProjectName.Text + ".Controller");
                    m.Session.Add("DbName", CBdbName.SelectedItem.ToString());
                    m.Session.Add("TableName", controller[i]);
                    m.Initialize();
                    File.AppendAllText(filePath + controller[i] + "Controller.cs", m.TransformText());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            #endregion

            MessageBox.Show("程式碼產生完成,請愛惜使用,啾咪!!");

        }

        private void CBdbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<string> tableNames = UtilsFunction.getAllTable(CBdbName.SelectedItem.ToString());
                lblModel.Visible = true;
                lblManagement.Visible = true;
                lblController.Visible = true;
                LBoxModel.Visible = true;
                LBoxDAL.Visible = true;
                LBoxController.Visible = true;

                var itemsModel = LBoxModel.Items;
                itemsModel.Clear();
                for (int i = 0; i < tableNames.Count; i++)
                {
                    itemsModel.Add(tableNames[i] + "Model");
                }

                var itemsManagement = LBoxDAL.Items;
                itemsManagement.Clear();
                for (int i = 0; i < tableNames.Count; i++)
                {
                    itemsManagement.Add(tableNames[i] + "Management");
                }

                var itemsController = LBoxController.Items;
                itemsController.Clear();
                for (int i = 0; i < tableNames.Count; i++)
                {
                    itemsController.Add(tableNames[i] + "Controller");
                }
            }
            catch (Exception)
            {
                lblModel.Visible = false;
                lblManagement.Visible = false;
                lblController.Visible = false;
                LBoxModel.Visible = false;
                LBoxDAL.Visible = false;
                LBoxController.Visible = false;
            }
        }
    }
}
