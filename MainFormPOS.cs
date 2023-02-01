using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnsarPOS
{
    public partial class MainFormPOS : Form
    {
        public MainFormPOS()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void MainFormPOS_Load(object sender, EventArgs e)
        {

          

            Login obj = new Login();
            obj.MdiParent = this;
            obj.Show();
        }

        private void MainFormPOS_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
