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
using System.Timers;
using System.Diagnostics;

namespace ZoomOpener
{
    public partial class Load : Form
    {
        DateTime now = DateTime.Now; //now.DayOfWeek
        //string date = DateTime.Now.ToString("HH:mm"); //date == "23:00"

        private void txtToListView()
        {
            //read the file
            StreamReader file = new StreamReader(@"C:\ZoomOpener\" + now.DayOfWeek + ".txt");

            //set list view in details mode
            classes.View = View.Details;

            //Set columns in listview
            classes.Columns.Add("Class's name");
            classes.Columns.Add("Scheduled for");
            classes.Columns.Add("Zoom link");
            string line = "";

            //read text file line by line.  
            while ((line = file.ReadLine()) != null)
            {
                var itemMC = new ListViewItem(new[] { line.ToString().Split(';')[0].ToString(), line.ToString().Split(';')[1].ToString(), line.ToString().Split(';')[2].ToString()});
                classes.Items.Add(itemMC);
            }
            file.Close();

            // Resize the columns
            for (int i = 0; i < classes.Columns.Count; i++)
            {
                classes.Columns[i].Width = -2;
            }
        }

        public static void OpenZoomMeeting(string link)
        {
            string zoomDirectory = Environment.ExpandEnvironmentVariables(@"%APPDATA%\Zoom\bin");
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = $@"{zoomDirectory}\Zoom.exe",
                Arguments = $"--url={link}",
                WorkingDirectory = zoomDirectory
            };
            Process.Start(startInfo);
        }

        private void CheckZoom()
        {
            for (int i = 0; i<classes.Items.Count; i++)
            {
                if (DateTime.Now.ToString("HH:mm") == classes.Items[i].SubItems[1].Text)
                {
                    OpenZoomMeeting(classes.Items[i].SubItems[2].Text);
                }
            }
        }
        public Load()
        {
            InitializeComponent();
            txtToListView();
            today.Text = "Current classes present of " + now.DayOfWeek;
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            CheckZoom();
        }
    }
}
