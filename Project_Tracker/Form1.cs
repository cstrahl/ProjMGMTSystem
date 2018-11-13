using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Tracker
{
    public partial class Main_Form : Form
    {
        private List<ProjectData> ProjectList = new List<ProjectData>();

        public Main_Form()
        {
            InitializeComponent();

            ProjectData x = new ProjectData();
            

            Risk y = new Risk();
            
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
