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
    public partial class FormView : Form
    {
        //Construct
        public FormView()
        {
            InitializeComponent();

            //Создаем лист
            List<USCell> a = new List<USCell>();
            list.Add(a);
        }


        //Var
        public List<List<USCell>> list = new List<List<USCell>>();
        int _CurrentPage = 1;
        bool add_flag = true;
        Example lastExample = new Example
        {
            year = DateTime.Now.Year.ToString(),
            month = (DateTime.Now.Month.ToString().Length == 1) ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString(),
            day = (DateTime.Now.Day.ToString().Length == 1) ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString(),
            hour = DateTime.Now.Hour.ToString(),
            minute = (DateTime.Now.Minute.ToString().Length == 1) ? "0" + DateTime.Now.Minute.ToString() : DateTime.Now.Minute.ToString(),
            task = "1",
            difficult = "10",
            referens = ""
        };


        //Button
        private void AddBut_Click(object sender, EventArgs e)
        {
            if (add_flag)
            {
                //инцилизация ввод меню
                Example Current = new Example
                {
                    flag = false
                };

                //Создаем форму для заплнения
                AddForm addForm = new AddForm(Current, lastExample);
                addForm.Show();

                //Заполнение данных в отдельном потоке
                Task.Run(() =>
                {
                    //Блокируем повторное нажатие
                    add_flag = false;
                    {
                        AddBut.BackColor = Color.LightSlateGray;
                        AddBut.FlatStyle = FlatStyle.Flat;
                    }

                    //Стопарим поток пока форма не закрылась
                    while (!addForm.IsDisposed) ;
                    //Если все заполненно
                    if (Current.flag)
                    {
                        //Перетаскиваем данные в другую форму
                        USCell now = new USCell(this);
                        now.Refrush(Current.year, Current.month, Current.day, Current.hour, Current.minute, Current.task, Current.difficult, Current.referens);

                        //Добавляем нужную форму в лист
                        Add(now);
                    }

                    //Разблакироваем
                    add_flag = true;
                    {
                        AddBut.BackColor = Color.Transparent;
                        AddBut.FlatStyle = FlatStyle.Popup;
                    }
                });
            }
        }
        private void ReloadBut_Click(object sender, EventArgs e)
        {
            //Обновляем панель
            DisplayList();
        }
        private void NextBut_Click(object sender, EventArgs e)
        {
            if (_CurrentPage < list.Count)
            {
                ++_CurrentPage;

                CountLabel.Text = _CurrentPage.ToString();

                DisplayList();
            }
        }
        private void LastBut_Click(object sender, EventArgs e)
        {
            if (_CurrentPage > 1)
            {
                --_CurrentPage;

                CountLabel.Text = _CurrentPage.ToString();

                DisplayList();
            }
        }
        private void ReCount_Click(object sender, EventArgs e)
        {
            if ((CountLabel.Text.Length >= 1 && CountLabel.Text[0] >= '0' && CountLabel.Text[0] <= '9') &&
                ((CountLabel.Text.Length >= 2 && CountLabel.Text[1] >= '0' && CountLabel.Text[1] <= '9') || (CountLabel.Text.Length < 2)) &&
                ((CountLabel.Text.Length == 3 && CountLabel.Text[2] >= '0' && CountLabel.Text[2] <= '9') || (CountLabel.Text.Length < 3)))
            {
                int cu = int.Parse(CountLabel.Text);

                if (cu > list.Count)
                {
                    CountLabel.Text = list.Count.ToString();
                    
                    cu = list.Count;
                }
                if (cu < 1)
                {
                    CountLabel.Text = "1";

                    cu = 1;
                }

                _CurrentPage = cu;

                DisplayList();
            }
        }

        //Function
        public void DisplayList()
        {
            //Очищаем нынешний список
            ListPanel.Controls.Clear();

            //Находим наш список по _CurrentPage(нужная страница)
            for (int i = 0; i < list[_CurrentPage - 1].Count; i++)
            {
                //Считываем все элементы с этой страницы и добавляем их в панель на отабражение
                ListPanel.Controls.Add(list[_CurrentPage - 1][i]);
            }
        }
        public void Add(USCell cell)
        {
            //Добавляем элемент в лист, одновременно ищем для него место в сортированном списке
            for (int i = 0; i < list.Count; i++)
            {
                //Если мы в конце списка или мы больше чем последний элемент данного списка
                if (i == list.Count - 1 || list[i][list[i].Count - 1]._Me > cell._Me)
                {
                    //добавляем себя
                    list[i].Add(cell);

                    //Сортируемся по датам
                    list[i].Sort((USCell a, USCell b) => a._Me.CompareTo(b._Me));
                    

                    break;
                }
            }

            //Проверяем на переполнение
            for (int i = 0; i < list.Count; i++)
            {
                //Если в списке больше нужного
                if (list[i].Count > 9)
                {
                    //Если это последний список
                    if (i == list.Count - 1)
                    {
                        //Добавляем новый список
                        List<USCell> a = new List<USCell>();
                        list.Add(a);
                    }

                    //временно сохраняем последний элемент 
                    USCell _Current = list[i][list[i].Count - 1];

                    //удаляем лишний элемент из списка
                    list[i].RemoveAt(list[i].Count - 1);
                    //добавляем временный элемент в следущий список
                    list[i + 1].Add(_Current); list[i + 1].Sort();
                }
            }
        }
        public void Delete(USCell cell)
        {
            int indexy = 0, indexx = 0;

            //Ищем элемент который нужно удалить
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].Count; j++)
                {
                    if (list[i][j]._Me == cell._Me && list[i][j].task == cell.task)
                    {
                        indexy = i; indexx = j;

                        break;
                    }
                }
            }

            //Удалем элемент
            list[indexy].RemoveAt(indexx);

            //Проверка на не добитые листы
            for (int i = list.Count - 2; i >= 0; i--)
            {
                //Если в дисте не максимум элементов
                if (list[i].Count != 9)
                {
                    //Кол-во нужных элементов
                    int q = 9 - list[i].Count;

                    //Идем вперед и забираем от туда элементы чтоб довать сюда
                    for (int j = i + 1; j < list.Count && q != 0; j++)
                    {
                        //Пока можем и нужно забираем элементы
                        while (list[j].Count > 0 && q != 0)
                        {
                            list[i].Add(list[j][0]);

                            list[j].RemoveAt(0);

                            --q;
                        }
                    }

                    //елси наши финальные списки пусты удаляем их
                    while (list[list.Count - 1].Count == 0 && list.Count != 1)
                    {
                        if (_CurrentPage == list.Count) --_CurrentPage;

                        if (_CurrentPage == 0) _CurrentPage = 1;

                        list.RemoveAt(list.Count - 1);
                    }

                    //Начинаем проверку с начала
                    i = list.Count - 2;
                }
            }

            //Проверка на пустые листы
            for (int l = 0; l < list.Count; l++)
            {
                //Если этот элемент последнии в своем списке
                if (list.Count != 1 && list[l].Count == 0)
                {
                    if (_CurrentPage >= l + 1) --_CurrentPage;

                    if (_CurrentPage <= 0) _CurrentPage = 1;
                    if (_CurrentPage > list.Count) _CurrentPage = list.Count;

                    list.RemoveAt(l);
                }
            }
        }
    }

    public class Example
    {
        public string year, month, day, hour, minute, task, difficult, referens;
        public bool flag;
    }
}
