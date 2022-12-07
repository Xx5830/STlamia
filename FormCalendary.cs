using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;

namespace STlamia1._1
{
    public partial class FormCalendary : Form    
    {
        //Construct
        public FormCalendary()
        {
            InitializeComponent();
        }
        private void FormCalendary_Load(object sender, EventArgs e)
        {
            //Reblanck(false);
        }

        //Var  
        public DateTime _CurrentDate = DateTime.Now;
        public USBlank[] blank = new USBlank[42];
        /* first -> year + month + day
         * second.Item1 -> task(номер задачи)
         * second.Item2 -> hour:minut(время в часах и минутах)
         * second.Item3 -> difficulties(Сложность)
         * seconf.Item4 -> referens
         */
        static public Dictionary <string, List<Tuple<string, string, string, string>>> DataInfo = new Dictionary<string, List<Tuple<string, string, string, string>>>();
        USInfo activeinfo;

        //Function
        public void DisplayCalendary(DateTime now)
        {
            //Установка новой даты на лэйблах(года и месяца) под формат
            {
                Mskyear.Text = now.Year.ToString();

                if (now.Month.ToString().Length < 2) Mskmonth.Text = "0" + now.Month.ToString();
                else Mskmonth.Text = now.Month.ToString();
            }

            //Обновляем Календарь
            {
                DateTime startoftheMonth = new DateTime(now.Year, now.Month, 1); //первый день в месяце
                int days = DateTime.DaysInMonth(now.Year, now.Month); //кол-во дней в месяце
                int dayoftheweek = Convert.ToInt32(startoftheMonth.DayOfWeek.ToString("d")); //день недели у первого дня
                if (dayoftheweek == 0) dayoftheweek = 7;


                int me = 0;

                //Выделяем дни из прошлого месяца
                for (int i = 0; i < dayoftheweek - 1; i++, ++me)
                {
                    blank[me].Refrush(
                        (DateTime.DaysInMonth(now.AddMonths(-1).Year, now.AddMonths(-1).Month) - dayoftheweek + 2 + i).ToString(),
                        Color.Gray
                        );
                }

                //Выделяем наши дни
                for (int i = 0; i < days; i++, ++me)
                {
                    //Если мы в нашем месяце и году, то выделяем наш день
                    if (_CurrentDate.Year == DateTime.Now.Year && _CurrentDate.Month == DateTime.Now.Month && i + 1 == _CurrentDate.Day)
                    {
                        blank[me].Refrush((i + 1).ToString(), Color.DodgerBlue);
                    }
                    //Если в этот день мы решали задачи, то выделяем его
                    else if (DataInfo.ContainsKey(now.Year.ToString() + now.Month.ToString() + (i + 1).ToString()))
                    {
                        blank[me].Refrush((i + 1).ToString(), Color.Lime);
                    }
                    else blank[me].Refrush((i + 1).ToString(), Color.Black);
                }

                //Выделяем дни из следущго месяца
                for (int i = 0; i < 42 - days - dayoftheweek + 1; i++, ++me)
                {
                    blank[me].Refrush((i + 1).ToString(), Color.Gray);
                }
            }
        }
        public void ReDataInfo(List<List<USCell>> list)
        {
            string year, month, day, hour, minute, task, difficult, referens;

            //Очищаем нашу прошлую информацию
            DataInfo.Clear();

            //Идем по листу переберая все элементы
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].Count; j++)
                {
                    //Добавляем в нашу хэш таблицу все элеметы (year + month + day) -> task, time
                    year = list[i][j]._Me.Year.ToString();
                    month = list[i][j]._Me.Month.ToString();
                    day = list[i][j]._Me.Day.ToString();
                    hour = list[i][j]._Me.Hour.ToString();
                    minute = list[i][j]._Me.Minute.ToString();
                    task = list[i][j].task;
                    difficult = list[i][j].difficult;
                    referens = list[i][j].referens;

                    //Если такой хэш уже существует, то добавляем ему этот элемент
                    if (DataInfo.ContainsKey(year + month + day))
                    {
                        DataInfo[year + month + day].Add(new Tuple<string, string, string, string>(task, hour + ":" + minute, difficult, referens));
                    }
                    else
                    {
                        DataInfo.Add(year + month + day, new List<Tuple<string, string, string, string>> ());

                        DataInfo[year + month + day].Add(new Tuple<string, string, string, string>(task, hour + ":" + minute, difficult, referens));
                    }
                }
            }

            //Обновлем дни
            {
                DisplayCalendary(_CurrentDate);
            }
        }
        public void DisplayInfoTask(string day)
        {
            //Чистим прошлую информацию
            ServingInfoPanel.Controls.Clear();

            string key = _CurrentDate.Year.ToString() + _CurrentDate.Month.ToString() + day;

            //Перебераем всю информацию на данный день
            for (int i = 0; i < DataInfo[key].Count; i++)
            {
                USInfo info = new USInfo(this);

                string date = DataInfo[key][i].Item2, hour = "", minute = "";
                string difficult = DataInfo[key][i].Item3, referens = DataInfo[key][i].Item4; 
                bool flag = false;

                //Определяем часы и время из даты, т.к имеем только общую дату
                for (int j = 0; j < date.Length; j++)
                {
                    if (date[j] == ':') flag = true;
                    else if (flag) minute += date[j];
                    else hour += date[j];
                }

                //Если первый элемент, то активируем его
                if (i == 0)
                {
                    //Сохраняем активированный элемент
                    activeinfo = info;

                    //Создаем и инцилизируем информацию у элемента
                    info.Refrush(DataInfo[key][i].Item1, hour, minute, difficult, referens, Color.Red);

                    //Сама активизация
                    info.ActiveThis();
                }
                else info.Refrush(DataInfo[key][i].Item1, hour, minute, difficult, referens, Color.Aquamarine);

                info.Dock = DockStyle.Left;

                //Добавлем элемент в табло задач
                ServingInfoPanel.Controls.Add(info);
            }
        }
        public void DisplayInfoObautTask(USInfo info)
        {
            //Отключаем прошлую активную задачу
            if (activeinfo != info) activeinfo.PasiveThis();

            //Переносим информацию о задаче на наше информационное табло
            TimeInfo.Text = info.hour + ":" + info.minute;
            DifficultInfo.Text = info.difficult;

            if (info.referens == "" || info.referens.Length == 1 || info.referens == string.Empty) ReferensLink.Text = "Non";
            else ReferensLink.Text = info.referens;

            //Сохраняем нашу задачу
            activeinfo = info;
        }
        public void Reblanck(bool flag_active_displaycalendary)
        {
            //Загружаем в календарь наши дни
            for (int i = 0; i < 42; i++)
            {
                USBlank a = new USBlank(this);

                blank[i] = a;
                Calendary.Controls.Add(a);
            }

            //Определяем эти дни
            if (flag_active_displaycalendary) DisplayCalendary(_CurrentDate);
        }

        //Button
        private void NextBut_Click(object sender, EventArgs e)
        {
            _CurrentDate = _CurrentDate.AddMonths(1);

            DisplayCalendary(_CurrentDate);
        }

        private void LastBut_Click(object sender, EventArgs e)
        {
            _CurrentDate = _CurrentDate.AddMonths(-1);

            DisplayCalendary(_CurrentDate);
        }

        private void ReturnNowBut_Click(object sender, EventArgs e)
        {
            _CurrentDate = DateTime.Now;

            DisplayCalendary(_CurrentDate);
        }

        private void OKBut_Click(object sender, EventArgs e)
        {
            if (Mskyear.Text.ToString().Length == 4 && int.Parse(Mskmonth.Text.ToString()) <= 12)
            {
                VerCorrect.Visible = false;

                _CurrentDate = new DateTime(int.Parse(Mskyear.Text.ToString()), int.Parse(Mskmonth.Text.ToString()), _CurrentDate.Day);

                DisplayCalendary(_CurrentDate);
            }
            else
            {
                VerCorrect.Visible = true;
            }
        }

        private void ReferensLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ReferensLink.Text != "Non")
            {
                DialogResult dialogResult = MessageBox.Show("Вы правда хотите открыть данную ссылку?",
                    "Открыть ссылку",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );

                if (dialogResult == DialogResult.Yes)
                {
                    ProcessStartInfo sInfo = new ProcessStartInfo(ReferensLink.Text);
                    Process.Start(sInfo);
                }
            }
        }
    }
}
