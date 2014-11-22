namespace CodeGenerator
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.lblRegName = new System.Windows.Forms.Label();
            this.lblRegKey = new System.Windows.Forms.Label();
            this.txtRegName = new System.Windows.Forms.TextBox();
            this.txtRegKey = new System.Windows.Forms.TextBox();
            this.lblRegDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "註冊";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRegName
            // 
            this.lblRegName.AutoSize = true;
            this.lblRegName.Location = new System.Drawing.Point(72, 23);
            this.lblRegName.Name = "lblRegName";
            this.lblRegName.Size = new System.Drawing.Size(65, 12);
            this.lblRegName.TabIndex = 1;
            this.lblRegName.Text = "使用者名稱";
            // 
            // lblRegKey
            // 
            this.lblRegKey.AutoSize = true;
            this.lblRegKey.Location = new System.Drawing.Point(75, 50);
            this.lblRegKey.Name = "lblRegKey";
            this.lblRegKey.Size = new System.Drawing.Size(41, 12);
            this.lblRegKey.TabIndex = 2;
            this.lblRegKey.Text = "註冊碼";
            // 
            // txtRegName
            // 
            this.txtRegName.Location = new System.Drawing.Point(144, 17);
            this.txtRegName.Name = "txtRegName";
            this.txtRegName.Size = new System.Drawing.Size(204, 22);
            this.txtRegName.TabIndex = 3;
            // 
            // txtRegKey
            // 
            this.txtRegKey.Location = new System.Drawing.Point(144, 47);
            this.txtRegKey.Name = "txtRegKey";
            this.txtRegKey.Size = new System.Drawing.Size(204, 22);
            this.txtRegKey.TabIndex = 4;
            // 
            // lblRegDate
            // 
            this.lblRegDate.AutoSize = true;
            this.lblRegDate.Location = new System.Drawing.Point(75, 77);
            this.lblRegDate.Name = "lblRegDate";
            this.lblRegDate.Size = new System.Drawing.Size(53, 12);
            this.lblRegDate.TabIndex = 5;
            this.lblRegDate.Text = "到期時間";
            this.lblRegDate.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 130);
            this.Controls.Add(this.lblRegDate);
            this.Controls.Add(this.txtRegKey);
            this.Controls.Add(this.txtRegName);
            this.Controls.Add(this.lblRegKey);
            this.Controls.Add(this.lblRegName);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "註冊";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblRegName;
        private System.Windows.Forms.Label lblRegKey;
        private System.Windows.Forms.TextBox txtRegName;
        private System.Windows.Forms.TextBox txtRegKey;
        private System.Windows.Forms.Label lblRegDate;
    }
}