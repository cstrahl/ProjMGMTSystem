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
            if (Risk_Name_Textbox.Text != "" && Risk_Description_TextBox.Text != "" && !string.IsNullOrEmpty(Risk_Status_ComboBox.Text))
            {
                Risk NewRisk = new Risk(Risk_Name_Textbox.Text, Risk_Description_TextBox.Text, Risk_Status_ComboBox.SelectedItem.ToString());
                RiskList.Add(NewRisk);
                Risks_ListBox.Items.Add(Risk_Name_Textbox.Text);
                TempProj.setProjRisk(RiskList);  //update the list
                Risk_Name_Textbox.Text = "";
                Risk_Description_TextBox.Text = "";
                Risk_Status_ComboBox.Text = "";
            }
            

            //For adding requirements

            //Make sure every entry is filled before adding       
            if (Requirements_Name_TextBox.Text != "" && Requirements_Description_TextBox.Text != "" && Functional_RadioButton.Checked || NonFunctional_RadioButton.Checked) {
                bool ReqType = false;
                if (Functional_RadioButton.Checked == true) {
                    ReqType = true;
                }
                else if (NonFunctional_RadioButton.Checked == true)
                {
                    ReqType = false;
                }
            
                Requirement NewRequirement = new Requirement(Requirements_Name_TextBox.Text, Requirements_Description_TextBox.Text, ReqType);
                RequirementList.Add(NewRequirement);
                Requirements_ListBox.Items.Add(Requirements_Name_TextBox.Text);
                TempProj.setProjReq(RequirementList);
                Requirements_Name_TextBox.Text = "";
                Requirements_Description_TextBox.Text = "";
                Functional_RadioButton.Checked = false;
                NonFunctional_RadioButton.Checked = false;
            }
        }

        private void Save_Project_Button_Click(object sender, EventArgs e)
        {
            if (Project_Name_Textbox.Text == "" || Project_Manager_Textbox.Text == "" || Project_Description_TextBox.Text == "" || Team_Members_TextBox.Text == "" || Risks_ListBox.Items.Count == 0 || Requirements_ListBox.Items.Count == 0) {
                Error_Label.Visible = true;
                return;
            }

            TempProj.setProjName(Project_Name_Textbox.Text);
            string MangrName = Project_Manager_Textbox.Text;
            try
            {
                //Assuming first and last name of manager are typed
                string[] ManagerName = MangrName.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                Person Manager = new Person(ManagerName[0], ManagerName[1]);
                TempProj.setProjManager(Manager);
            }
            catch {
                //If Project Manager first name given and last name was not typed
                Person Manager2 = new Person(Project_Manager_Textbox.Text);
                TempProj.setProjManager(Manager2);
            }
            
            TempProj.setProjDescrip(Project_Description_TextBox.Text);

            //add members, loop through list
            string[] Members = Team_Members_TextBox.Text.Split('\n'); //Put each name typed in list
            List<Person> Tmembers = new List<Person>();  //Create a team members list to store the people
            foreach (string Persn in Members) {
                try
                {
                    //Split name into first and last using space
                    string[] EachName = Persn.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                    Person PerTemp = new Person(EachName[0], EachName[1]);    //Store each name as a person
                    Tmembers.Add(PerTemp);
                }
                catch {
                    Person PerTemp2 = new Person(Persn);  //If only first names were typed
                    Tmembers.Add(PerTemp2);
                }                
            }

            TempProj.setProjRisk(RiskList);
            TempProj.setProjReq(RequirementList);
            ProjectList.Add(TempProj);
            Projects_Listbox.Items.Add(TempProj.getProjName());
        }

        private void Modify_Button_Click(object sender, EventArgs e)
        {
            //if both listboxes are empty or neither of them have an item selected then dont run the code below
            if (Risks_ListBox.Items.Count == 0 && Requirements_ListBox.Items.Count == 0 || Risks_ListBox.SelectedIndex == -1 && Requirements_ListBox.SelectedIndex == -1) {
                return;
            }


            if (Modify_Button.Text == "Modify Selected Item")
            {
                Modify_Button.Text = "Update Selected Item";
                Add_Button.Enabled = false;
                Delete_Button.Enabled = false;

                //For modifying risks
                if (Risks_ListBox.SelectedIndex > -1)
                {
                    //Load into fields the selected risk
                    int x = Risks_ListBox.SelectedIndex;
                    Risk_Name_Textbox.Text = RiskList[x].Name;
                    Risk_Description_TextBox.Text = RiskList[x].Description;                                      
                    Risk_Status_ComboBox.Text = RiskList[x].RiskStatus;
                    Risks_ListBox.Enabled = false;
                    Requirements_ListBox.Enabled = false;
                }

                //For modifying requirements
                if (Requirements_ListBox.SelectedIndex > -1)
                {
                    //Load into fields the selected requirement
                    int y = Requirements_ListBox.SelectedIndex;
                    Requirements_Name_TextBox.Text = RequirementList[y].Name;
                    Requirements_Description_TextBox.Text = RequirementList[y].Description;
                    bool ReqStatus = RequirementList[y].Functional;
                    if (ReqStatus == true)
                    {
                        Functional_RadioButton.Checked = true;
                    }
                    else
                    {
                        NonFunctional_RadioButton.Checked = true;
                    }
                    Requirements_ListBox.Enabled = false;
                    Risks_ListBox.Enabled = false;
                }
            }
            else if (Modify_Button.Text == "Update Selected Item")
            {
                Modify_Button.Text = "Modify Selected Item";
                Add_Button.Enabled = true;
                Delete_Button.Enabled = true;

                //Rewrites the risk
                if (Risks_ListBox.SelectedIndex > -1) {
                    Risk UpdatedRisk = new Risk(Risk_Name_Textbox.Text, Risk_Description_TextBox.Text, Risk_Status_ComboBox.SelectedItem.ToString());
                    RiskList[Risks_ListBox.SelectedIndex] = UpdatedRisk;
                    Risks_ListBox.Items[Risks_ListBox.SelectedIndex] = Risk_Name_Textbox.Text;
                    Risks_ListBox.ClearSelected();
                    Risk_Name_Textbox.Text = "";
                    Risk_Description_TextBox.Text = "";
                    Risk_Status_ComboBox.Text = "";
                    Risks_ListBox.Enabled = true;
                    Requirements_ListBox.Enabled = true;
                    TempProj.setProjRisk(RiskList); //update list of risks
                }

                //Rewrites the requirement
                if (Requirements_ListBox.SelectedIndex > -1) {
                    bool RequireType = false;
                    if (Functional_RadioButton.Checked == true)
                    {
                        RequireType = true;
                    }
                    else if (NonFunctional_RadioButton.Checked == true)
                    {
                        RequireType = false;
                    }

                    Requirement UpdatedRequirement = new Requirement(Requirements_Name_TextBox.Text, Requirements_Description_TextBox.Text, RequireType);
                    RequirementList[Requirements_ListBox.SelectedIndex] = UpdatedRequirement;
                    Requirements_ListBox.Items[Requirements_ListBox.SelectedIndex] = Requirements_Name_TextBox.Text;
                    Requirements_ListBox.ClearSelected();
                    Requirements_Name_TextBox.Text = "";
                    Requirements_Description_TextBox.Text = "";
                    Functional_RadioButton.Checked = false;
                    NonFunctional_RadioButton.Checked = false;
                    Requirements_ListBox.Enabled = true;
                    Risks_ListBox.Enabled = true;
                    TempProj.setProjReq(RequirementList); //updates list of requirements
                }
            }
        }

        private void Hide_Error_Graphics() {
            ProjectName_PictureBox.Visible = false;
            ProjectManager_PictureBox.Visible = false;
            ProjectDescription_PictureBox.Visible = false;
            TeamMembers_PictureBox.Visible = false;
            RiskName_PictureBox.Visible = false;
            RiskDescription_PictureBox.Visible = false;
            RiskStatus_PictureBox.Visible = false;
            RequirementsName_PictureBox.Visible = false;
            RequirementsDescription_PictureBox.Visible = false;
            Functional_PictureBox.Visible = false;
            NonFunctional_PictureBox.Visible = false;
            Error_Label.Visible = false;
        }

        private void Requirements_ListBox_MouseDown(object sender, MouseEventArgs e)
        {
            Risks_ListBox.ClearSelected(); //Prevents risks from being selected while requirements are selected
        }

        private void Risks_ListBox_MouseDown(object sender, MouseEventArgs e)
        {
            Requirements_ListBox.ClearSelected();  //Prevents requirements from being selected while risks are selected
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {         
            //if both listboxes are empty or neither of them have an item selected then dont run the code below
            if (Risks_ListBox.Items.Count == 0 && Requirements_ListBox.Items.Count == 0 || Risks_ListBox.SelectedIndex == -1 && Requirements_ListBox.SelectedIndex == -1)
            {
                return;
            }

            if (Risks_ListBox.SelectedIndex > -1) {
                RiskList.RemoveAt(Risks_ListBox.SelectedIndex);
                Risks_ListBox.Items.RemoveAt(Risks_ListBox.SelectedIndex);
                TempProj.setProjRisk(RiskList);  //update the list after deleting
            }

            if (Requirements_ListBox.SelectedIndex > -1) {
                RequirementList.RemoveAt(Requirements_ListBox.SelectedIndex);
                Requirements_ListBox.Items.RemoveAt(Requirements_ListBox.SelectedIndex);
                TempProj.setProjReq(RequirementList);  //update the list after deleting
            }
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            Hide_Error_Graphics();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Project_Name_Textbox_Leave(object sender, EventArgs e)
        {
            if (Project_Name_Textbox.Text == "")
            {
                ProjectName_PictureBox.Visible = true;
            }
            else {
                ProjectName_PictureBox.Visible = false;
            }
        }

        private void Add_Project_Button_Click(object sender, EventArgs e)
        {
            Project_TabControl.SelectTab(Add_Project_Tab);
        }

        private void Project_Manager_Textbox_Leave(object sender, EventArgs e)
        {
            if (Project_Manager_Textbox.Text == "")
            {
                ProjectManager_PictureBox.Visible = true;
            }
            else
            {
                ProjectManager_PictureBox.Visible = false;
            }
        }

        private void Project_Description_TextBox_Leave(object sender, EventArgs e)
        {
            if (Project_Description_TextBox.Text == "")
            {
                ProjectDescription_PictureBox.Visible = true;
            }
            else
            {
                ProjectDescription_PictureBox.Visible = false;
            }
        }

        private void Team_Members_TextBox_Leave(object sender, EventArgs e)
        {
            if (Team_Members_TextBox.Text == "")
            {
                TeamMembers_PictureBox.Visible = true;
            }
            else
            {
                TeamMembers_PictureBox.Visible = false;
            }
        }

        private void UpdateTracking_Button_Click(object sender, EventArgs e)
        {
            Project_TabControl.SelectTab(Tracking_Tab);
        }

        private void ViewProjectDetails_Button_Click(object sender, EventArgs e)
        {
            string Project_Text;

            //get current project and assign it to temp; extract all of its text and display it in richtextbox
        }

        private void Modify_Project_Button_Click(object sender, EventArgs e)
        {
            Project_TabControl.SelectTab(Add_Project_Tab);

            //load in the whole project to text boxes and listboxes
        }
    }
}
