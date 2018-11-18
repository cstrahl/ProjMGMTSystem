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
        List<Risk> RiskList = new List<Risk>();
        List<Requirement> RequirementList = new List<Requirement>();

        public Main_Form()
        {
            InitializeComponent();                       

            
            
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            //For addings risks         
            
            string Rname = Risk_Name_Textbox.Text;
            string Rdescription = Risk_Description_RichTextBox.Text;
            string Rstatus = Risk_Status_ComboBox.SelectedItem.ToString();
            Risk NewRisk = new Risk(Rname, Rdescription, Rstatus);
            RiskList.Add(NewRisk);           
            Risks_ListBox.Items.Add(Risk_Name_Textbox.Text);

            TempProj.setProjRisk(RiskList);


            //For adding requirements
            
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

        private void Modify_Button_Click(object sender, EventArgs e)
        {
            int x = Risks_ListBox.SelectedIndex;
            Risk_Name_Textbox.Text = RiskList[x].Name;
            Risk_Description_RichTextBox.Text = RiskList[x].Description;
            Risk_Status_ComboBox.SelectedIndex = Risk_Status_ComboBox.FindStringExact(RiskList[x].RiskStatus);            
        }
    }
}
