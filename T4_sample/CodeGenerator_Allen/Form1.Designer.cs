namespace CodeGenerator_Allen
{
    partial class BackendGeneratorByAllen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblGeneratePath = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblManagement = new System.Windows.Forms.Label();
            this.lblController = new System.Windows.Forms.Label();
            this.LBoxModel = new System.Windows.Forms.ListBox();
            this.LBoxDAL = new System.Windows.Forms.ListBox();
            this.LBoxController = new System.Windows.Forms.ListBox();
            this.CBdbName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "DbName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "ProjectName";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(29, 75);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(100, 22);
            this.txtProjectName.TabIndex = 5;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(10, 268);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblGeneratePath
            // 
            this.lblGeneratePath.AutoSize = true;
            this.lblGeneratePath.Location = new System.Drawing.Point(87, 273);
            this.lblGeneratePath.Name = "lblGeneratePath";
            this.lblGeneratePath.Size = new System.Drawing.Size(19, 12);
            this.lblGeneratePath.TabIndex = 7;
            this.lblGeneratePath.Text = "C:\\";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(611, 273);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(157, 14);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(35, 12);
            this.lblModel.TabIndex = 9;
            this.lblModel.Text = "Model";
            this.lblModel.Visible = false;
            // 
            // lblManagement
            // 
            this.lblManagement.AutoSize = true;
            this.lblManagement.Location = new System.Drawing.Point(337, 14);
            this.lblManagement.Name = "lblManagement";
            this.lblManagement.Size = new System.Drawing.Size(28, 12);
            this.lblManagement.TabIndex = 10;
            this.lblManagement.Text = "DAL";
            this.lblManagement.Visible = false;
            // 
            // lblController
            // 
            this.lblController.AutoSize = true;
            this.lblController.Location = new System.Drawing.Point(515, 14);
            this.lblController.Name = "lblController";
            this.lblController.Size = new System.Drawing.Size(53, 12);
            this.lblController.TabIndex = 11;
            this.lblController.Text = "Controller";
            this.lblController.Visible = false;
            // 
            // LBoxModel
            // 
            this.LBoxModel.FormattingEnabled = true;
            this.LBoxModel.ItemHeight = 12;
            this.LBoxModel.Location = new System.Drawing.Point(159, 29);
            this.LBoxModel.Name = "LBoxModel";
            this.LBoxModel.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LBoxModel.Size = new System.Drawing.Size(170, 232);
            this.LBoxModel.TabIndex = 12;
            this.LBoxModel.Visible = false;
            // 
            // LBoxDAL
            // 
            this.LBoxDAL.FormattingEnabled = true;
            this.LBoxDAL.ItemHeight = 12;
            this.LBoxDAL.Location = new System.Drawing.Point(338, 29);
            this.LBoxDAL.Name = "LBoxDAL";
            this.LBoxDAL.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LBoxDAL.Size = new System.Drawing.Size(170, 232);
            this.LBoxDAL.TabIndex = 13;
            this.LBoxDAL.Visible = false;
            // 
            // LBoxController
            // 
            this.LBoxController.FormattingEnabled = true;
            this.LBoxController.ItemHeight = 12;
            this.LBoxController.Location = new System.Drawing.Point(516, 29);
            this.LBoxController.Name = "LBoxController";
            this.LBoxController.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LBoxController.Size = new System.Drawing.Size(170, 232);
            this.LBoxController.TabIndex = 14;
            this.LBoxController.Visible = false;
            // 
            // CBdbName
            // 
            this.CBdbName.FormattingEnabled = true;
            this.CBdbName.Location = new System.Drawing.Point(29, 29);
            this.CBdbName.Name = "CBdbName";
            this.CBdbName.Size = new System.Drawing.Size(100, 20);
            this.CBdbName.TabIndex = 15;
            this.CBdbName.SelectedIndexChanged += new System.EventHandler(this.CBdbName_SelectedIndexChanged);
            // 
            // BackendGeneratorByAllen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 306);
            this.Controls.Add(this.CBdbName);
            this.Controls.Add(this.LBoxController);
            this.Controls.Add(this.LBoxDAL);
            this.Controls.Add(this.LBoxModel);
            this.Controls.Add(this.lblController);
            this.Controls.Add(this.lblManagement);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblGeneratePath);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "BackendGeneratorByAllen";
            this.Text = "AllenBackendGenerator v1.0.0.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblGeneratePath;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblManagement;
        private System.Windows.Forms.Label lblController;
        private System.Windows.Forms.ListBox LBoxModel;
        private System.Windows.Forms.ListBox LBoxDAL;
        private System.Windows.Forms.ListBox LBoxController;
        private System.Windows.Forms.ComboBox CBdbName;
    }
}

