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

namespace ZoomOpener
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
            #region initialize database
            Directory.CreateDirectory("C:\\ZoomOpener");
            TextWriter sunday = new StreamWriter("C:\\ZoomOpener\\Sunday.txt");
            TextWriter monday = new StreamWriter("C:\\ZoomOpener\\Monday.txt");
            TextWriter tuesday = new StreamWriter("C:\\ZoomOpener\\Tuesday.txt");
            TextWriter wednesday = new StreamWriter("C:\\ZoomOpener\\Wednesday.txt");
            TextWriter thursday = new StreamWriter("C:\\ZoomOpener\\Thursday.txt");
            TextWriter friday = new StreamWriter("C:\\ZoomOpener\\Friday.txt");
            TextWriter saturday = new StreamWriter("C:\\ZoomOpener\\Saturday.txt");
            sunday.Close();
            monday.Close();
            tuesday.Close();
            wednesday.Close();
            thursday.Close();
            friday.Close();
            saturday.Close();
            #endregion
        }

        private void finish_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Load = new Load();
            Load.Closed += (s, args) => this.Close();
            Load.Show();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (day.Text == "Sunday")
            {
                string newlines = name.Text + ";" + time.Text + ";" + link.Text;

                File.AppendAllText(@"C:\ZoomOpener\Sunday.txt", newlines + Environment.NewLine);
            }

            if (day.Text == "Monday")
            {
                string newlines = name.Text + ";" + time.Text + ";" + link.Text;

                File.AppendAllText(@"C:\ZoomOpener\Monday.txt", newlines + Environment.NewLine);
            }


            if (day.Text == "Tuesday")
            {
                string newlines = name.Text + ";" + time.Text + ";" + link.Text;

                File.AppendAllText(@"C:\ZoomOpener\Tuesday.txt", newlines + Environment.NewLine);
            }


            if (day.Text == "Wednesday")
            {
                string newlines = name.Text + ";" + time.Text + ";" + link.Text;

                File.AppendAllText(@"C:\ZoomOpener\Wednesday.txt", newlines + Environment.NewLine);
            }


            if (day.Text == "Thursday")
            {
                string newlines = name.Text + ";" + time.Text + ";" + link.Text;

                File.AppendAllText(@"C:\ZoomOpener\Thursday.txt", newlines + Environment.NewLine);
            }


            if (day.Text == "Friday")
            {
                string newlines = name.Text + ";" + time.Text + ";" + link.Text;

                File.AppendAllText(@"C:\ZoomOpener\Friday.txt", newlines + Environment.NewLine);
            }


            if (day.Text == "Saturday")
            {
                string newlines = name.Text + ";" + time.Text + ";" + link.Text;

                File.AppendAllText(@"C:\ZoomOpener\Saturday.txt", newlines + Environment.NewLine);
            }
        }
    }
}
