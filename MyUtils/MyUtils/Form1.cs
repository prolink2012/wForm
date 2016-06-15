using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUtils
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiABout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа мои утилиты, \n содержит ряд небольших программ, который могут пригодится в жизни.","О программе");
        }
    }
}
