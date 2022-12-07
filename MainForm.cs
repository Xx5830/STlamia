using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace STlamia1._1
{
    public partial class MainForm : Form
    {
        //Intilialize
        public MainForm()
        {
            InitializeComponent();

            //Загрузка данных
            {
                var exePath = AppDomain.CurrentDomain.BaseDirectory;//path to exe file
                var path = Path.Combine(exePath, @"DataFileRes\ResTask.txt");

                string[] str = File.ReadAllLines(path);
                string current = "";
                int index = 0, stay = 1, mi = 1;

                for (int i = 0; i < str.Length; i++)
                {
                    USCell cell = new USCell(formView);
                    string year = "", month = "", day = "", hour = "", minute = "", task = "", difficult = "", referens = "";
                    stay = 1;

                    for (int j = 0; j < str[i].Length; j++)
                    {
                        if (str[i][j] == ' ' && current != "")
                        {
                            switch (stay)
                            {
                                case 1:
                                    year = current;
                                    break;
                                case 2:
                                    month = current;
                                    break;
                                case 3:
                                    day = current;
                                    break;
                                case 4:
                                    hour = current;
                                    break;
                                case 5:
                                    minute = current;
                                    break;
                                case 6:
                                    task = current;
                                    break;
                                case 7:
                                    difficult = current;
                                    break;
                                case 8:
                                    referens = current;
                                    break;
                            }

                            ++stay; current = "";
                        }
                        else current += str[i][j];
                    }

                    if (current != "")
                    {
                        switch (stay)
                        {
                            case 1:
                                year = current;
                                break;
                            case 2:
                                month = current;
                                break;
                            case 3:
                                day = current;
                                break;
                            case 4:
                                hour = current;
                                break;
                            case 5:
                                minute = current;
                                break;
                            case 6:
                                task = current;
                                break;
                            case 7:
                                difficult = current;
                                break;
                            case 8:
                                referens = current;
                                break;
                        }

                        ++stay; current = "";
                    }

                    if (stay == 9)
                    {
                        cell.Refrush(year, month, day, hour, minute, task, difficult, "");
                    }
                    else
                    {
                        cell.Refrush(year, month, day, hour, minute, task, difficult, referens);
                    }

                    formView.list[index].Add(cell);

                    ++mi;
                    
                    if (mi == 10)
                    {
                        List<USCell> a = new List<USCell>();
                        formView.list.Add(a);

                        mi = 1; ++index;
                    }
                }
            }

            //Открывает первое меню
            {
                MainPanel.Controls.Add(formCalendary);
                formCalendary.Show();

                //DataInfoReload
                {
                    formCalendary.Reblanck(false);

                    formCalendary.ReDataInfo(formView.list);
                }
            }
        }


        //Var
        public Panel PCalendary = new Panel(), PStatic = new Panel(), PEventList = new Panel();
        partMenu menu = partMenu.calendary;
        FormCalendary formCalendary = new FormCalendary { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        FormAnalitick formAnalitick = new FormAnalitick() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        FormView formView = new FormView() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };


        //Enum
        public enum partMenu
        {
            calendary,
            analitick,
            View
        }


        //Button
        private void CalendaryBut_Click(object sender, EventArgs e)
        {
            if (menu == partMenu.calendary) return;

            //Refresh fon
            {
                if (menu == partMenu.analitick) AnalitickBut.Image = ImageFon.Panel3_171x43Old;
                else if (menu == partMenu.View) ViewBut.Image = ImageFon.Panel3_171x43Old;

                CalendaryBut.Image = ImageFon.Panel3_171x43New; menu = partMenu.calendary;
            }

            //DataInfoReload
            {
                formCalendary.ReDataInfo(formView.list);
            }

            //Work Form
            {
                MainPanel.Controls.Clear();

                formCalendary.FormBorderStyle = FormBorderStyle.None;
                MainPanel.Controls.Add(formCalendary);
                formCalendary.Show();
            }
        }
        private void AnalitickBut_Click(object sender, EventArgs e)
        {
            if (menu == partMenu.analitick) return;

            //Refresh fon
            {
                if (menu == partMenu.calendary) CalendaryBut.Image = ImageFon.Panel3_171x43Old;
                else if (menu == partMenu.View) ViewBut.Image = ImageFon.Panel3_171x43Old;

                AnalitickBut.Image = ImageFon.Panel3_171x43New; menu = partMenu.analitick;
            }

            //Work Form
            {
                MainPanel.Controls.Clear();

                formAnalitick.FormBorderStyle = FormBorderStyle.None;
                MainPanel.Controls.Add(formAnalitick);
                formAnalitick.Show();
            }
        }
        private void ViewBut_Click(object sender, EventArgs e)
        {
            if (menu == partMenu.View) return;

            //Refresh fon
            {
                if (menu == partMenu.calendary) CalendaryBut.Image = ImageFon.Panel3_171x43Old;
                else if (menu == partMenu.analitick) AnalitickBut.Image = ImageFon.Panel3_171x43Old;

                ViewBut.Image = ImageFon.Panel3_171x43New; menu = partMenu.View;
            }

            //Work Forms
            {
                MainPanel.Controls.Clear();

                formView.FormBorderStyle = FormBorderStyle.None;
                MainPanel.Controls.Add(formView);
                formView.Show();
            }
        }
        private void ExitBut_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Вы правда хотите выйти?",
                "Выход",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (result == DialogResult.Yes)
            {
                //Сохранение ресурсов
                {
                    var exePath = AppDomain.CurrentDomain.BaseDirectory;//path to exe file
                    var path = Path.Combine(exePath, @"DataFileRes\ResTask.txt");

                    File.WriteAllText(path, string.Empty);

                    List<string> str = new List<string> ();

                    foreach (var s in formView.list)
                    {
                        foreach(var now in s)
                        {
                            str.Add(
                                now._Me.Year.ToString() + " " +
                                now._Me.Month.ToString() + " " +
                                now._Me.Day.ToString() + " " +
                                now._Me.Hour.ToString() + " " +
                                now._Me.Minute.ToString() + " " +
                                now.task + " " +
                                now.difficult + " " +
                                now.referens
                                );
                        }
                    }


                    File.WriteAllLines(path, str);

                    Close();
                }
            }
        }
    }
}
