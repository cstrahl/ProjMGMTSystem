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
            //For addings risks
            List<Risk> RiskList = new List<Risk>();
            
            string Rname = Risk_Name_Textbox.Text;
            string Rdescription = Risk_Description_RichTextBox.Text;
            string Rstatus = Risk_Status_ComboBox.SelectedText;
            Risk NewRisk = new Risk(Rname, Rdescription, Rstatus);
            RiskList.Add(NewRisk);
            Risks_ListBox.Items.Add(Risk_Name_Textbox.Text);

            TempProj.setProjRisk(RiskList);


            //For adding requirements
            List<Requirement> RequirementList = new List<Requirement>();
            string ReqName = Requirements_Name_TextBox.Text;
            string ReqDescription = Requirements_Description_RichTextBox.Text;
            bool ReqType = false;
            if (Functional_RadioButton.Checked == true) {
                ReqType = true;
            }
            else if (NonFunctional_RadioButton.Checked == true)
            {
                ReqType = false;
            }

            Requirement NewRequirement = new Requirement(ReqName ,ReqDescription, ReqType);

            RequirementList.Add(NewRequirement);
            Requirements_ListBox.Items.Add(Requirements_Name_TextBox.Text);

            TempProj.setProjReq(RequirementList);

        }

        private void Save_Project_Button_Click(object sender, EventArgs e)
        {
            string ProjName = Project_Name_Textbox.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
