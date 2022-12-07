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
    public partial class FormAnalitick : Form
    {
        //Intilisation
        public FormAnalitick()
        {
            InitializeComponent();
        }


        //Var
        string maxday, maxmonth, maxdifficult, counttask;
        DateTime maxisday, maxismonth;
        
        //Function
        public void ReInfo()
        {
            Daymaxinfo.Text = maxday;
            Datedaymaxinfo.Text = $"{maxisday.Day.ToString()}.{maxisday.Month.ToString()}.{maxisday.Year.ToString()}";

            Monthmaxinfo.Text = maxmonth;
            Datemonthmaxinfo.Text = $"{maxismonth.Month.ToString()}.{maxismonth.Year.ToString()}";

            Maxdifficultinfo.Text = maxdifficult;
            Countdayinfo.Text = counttask;
        }
        public void ReData(AnalitickExample now)
        {
            if (now.maxday == 0) maxday = "Non";
            else maxday = now.maxday.ToString();

            if (now.maxmonth == 0) maxmonth = "Non";
            else maxmonth = now.maxmonth.ToString();

            if (now.maxdifficult == 0) maxdifficult = "Non";
            else maxdifficult = now.maxdifficult.ToString();

            counttask = now.counttask.ToString();
            maxisday = now.dayismax;
            maxismonth = now.monthismax;

            ReInfo();
        }
    }
}
