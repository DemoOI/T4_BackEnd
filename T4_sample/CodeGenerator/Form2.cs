using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeGenerator.Helper;

namespace CodeGenerator
{
    public partial class Form2 : Form
    {

        public Form2(Form1 Parentform)//Parent Form
        {
            InitializeComponent();
            this.Tag = Parentform;
            Init();

        }

        private void Init()
        {
            SymmetricMethod gen = new SymmetricMethod();
            string key = ConfigurationManager.AppSettings["expiredDay"];

            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(gen.Decrypto(key)))
            {
                txtRegName.Enabled = txtRegKey.Enabled = button1.Enabled =  false;
                lblRegDate.Visible = true;
                lblRegDate.Text += ":     " + gen.Decrypto(key);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name = txtRegName.Text;
            var key = txtRegKey.Text;
            //關form2
            Close();

            //((Form1)this.Tag).setRegKey = txtRegKey.Text;//傳值設定Form1的TextBox
            ((Form1)this.Tag).Register(name, key);//執行Form1的Function
            
        }

    }
}
