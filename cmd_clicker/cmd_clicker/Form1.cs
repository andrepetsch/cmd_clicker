using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.ComponentModel;

namespace cmd_clicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Initialising the checkboxes
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            checkBox4.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string commands and switches for cmd
            string switches="/s /c \"";
      
            if (checkBox1.Checked) switches += "dism /online /cleanup-image /AnalyzeComponentStore &";
            if (checkBox2.Checked) switches += "dism /online /cleanup-image /scanhealth &";
            if (checkBox3.Checked) switches += "dism /online /cleanup-image /checkhealth &";
            if (checkBox4.Checked) switches += "dism /online /cleanup-image /restorehealth &";
            if (checkBox5.Checked) switches += "pause";

            switches += "\"";

            //Start the cmd with the given commands, then exit this application

            Process.Start("cmd", switches);

            this.Close();
        }
    }
}
