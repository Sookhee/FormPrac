using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrac
{
    public partial class Form1 : Form
    {
        class CustomForm : Form{
            public CustomForm()
            {
                this.Text = "내가 만든 폼!";
            }
        }

        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomForm cf = new CustomForm();
            cf.MdiParent = this;
            cf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomForm cf = new CustomForm();
            cf.ShowDialog();
        }
    }
}
