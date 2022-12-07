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
    public partial class USBlank : UserControl
    {
        FormCalendary calendary;
        bool flagactive;
        public USBlank(FormCalendary calendary)
        {
            InitializeComponent();

            this.calendary = calendary;
        }

        public void Refrush(string number, Color colornumber)
        {
            if (colornumber == Color.Lime)
            {
                Number.Cursor = Cursors.Hand;

                flagactive = true;
            }
            else
            {
                Number.Cursor = Cursors.Default;

                flagactive = false;
            }

            Number.Text = number;

            Number.ForeColor = colornumber;
        }

        private void Number_Click(object sender, EventArgs e)
        {
           if (flagactive) calendary.DisplayInfoTask(Number.Text);
        }
    }
}
