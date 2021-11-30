using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaceCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private string spl2sec(TextBox x)
        {
            string a = x.Text;     
                    
            decimal min = Convert.ToDecimal(a.Split(':')[0]);                          //amount of minutes
            decimal sec = Convert.ToDecimal(a.Substring(a.LastIndexOf(':') + 1));  //amount of seconds

            decimal seconds = (min * 60) + sec;

            a = seconds.ToString();
            return a;
        }

        private void origtext()
        {
            if (textDist.Text == "")
            {
                textDist.Text = "Metres";
                textDist.ForeColor = Color.Gray;
            }
            if (textSplit.Text == "")
            {
                textSplit.Text = "mm:ss[.0]";
                textSplit.ForeColor = Color.Gray;
            }
            if (textTime.Text == "")
            {
                textTime.Text = "mm:ss[.0]";
                textTime.ForeColor = Color.Gray;
            }
            if (textWeight.Text == "")
            {
                textWeight.Text = "kg";
                textWeight.ForeColor = Color.Gray;
            }
        }

        private void clear(TextBox x)
        {
            if (x.Text == "Metres")
            {
                x.Text = "";
                x.ForeColor = Color.Black;
            }
            if (x.Text == "mm:ss[.0]")
            {
                x.Text = "";
                x.ForeColor = Color.Black;
            }
            if (x.Text == "kg")
            {
                x.Text = "";
                x.ForeColor = Color.Black;
            }
        }

        private void buttonDist_Click(object sender, EventArgs e)
        {

            try
            {


                textDist.ForeColor = Color.Black;

                string seconds = spl2sec(textSplit);
                string time = spl2sec(textTime);

                decimal distance = Convert.ToDecimal(time) / Convert.ToDecimal(seconds) * 500;

                textDist.Text = Math.Round(distance, 0).ToString();

            }
            catch { textDist.ForeColor = Color.Gray; }
                       

        }

        private void buttonSplit_Click(object sender, EventArgs e)
        {

            try
            {

                textSplit.ForeColor = Color.Black;

                decimal distance = Convert.ToDecimal(textDist.Text);
                decimal time = Convert.ToDecimal(spl2sec(textTime));
                decimal split = (500 * time) / distance;
                decimal splitmin = Math.Floor(split / 60);
                decimal splitsec = ((split / 60) - splitmin) * 60;

                splitsec = Math.Round(splitsec, 1);

                string splittot = splitmin.ToString() + ":" + splitsec.ToString("00.0");
                textSplit.Text = splittot;
            }
            catch { textSplit.ForeColor = Color.Gray; }
        }

        private void buttonTime_Click(object sender, EventArgs e)
        {
            try{

            textTime.ForeColor = Color.Black;

            decimal distance = Convert.ToDecimal(textDist.Text);
            decimal split = Convert.ToDecimal(spl2sec(textSplit));

            decimal time = (distance * split) / 500;
            time = time / 60;
            decimal timesec = ((time) - (Math.Floor(time)))*60;
            decimal timemin = Math.Floor(time);

            string timetot = timemin.ToString() + ":" + timesec.ToString("00.0");
            textTime.Text = timetot;
            Console.WriteLine(timesec);
            Console.WriteLine(timemin);
            }
            catch { textTime.ForeColor = Color.Gray; }
        }

        private void buttonWeight_Click(object sender, EventArgs e)
        {
            try
            {
                textWeight.ForeColor = Color.Black;

                double wf = Math.Pow((Convert.ToDouble(textWeight.Text) * 49 / 6000), 0.222);


                //Corrected time = Wf x actual time (seconds)

                double time = Convert.ToDouble(spl2sec(textTime));
                double WAtime = wf * time;

                WAtime = WAtime / 60;
                double timesec = ((WAtime) - (Math.Floor(WAtime))) * 60;
                double timemin = Math.Floor(WAtime);
                string timetot = timemin.ToString() + ":" + timesec.ToString("00.0");
                textWATime.Text = timetot;


                //Corrected distance = actual distance / Wf
                double distance = Convert.ToDouble(textDist.Text);
                double WAdist = distance / wf;
                textWADist.Text = Math.Round(WAdist, 0).ToString();

            }
            catch { textWeight.ForeColor = Color.Gray; }

        }



        private void textDist_Leave(object sender, EventArgs e)
        {
            origtext();
        }
        private void textSplit_Leave(object sender, EventArgs e)
        {
            origtext();
        }
        private void textTime_Leave(object sender, EventArgs e)
        {
            origtext();
        }
        private void textWeight_Leave(object sender, EventArgs e)
        {
            origtext();
        }

        private void textDist_Enter(object sender, EventArgs e)
        {
            clear(textDist);
        }
        private void textSplit_Enter(object sender, EventArgs e)
        {
            clear(textSplit);
        }
        private void textTime_Enter(object sender, EventArgs e)
        {
            clear(textTime);
        }
        private void textWeight_Enter(object sender, EventArgs e)
        {
            clear(textWeight);
        }




    }
}
