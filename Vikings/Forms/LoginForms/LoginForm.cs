using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vikings.Models;
using static System.Net.Mime.MediaTypeNames;

namespace Vikings.Forms.LoginForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void Log_btn_Click(object sender, EventArgs e)
        {
            string x = Name.Text;
            string i = textBox3.Text;
            if (x == "0000" && i == "admin")
            {
                this.Hide();
                Form1 f = new Form1();
                f.Closed += (s, args) => this.Close();
                f.Show();
            }
            else
            {
                label1.Text = "Wrong User";
                label1.ForeColor = Color.Red;
            }

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
