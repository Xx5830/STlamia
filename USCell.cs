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
    public partial class USCell : UserControl
    {
        public FormView formView;
        public DateTime _Me;
        public string task, difficult, referens;

        public USCell(FormView formView)
        {
            InitializeComponent();

            this.formView = formView;

            //Format:
            {
                this.Dock = DockStyle.Top;
            }
        }

        public void Refrush(string year, string month, string day, string hour, string minute, string task, string difficult, string referens)
        {
            DataLabel.Text = String.Format($"{year}.{month}.{day} {hour}:{minute}");
            _Me = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day), int.Parse(hour), int.Parse(minute), 1);

            TaskLabel.Text = int.Parse(task).ToString();

            this.task = int.Parse(task).ToString();
            this.difficult = difficult;
            this.referens = referens;
        }

        private void DeleteBut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы правда хотите удалить данную задачу? Вернуть обратно ее будет нельзя.",
                "Удаление",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button1
                );

            if (dialogResult == DialogResult.Yes)
            {

                DataLabel.ForeColor = Color.Gray;
                TaskLabel.ForeColor = Color.Gray;
                DeleteBut.Text = "";
                DeleteBut.Enabled = false;


                formView.Delete(this);
            }
        }
    }
}
