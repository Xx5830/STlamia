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
    public partial class AddForm : Form
    {
        public Example Me, lastExample;

        public AddForm(Example Current, Example lastExample)
        {
            InitializeComponent();

            Me = Current;
            this.lastExample = lastExample;
            //Заполняем данные с прошлого раза
            {
                YearBox.Text = lastExample.year;
                MonthBox.Text = lastExample.month;
                DayBox.Text = lastExample.day;
                TimeBox.Text = lastExample.hour + lastExample.minute;
                TaskBox.Text = lastExample.task;
            }
        }

        public void Nun()
        {
            NonLabel.Visible = true;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Add_Click(object sender, EventArgs e)
        {
            //Input
            {
                Me.year = YearBox.Text;
                if (int.Parse(Me.year) < 2000)
                {
                    Nun();

                    return;
                }

                Me.month = MonthBox.Text;
                if (int.Parse(Me.month) == 0 || int.Parse(Me.month) > 12)
                {
                    Nun();

                    return;
                }

                Me.day = DayBox.Text;
                if (int.Parse(Me.day) == 0 || int.Parse(Me.day) > DateTime.DaysInMonth(int.Parse(Me.year), int.Parse(Me.month)))
                {
                    Nun();

                    return;
                }

                Me.hour = TimeBox.Text[0].ToString() + TimeBox.Text[1].ToString();
                if (int.Parse(Me.hour) >= 24)
                {
                    Nun();

                    return;
                }

                Me.minute = TimeBox.Text[3].ToString() + TimeBox.Text[4].ToString();
                if (int.Parse(Me.minute) >= 60)
                {
                    Nun();

                    return;
                }

                Me.task = TaskBox.Text;
                if (int.Parse(Me.task) == 0)
                {
                    Nun();

                    return;
                }

                Me.difficult = DifficultBox.Text;
                if (int.Parse(Me.difficult) <= 0 || int.Parse(Me.difficult) >= 100)
                {
                    Nun();

                    return;
                }

                Me.referens = ReferenseBox.Text;
            }

            //Fill
            {
                lastExample.year = Me.year;
                lastExample.month = Me.month;
                lastExample.day = Me.day;
                lastExample.hour = Me.hour;
                lastExample.minute = Me.minute;
                lastExample.task = Me.task;
            }


            Me.flag = true;

            Close();
        }
    }
}
