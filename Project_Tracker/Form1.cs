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
        ProjectData TempProj = new ProjectData();

        public Main_Form()
        {
            InitializeComponent();                       

            
            
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            List<Risk> RiskList = new List<Risk>();
            Risk NewRisk = new Risk();
            NewRisk.Name = Risk_Name_Textbox.Text;
            NewRisk.Description = Risk_Description_RichTextBox.Text;
            NewRisk.RiskStatus = Risk_Status_ComboBox.SelectedText;

            RiskList.Add(NewRisk);
            Risks_ListBox.Items.Add(Risk_Name_Textbox.Text);

            TempProj.setProjRisk(RiskList);
        }

        private void Save_Project_Button_Click(object sender, EventArgs e)
        {
            string ProjName = Project_Name_Textbox.Text;
        }
    }
}
