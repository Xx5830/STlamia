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
    public partial class USInfo : UserControl
    {
        public USInfo(FormCalendary calendary)
        {
            InitializeComponent();

            this.calendary = calendary;
        }

        public string task, hour, minute, difficult, referens;
        public bool activeflag;
        public FormCalendary calendary;

        private void TaskLabel_Click(object sender, EventArgs e)
        {
            if (activeflag) ActiveThis();
        }
        public void Refrush(string task, string hour, string minute, string difficult, string referens, Color color)
        {
            //Присваеваем свойства
            TaskLabel.Text = task; this.task = task;
            TaskLabel.ForeColor = color;
            this.difficult = difficult;
            this.referens = referens;

            //Если элемент норм цвета, то делаем его кнопкой
            if (color == Color.Aquamarine)
            {
                activeflag = true;

                TaskLabel.Cursor = Cursors.Hand;
            }
            else
            {
                activeflag = false;

                TaskLabel.Cursor = Cursors.Default;
            }

            //Форматируем информацию о часах и минутах
            this.hour = hour;
            if (this.hour.Length == 1) this.hour = "0" + this.hour;

            this.minute = minute;
            if (this.minute.Length == 1) this.minute = "0" + minute;
        }
        public void Refrush(Color color)
        {
            //По факту смена режима через цвет
            TaskLabel.ForeColor = color;

            if (color == Color.Aquamarine)
            {
                activeflag = true;

                TaskLabel.Cursor = Cursors.Hand;
            }
            else
            {
                activeflag = false;

                TaskLabel.Cursor = Cursors.Default;
            }
        }
        public void ActiveThis()
        {
            Refrush(Color.Red);

            //Выводим информацию о задаче
            calendary.DisplayInfoObautTask(this);
        }
        public void PasiveThis()
        {
            Refrush(Color.Aquamarine);
        }

    }
}
