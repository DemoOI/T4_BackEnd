namespace CodeGenerator
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chkPicUpload = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.CBdbName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblViewIndex = new System.Windows.Forms.Label();
            this.lblViewPage = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.LBoxViewPage = new System.Windows.Forms.ListBox();
            this.LBoxViewIndex = new System.Windows.Forms.ListBox();
            this.LBoxService = new System.Windows.Forms.ListBox();
            this.LBoxController = new System.Windows.Forms.ListBox();
            this.LBoxDAL = new System.Windows.Forms.ListBox();
            this.LBoxModel = new System.Windows.Forms.ListBox();
            this.lblController = new System.Windows.Forms.Label();
            this.lblManagement = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblGeneratePath = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.panelDLL = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtdbContext = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtNamespace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.generate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelDLL.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem4,
            this.menuItem6,
            this.menuItem1});
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 0;
            this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem5});
            this.menuItem4.Text = "File";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 0;
            this.menuItem5.Text = "啾咪";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 1;
            this.menuItem6.Text = "Options";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 2;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem3});
            this.menuItem1.Text = "Help";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "關於我們";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "註冊";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1265, 633);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "AU版本";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1265, 633);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bii版本";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(5, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1273, 659);
            this.tabControl1.TabIndex = 70;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.chkPicUpload);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.btnGenerate);
            this.tabPage1.Controls.Add(this.CBdbName);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.lblViewIndex);
            this.tabPage1.Controls.Add(this.lblViewPage);
            this.tabPage1.Controls.Add(this.lblService);
            this.tabPage1.Controls.Add(this.LBoxViewPage);
            this.tabPage1.Controls.Add(this.LBoxViewIndex);
            this.tabPage1.Controls.Add(this.LBoxService);
            this.tabPage1.Controls.Add(this.LBoxController);
            this.tabPage1.Controls.Add(this.LBoxDAL);
            this.tabPage1.Controls.Add(this.LBoxModel);
            this.tabPage1.Controls.Add(this.lblController);
            this.tabPage1.Controls.Add(this.lblManagement);
            this.tabPage1.Controls.Add(this.lblModel);
            this.tabPage1.Controls.Add(this.lblGeneratePath);
            this.tabPage1.Controls.Add(this.btnBrowse);
            this.tabPage1.Controls.Add(this.panelDLL);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.generate);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1265, 633);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "OI版本";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 12);
            this.label11.TabIndex = 95;
            this.label11.Text = "2.設定匯出位置";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 12);
            this.label12.TabIndex = 94;
            this.label12.Text = "3.請選擇要產生的程式碼";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 381);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 93;
            this.label13.Text = "預覽樣版";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 12);
            this.label10.TabIndex = 92;
            this.label10.Text = "1.選擇資料表";
            // 
            // chkPicUpload
            // 
            this.chkPicUpload.AutoSize = true;
            this.chkPicUpload.Location = new System.Drawing.Point(1082, 265);
            this.chkPicUpload.Name = "chkPicUpload";
            this.chkPicUpload.Size = new System.Drawing.Size(72, 16);
            this.chkPicUpload.TabIndex = 91;
            this.chkPicUpload.Text = "圖片上傳";
            this.chkPicUpload.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 12);
            this.label9.TabIndex = 90;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 12);
            this.label6.TabIndex = 89;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(16, 146);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(66, 23);
            this.btnGenerate.TabIndex = 88;
            this.btnGenerate.Text = "產生";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // CBdbName
            // 
            this.CBdbName.FormattingEnabled = true;
            this.CBdbName.Location = new System.Drawing.Point(16, 28);
            this.CBdbName.Name = "CBdbName";
            this.CBdbName.Size = new System.Drawing.Size(100, 20);
            this.CBdbName.TabIndex = 87;
            this.CBdbName.SelectedIndexChanged += new System.EventHandler(this.CBdbName_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 12);
            this.label8.TabIndex = 86;
            // 
            // lblViewIndex
            // 
            this.lblViewIndex.AutoSize = true;
            this.lblViewIndex.Location = new System.Drawing.Point(904, 12);
            this.lblViewIndex.Name = "lblViewIndex";
            this.lblViewIndex.Size = new System.Drawing.Size(0, 12);
            this.lblViewIndex.TabIndex = 85;
            // 
            // lblViewPage
            // 
            this.lblViewPage.AutoSize = true;
            this.lblViewPage.Location = new System.Drawing.Point(1080, 8);
            this.lblViewPage.Name = "lblViewPage";
            this.lblViewPage.Size = new System.Drawing.Size(0, 12);
            this.lblViewPage.TabIndex = 84;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(550, 12);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(0, 12);
            this.lblService.TabIndex = 83;
            // 
            // LBoxViewPage
            // 
            this.LBoxViewPage.FormattingEnabled = true;
            this.LBoxViewPage.ItemHeight = 12;
            this.LBoxViewPage.Location = new System.Drawing.Point(1082, 27);
            this.LBoxViewPage.Name = "LBoxViewPage";
            this.LBoxViewPage.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LBoxViewPage.Size = new System.Drawing.Size(170, 232);
            this.LBoxViewPage.TabIndex = 82;
            // 
            // LBoxViewIndex
            // 
            this.LBoxViewIndex.FormattingEnabled = true;
            this.LBoxViewIndex.ItemHeight = 12;
            this.LBoxViewIndex.Location = new System.Drawing.Point(906, 27);
            this.LBoxViewIndex.Name = "LBoxViewIndex";
            this.LBoxViewIndex.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LBoxViewIndex.Size = new System.Drawing.Size(170, 232);
            this.LBoxViewIndex.TabIndex = 81;
            // 
            // LBoxService
            // 
            this.LBoxService.FormattingEnabled = true;
            this.LBoxService.ItemHeight = 12;
            this.LBoxService.Location = new System.Drawing.Point(552, 27);
            this.LBoxService.Name = "LBoxService";
            this.LBoxService.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LBoxService.Size = new System.Drawing.Size(170, 232);
            this.LBoxService.TabIndex = 80;
            // 
            // LBoxController
            // 
            this.LBoxController.FormattingEnabled = true;
            this.LBoxController.ItemHeight = 12;
            this.LBoxController.Location = new System.Drawing.Point(730, 27);
            this.LBoxController.Name = "LBoxController";
            this.LBoxController.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LBoxController.Size = new System.Drawing.Size(170, 232);
            this.LBoxController.TabIndex = 79;
            // 
            // LBoxDAL
            // 
            this.LBoxDAL.FormattingEnabled = true;
            this.LBoxDAL.ItemHeight = 12;
            this.LBoxDAL.Location = new System.Drawing.Point(376, 28);
            this.LBoxDAL.Name = "LBoxDAL";
            this.LBoxDAL.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LBoxDAL.Size = new System.Drawing.Size(170, 232);
            this.LBoxDAL.TabIndex = 78;
            // 
            // LBoxModel
            // 
            this.LBoxModel.FormattingEnabled = true;
            this.LBoxModel.ItemHeight = 12;
            this.LBoxModel.Location = new System.Drawing.Point(197, 28);
            this.LBoxModel.Name = "LBoxModel";
            this.LBoxModel.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LBoxModel.Size = new System.Drawing.Size(170, 232);
            this.LBoxModel.TabIndex = 77;
            // 
            // lblController
            // 
            this.lblController.AutoSize = true;
            this.lblController.Location = new System.Drawing.Point(729, 12);
            this.lblController.Name = "lblController";
            this.lblController.Size = new System.Drawing.Size(0, 12);
            this.lblController.TabIndex = 76;
            // 
            // lblManagement
            // 
            this.lblManagement.AutoSize = true;
            this.lblManagement.Location = new System.Drawing.Point(375, 13);
            this.lblManagement.Name = "lblManagement";
            this.lblManagement.Size = new System.Drawing.Size(0, 12);
            this.lblManagement.TabIndex = 75;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(195, 13);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(0, 12);
            this.lblModel.TabIndex = 74;
            // 
            // lblGeneratePath
            // 
            this.lblGeneratePath.AutoSize = true;
            this.lblGeneratePath.Location = new System.Drawing.Point(85, 96);
            this.lblGeneratePath.Name = "lblGeneratePath";
            this.lblGeneratePath.Size = new System.Drawing.Size(0, 12);
            this.lblGeneratePath.TabIndex = 73;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(16, 90);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(66, 23);
            this.btnBrowse.TabIndex = 72;
            this.btnBrowse.Text = "儲存路徑";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // panelDLL
            // 
            this.panelDLL.Controls.Add(this.label14);
            this.panelDLL.Controls.Add(this.label15);
            this.panelDLL.Controls.Add(this.txtProjectName);
            this.panelDLL.Controls.Add(this.txtClassName);
            this.panelDLL.Controls.Add(this.label16);
            this.panelDLL.Controls.Add(this.txtdbContext);
            this.panelDLL.Controls.Add(this.label17);
            this.panelDLL.Controls.Add(this.txtModelName);
            this.panelDLL.Controls.Add(this.label18);
            this.panelDLL.Controls.Add(this.txtNamespace);
            this.panelDLL.Location = new System.Drawing.Point(6, 175);
            this.panelDLL.Name = "panelDLL";
            this.panelDLL.Size = new System.Drawing.Size(180, 177);
            this.panelDLL.TabIndex = 71;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 12);
            this.label14.TabIndex = 41;
            this.label14.Text = "ClassName";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 12);
            this.label15.TabIndex = 44;
            this.label15.Text = "ProjectName";
            // 
            // txtProjectName
            // 
            this.txtProjectName.BackColor = System.Drawing.Color.White;
            this.txtProjectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtProjectName.Location = new System.Drawing.Point(73, 21);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(100, 22);
            this.txtProjectName.TabIndex = 45;
            this.txtProjectName.Text = "專案名稱";
            // 
            // txtClassName
            // 
            this.txtClassName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtClassName.Location = new System.Drawing.Point(73, 77);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(100, 22);
            this.txtClassName.TabIndex = 37;
            this.txtClassName.Text = "類別名稱";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 12);
            this.label16.TabIndex = 39;
            this.label16.Text = "Namespace";
            // 
            // txtdbContext
            // 
            this.txtdbContext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtdbContext.Location = new System.Drawing.Point(73, 133);
            this.txtdbContext.Name = "txtdbContext";
            this.txtdbContext.Size = new System.Drawing.Size(100, 22);
            this.txtdbContext.TabIndex = 38;
            this.txtdbContext.Text = "DataAccessContext";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 136);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 12);
            this.label17.TabIndex = 42;
            this.label17.Text = "dbContext";
            // 
            // txtModelName
            // 
            this.txtModelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtModelName.Location = new System.Drawing.Point(73, 105);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(100, 22);
            this.txtModelName.TabIndex = 40;
            this.txtModelName.Text = "模型名稱";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 108);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 12);
            this.label18.TabIndex = 43;
            this.label18.Text = "ModelName";
            // 
            // txtNamespace
            // 
            this.txtNamespace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtNamespace.Location = new System.Drawing.Point(73, 49);
            this.txtNamespace.Name = "txtNamespace";
            this.txtNamespace.Size = new System.Drawing.Size(100, 22);
            this.txtNamespace.TabIndex = 36;
            this.txtNamespace.Text = "NTCL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 68;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "DAL",
            "BLL",
            "Controller",
            "ViewIndex",
            "ViewPage"});
            this.comboBox1.Location = new System.Drawing.Point(9, 405);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 67;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(197, 287);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(650, 296);
            this.richTextBox1.TabIndex = 70;
            this.richTextBox1.Text = "";
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(9, 431);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(75, 23);
            this.generate.TabIndex = 69;
            this.generate.Text = "generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 12);
            this.label5.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 12);
            this.label4.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 12);
            this.label7.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 12);
            this.label3.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 693);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "MVC嘻嘻版 程式碼產生器";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panelDLL.ResumeLayout(false);
            this.panelDLL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chkPicUpload;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ComboBox CBdbName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblViewIndex;
        private System.Windows.Forms.Label lblViewPage;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.ListBox LBoxViewPage;
        private System.Windows.Forms.ListBox LBoxViewIndex;
        private System.Windows.Forms.ListBox LBoxService;
        private System.Windows.Forms.ListBox LBoxController;
        private System.Windows.Forms.ListBox LBoxDAL;
        private System.Windows.Forms.ListBox LBoxModel;
        private System.Windows.Forms.Label lblController;
        private System.Windows.Forms.Label lblManagement;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblGeneratePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Panel panelDLL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtdbContext;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtNamespace;
    }
}

