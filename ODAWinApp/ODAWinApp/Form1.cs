using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace ODAWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string userSelectedFilePath
        {
            get
            {
                return tbFilePath.Text;
            }
            set
            {
                tbFilePath.Text = value;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string dbname = textBox5.Text;
            string sys_pwd = textBox6.Text;
            string winpath_pwd = textBox7.Text;
            string load_dir = tbFilePath.Text;

            if (String.IsNullOrEmpty(dbname))
            {
                MessageBox.Show("DB Name MUST be specified.", "Error..",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (String.IsNullOrEmpty(sys_pwd))
            {
                MessageBox.Show("SYS Password MUST be specified.", "Error..",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (String.IsNullOrEmpty(winpath_pwd))
            {
                MessageBox.Show("WINPATH Password MUST be specified.", "Error..",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(load_dir))
            {
                MessageBox.Show("Load Data Directory MUST be specified.", "Error..",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            System.Windows.Forms.DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                userSelectedFilePath = ofd.SelectedPath;
            }
        }
    }

}
