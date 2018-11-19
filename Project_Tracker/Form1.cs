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
            
            //Make sure every entry is filled before adding       
            if (Risk_Name_Textbox.Text != "" && Risk_Description_RichTextBox.Text != "" && !string.IsNullOrEmpty(Risk_Status_ComboBox.Text))
            {                
                string Rname = Risk_Name_Textbox.Text;
                string Rdescription = Risk_Description_RichTextBox.Text;
                string Rstatus = Risk_Status_ComboBox.SelectedItem.ToString();
                Risk NewRisk = new Risk(Rname, Rdescription, Rstatus);
                RiskList.Add(NewRisk);
                Risks_ListBox.Items.Add(Risk_Name_Textbox.Text);
                TempProj.setProjRisk(RiskList);  //update the list
                Risk_Name_Textbox.Text = "";
                Risk_Description_RichTextBox.Text = "";
                Risk_Status_ComboBox.Text = "";
            }




            //For adding requirements

            //Make sure every entry is filled before adding       
            if (Requirements_Name_TextBox.Text != "" && Requirements_Description_RichTextBox.Text != "" && Functional_RadioButton.Checked || NonFunctional_RadioButton.Checked) {
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
            
                Requirement NewRequirement = new Requirement(ReqName, ReqDescription, ReqType);
                RequirementList.Add(NewRequirement);
                Requirements_ListBox.Items.Add(Requirements_Name_TextBox.Text);
                TempProj.setProjReq(RequirementList);
                Requirements_Name_TextBox.Text = "";
                Requirements_Description_RichTextBox.Text = "";
                Functional_RadioButton.Checked = false;
                NonFunctional_RadioButton.Checked = false;
            }
               

        }

        private void Save_Project_Button_Click(object sender, EventArgs e)
        {
            string ProjName = Project_Name_Textbox.Text;
        }

        private void Modify_Button_Click(object sender, EventArgs e)
        {
            //need to add check if anything is selected or anything is in the listbox


            //Determine which listbox has a selected item

            if (Modify_Button.Text == "Modify Selected Item")
            {
                Modify_Button.Text = "Update Selected Item";
            }
            else if (Modify_Button.Text == "Update Selected Item")
            {
                Modify_Button.Text = "Modify Selected Item";
            }

            //For modifying risks

            if (Risks_ListBox.SelectedIndex > -1) {
                //Load into fields the selected risk
                int x = Risks_ListBox.SelectedIndex;
                Risk_Name_Textbox.Text = RiskList[x].Name;
                Risk_Description_RichTextBox.Text = RiskList[x].Description;
                Risk_Status_ComboBox.SelectedIndex = Risk_Status_ComboBox.FindStringExact(RiskList[x].RiskStatus);
            }

            //For modifying requirements

            if (Requirements_ListBox.SelectedIndex > -1) {
                //Load into fields the selected requirements
                int y = Requirements_ListBox.SelectedIndex;
                Requirements_Name_TextBox.Text = RequirementList[y].Name;
                Requirements_Description_RichTextBox.Text = RequirementList[y].Description;
                bool ReqStatus = RequirementList[y].Functional;
                if (ReqStatus == true)
                {
                    Functional_RadioButton.Checked = true;
                }
                else {
                    NonFunctional_RadioButton.Checked = true;
                }
            }
            

            //Need to prevent user from trying to modify risk and requirement at the same time, prevent selection change while modifying
            //Need to add functionality to update the item when done modifying, can change button text to say save
        }

        private void Requirements_ListBox_MouseDown(object sender, MouseEventArgs e)
        {
            Risks_ListBox.ClearSelected();
        }

        private void Risks_ListBox_MouseDown(object sender, MouseEventArgs e)
        {
            Requirements_ListBox.ClearSelected();
        }
    }
}
