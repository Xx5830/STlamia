using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STlamia1._1
{
    public partial class LastChanceForm : Form
    {
        verifu ver;
        public LastChanceForm(verifu ver)
        {
            InitializeComponent();

            this.ver = ver;
        }

        private void YesBut_Click(object sender, EventArgs e)
        {
            ver.flag = true;

            Close();
        }

        private void NoBut_Click(object sender, EventArgs e)
        {
            ver.flag = false;

            Close();
        }
    }

    public class verifu
    {
        public bool flag;
    }
}
