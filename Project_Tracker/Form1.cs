//SWE 4663 - Software Product
//Group 2 - The Gentlemen
//Broderick Thayer, Zachary Thayer, Josh Capers, Colt Mckissick, Chris Strahl

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
        ProjectData TempProj = null;
        List<Risk> RiskList = null;
        List<Requirement> RequirementList = null;
        DataTable TrackingTable = new DataTable();
        bool ModifyingProject = false;
        int selectedIndex = 0;

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
                RisksListbox_PictureBox.Visible = false;
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
                RequirementsListBox_PictureBox.Visible = false;
            }
        }

        private void Save_Project_Button_Click(object sender, EventArgs e)
        {
            CheckForEmptyFields();

            if (Project_Name_Textbox.Text == "" || Project_Manager_Textbox.Text == "" || Project_Description_TextBox.Text == "" || Team_Members_TextBox.Text == "" || Risks_ListBox.Items.Count == 0 || Requirements_ListBox.Items.Count == 0) {
                Error_Label.Visible = true;
                return;
            }

            if (ModifyingProject == false)
            {
                TempProj.setProjName(Project_Name_Textbox.Text);
                string MangrName = Project_Manager_Textbox.Text;
                try
                {
                    //Assuming first and last name of manager are typed
                    string[] ManagerName = MangrName.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                    Person Manager = new Person(ManagerName[0], ManagerName[1]);
                    TempProj.setProjManager(Manager);
                }
                catch
                {
                    //If Project Manager first name given and last name was not typed
                    Person Manager2 = new Person(Project_Manager_Textbox.Text);
                    TempProj.setProjManager(Manager2);
                }

                TempProj.setProjDescrip(Project_Description_TextBox.Text);

                //add members, loop through list
                string[] Members = Team_Members_TextBox.Text.Split('\n'); //Put each name typed in list
                List<Person> Tmembers = new List<Person>();  //Create a team members list to store the people
                foreach (string Persn in Members)
                {
                    try
                    {
                        //Split name into first and last using space
                        string[] EachName = Persn.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                        Person PerTemp = new Person(EachName[0], EachName[1]);    //Store each name as a person
                        Tmembers.Add(PerTemp);
                    }
                    catch
                    {
                        Person PerTemp2 = new Person(Persn);  //If only first names were typed
                        Tmembers.Add(PerTemp2);
                    }
                }

                TempProj.setProjMembers(Tmembers);
                TempProj.setProjRisk(RiskList);
                TempProj.setProjReq(RequirementList);
                ProjectList.Add(TempProj);
                Projects_Listbox.Items.Add(TempProj.getProjName());
                EmptyAddProjectFields();
                Hide_Error_Graphics();
                Project_TabControl.SelectTab(Home_Tab);
            }

            if (ModifyingProject == true) {

                int a = Projects_Listbox.SelectedIndex;
                ProjectList[a].setProjName(Project_Name_Textbox.Text);
                ProjectList[a].setProjDescrip(Project_Description_TextBox.Text);
                              
                string MangrName2 = Project_Manager_Textbox.Text;
                try
                {
                    //Assuming first and last name of manager are typed
                    string[] ManagerName2 = MangrName2.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                    Person Manager2 = new Person(ManagerName2[0], ManagerName2[1]);
                    ProjectList[a].setProjManager(Manager2);
                }
                catch
                {
                    //If Project Manager first name given and last name was not typed
                    Person Manager2 = new Person(Project_Manager_Textbox.Text);
                    ProjectList[a].setProjManager(Manager2);
                }

                string[] Members2 = Team_Members_TextBox.Text.Split('\n'); //Put each name typed in list
                List<Person> Tmembers2 = new List<Person>();  //Create a team members list to store the people
                foreach (string Persn2 in Members2)
                {
                    try
                    {
                        //Split name into first and last using space
                        string[] EachName2 = Persn2.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                        Person PerTemp3 = new Person(EachName2[0], EachName2[1]);    //Store each name as a person
                        Tmembers2.Add(PerTemp3);
                    }
                    catch
                    {
                        Person PerTemp4 = new Person(Persn2);  //If only first names were typed
                        Tmembers2.Add(PerTemp4);
                    }
                }

                ProjectList[a].setProjMembers(Tmembers2);
                ProjectList[a].setProjRisk(RiskList);
                ProjectList[a].setProjReq(RequirementList);
                Projects_Listbox.Items[Projects_Listbox.SelectedIndex] = Project_Name_Textbox.Text;
                EmptyAddProjectFields();
                Hide_Error_Graphics();
                Save_Project_Button.Text = "Add Project";
                ModifyingProject = false;
                Project_TabControl.SelectTab(Home_Tab);
            }
        }

        public void CheckForEmptyFields() {
            if (Project_Name_Textbox.Text == "")
            {
                ProjectName_PictureBox.Visible = true;
            }

            if (Project_Manager_Textbox.Text == "")
            {
                ProjectManager_PictureBox.Visible = true;
            }

            if (Project_Description_TextBox.Text == "")
            {
                ProjectDescription_PictureBox.Visible = true;
            }

            if (Team_Members_TextBox.Text == "")
            {
                TeamMembers_PictureBox.Visible = true;
            }

            if (Risks_ListBox.Items.Count == 0)
            {
                RisksListbox_PictureBox.Visible = true;
            }

            if (Requirements_ListBox.Items.Count == 0)
            {
                RequirementsListBox_PictureBox.Visible = true;
            }
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
            RequirementsListBox_PictureBox.Visible = false;
            RisksListbox_PictureBox.Visible = false;
            Error_Label.Visible = false;
            HomePageError_Label.Visible = false;
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
            ProjectTracking_DataGridView.BackgroundColor = SystemColors.ControlLightLight;
            ProjectTracking_DataGridView.BorderStyle = BorderStyle.None;
            Project_TabControl.Appearance = TabAppearance.FlatButtons;
            Project_TabControl.ItemSize = new Size(0, 1);
            Project_TabControl.SizeMode = TabSizeMode.Fixed;
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
            TempProj = new ProjectData();
            RiskList = new List<Risk>();
            RequirementList = new List<Requirement>();
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
            if (Projects_Listbox.SelectedIndex == -1)
            {
                HomePageError_Label.Visible = true;
                return;
            }

            if (checkIfTableExists())
            {
                TrackingTable.Columns.Add("Name", typeof(string));
                TrackingTable.Columns.Add("Requirements Analysis", typeof(int));
                TrackingTable.Columns.Add("Designing", typeof(int));
                TrackingTable.Columns.Add("Coding", typeof(int));
                TrackingTable.Columns.Add("Testing", typeof(int));
                TrackingTable.Columns.Add("Project Management", typeof(int));

                //Add project manager
                string ProjManager = ProjectList[Projects_Listbox.SelectedIndex].getProjManager().ToString();
                TrackingNames_ComboBox.Items.Add(ProjManager);
                TrackingTable.Rows.Add(ProjManager, 0, 0, 0, 0, 0);


                //tracking names combo box needs filled with project names
                List<Person> TmembersListforCombo = ProjectList[Projects_Listbox.SelectedIndex].getProjMembers();
                foreach (Person Member in TmembersListforCombo)
                {
                    TrackingNames_ComboBox.Items.Add(Member.ToString());
                    TrackingTable.Rows.Add(Member.ToString(), 0, 0, 0, 0, 0);
                }
            }
         
            ProjectTracking_DataGridView.DataSource = TrackingTable;
            Project_TabControl.SelectTab(TrackingGrid_Tab);
        }

        private bool checkIfTableExists()
        {
            if (!TrackingTable.Columns.Contains("Name"))
                return true;
            else
                return false;
        }

        private void ViewProjectDetails_Button_Click(object sender, EventArgs e)
        {
            if (Projects_Listbox.SelectedIndex == -1) {
                HomePageError_Label.Visible = true;
                return;
            }

            //Get current project, extract all of its text and display it in richtextbox
            int b = selectedIndex;
            Console.WriteLine("Selected " + b);
            ProjectDisplay_RichTextBox.Text = ProjectList[b].getProjName() + Environment.NewLine + Environment.NewLine;
            ProjectDisplay_RichTextBox.AppendText("Manager: " + ProjectList[b].getProjManager().ToString() + Environment.NewLine + Environment.NewLine);
           
            List<Person> TeamMembersNameList2 = ProjectList[b].getProjMembers();

            string TeamMembersCSV = string.Join(", ", TeamMembersNameList2);
            ProjectDisplay_RichTextBox.AppendText("Team Members: " + TeamMembersCSV + Environment.NewLine + Environment.NewLine);

            ProjectDisplay_RichTextBox.AppendText("Description: " + ProjectList[b].getProjDescrip() + Environment.NewLine + Environment.NewLine);

            ProjectDisplay_RichTextBox.AppendText("Risks:" + Environment.NewLine);
            List<Risk> AllProjectRisks = ProjectList[b].getProjRisk();
            foreach (Risk ProjRisk in AllProjectRisks) {
                ProjectDisplay_RichTextBox.AppendText(ProjRisk.Name + ": " + ProjRisk.RiskStatus + Environment.NewLine + ProjRisk.Description + Environment.NewLine + Environment.NewLine);
            }

            ProjectDisplay_RichTextBox.AppendText(Environment.NewLine + "Requirements:" + Environment.NewLine);
            List<Requirement> AllProjectRequirements = ProjectList[b].getProjReq();
            foreach (Requirement ProjReq in AllProjectRequirements)
            {
                string type = "";
                if (ProjReq.Functional == true)
                {
                    type = "Functional";
                }
                else {
                    type = "Non-Functional";
                }
                ProjectDisplay_RichTextBox.AppendText(ProjReq.Name + ": " + type + Environment.NewLine + ProjReq.Description + Environment.NewLine + Environment.NewLine);
            }

            HomePageError_Label.Visible = false;
        }

        private void Modify_Project_Button_Click(object sender, EventArgs e)
        {
            if (Projects_Listbox.SelectedIndex == -1)
            {
                HomePageError_Label.Visible = true;
                return;
            }

            //load in the whole project to text boxes and listboxes
            if (Projects_Listbox.SelectedIndex > -1)
            {
                int z = Projects_Listbox.SelectedIndex;
                Project_TabControl.SelectTab(Add_Project_Tab);
                Project_Name_Textbox.Text = ProjectList[z].getProjName();
                Project_Manager_Textbox.Text = ProjectList[z].getProjManager().ToString();
                Project_Description_TextBox.Text = ProjectList[z].getProjDescrip();

                List<Person> TeamMembersNameList = ProjectList[z].getProjMembers();

                //used for importing team members back into textbox
                int numb = TeamMembersNameList.Count( ) - 1;
                for (int i = 0; i <= numb; i++) {
                    if (i == numb) {
                        Team_Members_TextBox.AppendText(TeamMembersNameList[i].ToString());
                        goto LeaveLoop;
                    }
                    Team_Members_TextBox.AppendText(TeamMembersNameList[i].ToString() + Environment.NewLine);
                }
                LeaveLoop:

                List<Risk> RisksforListBox = ProjectList[z].getProjRisk();
                foreach (Risk Ri in RisksforListBox)
                {
                    Risks_ListBox.Items.Add(Ri.Name);
                }

                List<Requirement> RequirementsforListBox = ProjectList[z].getProjReq();
                foreach (Requirement Req in RequirementsforListBox)
                {
                    Requirements_ListBox.Items.Add(Req.Name);
                }

                ModifyingProject = true;
                Save_Project_Button.Text = "Update Project";
                Project_TabControl.SelectTab(Add_Project_Tab);
                HomePageError_Label.Visible = false;
            }
        }

        private void EmptyAddProjectFields() {
            Project_Name_Textbox.Text = "";
            Project_Manager_Textbox.Text = "";
            Project_Description_TextBox.Text = "";
            Team_Members_TextBox.Text = "";
            Risk_Name_Textbox.Text = "";
            Risk_Description_TextBox.Text = "";
            Risk_Status_ComboBox.SelectedIndex = -1;
            Risks_ListBox.Items.Clear();
            Requirements_Name_TextBox.Text = "";
            Requirements_Description_TextBox.Text = "";
            Functional_RadioButton.Checked = false;
            NonFunctional_RadioButton.Checked = false;
            Requirements_ListBox.Items.Clear();
        }

        private void Delete_Project_Button_Click(object sender, EventArgs e)
        {
            //if both listboxes are empty or neither of them have an item selected then dont run the code below
            if (Projects_Listbox.Items.Count == 0 || Projects_Listbox.SelectedIndex == -1)
            {
                return;
            }

            if (Projects_Listbox.SelectedIndex > -1)
            {
                ProjectList.RemoveAt(Projects_Listbox.SelectedIndex);
                Projects_Listbox.Items.RemoveAt(Projects_Listbox.SelectedIndex);
            }
            ProjectDisplay_RichTextBox.Text = "";
        }

        private void TrackingToHome_Button_Click(object sender, EventArgs e)
        {
            Project_TabControl.SelectTab(Home_Tab);
            TrackingNames_ComboBox.Text = "";
            TrackingCategory_ComboBox.Text = "";
            HourlyInput_NumericUpDown.Value = 0;
            Daily_RadioButton.Checked = false;
            Weekly_RadioButton.Checked = false;
            ProjectDisplay_RichTextBox.Text = "";
        }

        private void SubmitHours_Button_Click(object sender, EventArgs e)
        {
            int HourAmount = Convert.ToInt32(HourlyInput_NumericUpDown.Value);

            if (TrackingNames_ComboBox.SelectedIndex == -1 || TrackingCategory_ComboBox.SelectedIndex == -1 || HourAmount == 0) {
                return;
            }

            //Update Table
            if (TrackingCategory_ComboBox.SelectedIndex == 0) {
                TrackingTable.Rows[TrackingNames_ComboBox.SelectedIndex]["Requirements Analysis"] = HourAmount;
            }
            else if (TrackingCategory_ComboBox.SelectedIndex == 1)
            {
                TrackingTable.Rows[TrackingNames_ComboBox.SelectedIndex]["Designing"] = HourAmount;
            }
            else if (TrackingCategory_ComboBox.SelectedIndex == 2)
            {
                TrackingTable.Rows[TrackingNames_ComboBox.SelectedIndex]["Coding"] = HourAmount;
            }
            else if (TrackingCategory_ComboBox.SelectedIndex == 3)
            {
                TrackingTable.Rows[TrackingNames_ComboBox.SelectedIndex]["Testing"] = HourAmount;
            }
            else if (TrackingCategory_ComboBox.SelectedIndex == 4)
            {
                TrackingTable.Rows[TrackingNames_ComboBox.SelectedIndex]["Project Management"] = HourAmount;
            }
        }

        private void Projects_Listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = Projects_Listbox.SelectedIndex;
        }
    }
}
