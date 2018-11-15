namespace Project_Tracker
{
    partial class Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Add_Project_Button = new System.Windows.Forms.Button();
            this.Projects_Listbox = new System.Windows.Forms.ListBox();
            this.Edit_Project_Button = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Home_Tab = new System.Windows.Forms.TabPage();
            this.Add_Project_Tab = new System.Windows.Forms.TabPage();
            this.Save_Project_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Modify_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Requirements_Input_GroupBox = new System.Windows.Forms.GroupBox();
            this.NonFunctional_RadioButton = new System.Windows.Forms.RadioButton();
            this.Functional_RadioButton = new System.Windows.Forms.RadioButton();
            this.Requirements_ListBox = new System.Windows.Forms.ListBox();
            this.Requirements_Description_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.Requirements_Description_Label = new System.Windows.Forms.Label();
            this.Requirements_Name_TextBox = new System.Windows.Forms.TextBox();
            this.Requirements_Name_Label = new System.Windows.Forms.Label();
            this.Risk_Input_GroupBox = new System.Windows.Forms.GroupBox();
            this.Risks_ListBox = new System.Windows.Forms.ListBox();
            this.Risk_Status_Label = new System.Windows.Forms.Label();
            this.Risk_Status_ComboBox = new System.Windows.Forms.ComboBox();
            this.Risk_Description_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.Risk_Description_Label = new System.Windows.Forms.Label();
            this.Risk_Name_Textbox = new System.Windows.Forms.TextBox();
            this.Risk_Name_Label = new System.Windows.Forms.Label();
            this.Project_Description_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.Project_Description_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Team_Members_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.Team_Members_Label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Project_Manager_Label = new System.Windows.Forms.Label();
            this.Project_Name_Textbox = new System.Windows.Forms.TextBox();
            this.Project_Name_Label = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.Home_Tab.SuspendLayout();
            this.Add_Project_Tab.SuspendLayout();
            this.Requirements_Input_GroupBox.SuspendLayout();
            this.Risk_Input_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add_Project_Button
            // 
            this.Add_Project_Button.Location = new System.Drawing.Point(300, 85);
            this.Add_Project_Button.Name = "Add_Project_Button";
            this.Add_Project_Button.Size = new System.Drawing.Size(75, 23);
            this.Add_Project_Button.TabIndex = 0;
            this.Add_Project_Button.Text = "Add Project";
            this.Add_Project_Button.UseVisualStyleBackColor = true;
            // 
            // Projects_Listbox
            // 
            this.Projects_Listbox.FormattingEnabled = true;
            this.Projects_Listbox.Location = new System.Drawing.Point(97, 85);
            this.Projects_Listbox.Name = "Projects_Listbox";
            this.Projects_Listbox.Size = new System.Drawing.Size(120, 95);
            this.Projects_Listbox.TabIndex = 1;
            // 
            // Edit_Project_Button
            // 
            this.Edit_Project_Button.Location = new System.Drawing.Point(300, 128);
            this.Edit_Project_Button.Name = "Edit_Project_Button";
            this.Edit_Project_Button.Size = new System.Drawing.Size(75, 23);
            this.Edit_Project_Button.TabIndex = 2;
            this.Edit_Project_Button.Text = "Edit Project";
            this.Edit_Project_Button.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Home_Tab);
            this.tabControl1.Controls.Add(this.Add_Project_Tab);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(673, 545);
            this.tabControl1.TabIndex = 3;
            // 
            // Home_Tab
            // 
            this.Home_Tab.Controls.Add(this.Projects_Listbox);
            this.Home_Tab.Controls.Add(this.Edit_Project_Button);
            this.Home_Tab.Controls.Add(this.Add_Project_Button);
            this.Home_Tab.Location = new System.Drawing.Point(4, 22);
            this.Home_Tab.Name = "Home_Tab";
            this.Home_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Home_Tab.Size = new System.Drawing.Size(665, 519);
            this.Home_Tab.TabIndex = 0;
            this.Home_Tab.Text = "Home";
            this.Home_Tab.UseVisualStyleBackColor = true;
            // 
            // Add_Project_Tab
            // 
            this.Add_Project_Tab.Controls.Add(this.Save_Project_Button);
            this.Add_Project_Tab.Controls.Add(this.Delete_Button);
            this.Add_Project_Tab.Controls.Add(this.Modify_Button);
            this.Add_Project_Tab.Controls.Add(this.Add_Button);
            this.Add_Project_Tab.Controls.Add(this.Requirements_Input_GroupBox);
            this.Add_Project_Tab.Controls.Add(this.Risk_Input_GroupBox);
            this.Add_Project_Tab.Controls.Add(this.Project_Description_RichTextBox);
            this.Add_Project_Tab.Controls.Add(this.Project_Description_Label);
            this.Add_Project_Tab.Controls.Add(this.label1);
            this.Add_Project_Tab.Controls.Add(this.Team_Members_RichTextBox);
            this.Add_Project_Tab.Controls.Add(this.Team_Members_Label);
            this.Add_Project_Tab.Controls.Add(this.textBox1);
            this.Add_Project_Tab.Controls.Add(this.Project_Manager_Label);
            this.Add_Project_Tab.Controls.Add(this.Project_Name_Textbox);
            this.Add_Project_Tab.Controls.Add(this.Project_Name_Label);
            this.Add_Project_Tab.Location = new System.Drawing.Point(4, 22);
            this.Add_Project_Tab.Name = "Add_Project_Tab";
            this.Add_Project_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Add_Project_Tab.Size = new System.Drawing.Size(665, 519);
            this.Add_Project_Tab.TabIndex = 1;
            this.Add_Project_Tab.Text = "Add Project";
            this.Add_Project_Tab.UseVisualStyleBackColor = true;
            // 
            // Save_Project_Button
            // 
            this.Save_Project_Button.Location = new System.Drawing.Point(110, 456);
            this.Save_Project_Button.Name = "Save_Project_Button";
            this.Save_Project_Button.Size = new System.Drawing.Size(75, 23);
            this.Save_Project_Button.TabIndex = 19;
            this.Save_Project_Button.Text = "Add Project";
            this.Save_Project_Button.UseVisualStyleBackColor = true;
            this.Save_Project_Button.Click += new System.EventHandler(this.Save_Project_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(284, 347);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(80, 49);
            this.Delete_Button.TabIndex = 18;
            this.Delete_Button.Text = "Delete Selected Item";
            this.Delete_Button.UseVisualStyleBackColor = true;
            // 
            // Modify_Button
            // 
            this.Modify_Button.Location = new System.Drawing.Point(284, 269);
            this.Modify_Button.Name = "Modify_Button";
            this.Modify_Button.Size = new System.Drawing.Size(80, 49);
            this.Modify_Button.TabIndex = 17;
            this.Modify_Button.Text = "Modify Selected Item";
            this.Modify_Button.UseVisualStyleBackColor = true;
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(284, 189);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(80, 49);
            this.Add_Button.TabIndex = 16;
            this.Add_Button.Text = "Add to List";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Requirements_Input_GroupBox
            // 
            this.Requirements_Input_GroupBox.Controls.Add(this.NonFunctional_RadioButton);
            this.Requirements_Input_GroupBox.Controls.Add(this.Functional_RadioButton);
            this.Requirements_Input_GroupBox.Controls.Add(this.Requirements_ListBox);
            this.Requirements_Input_GroupBox.Controls.Add(this.Requirements_Description_RichTextBox);
            this.Requirements_Input_GroupBox.Controls.Add(this.Requirements_Description_Label);
            this.Requirements_Input_GroupBox.Controls.Add(this.Requirements_Name_TextBox);
            this.Requirements_Input_GroupBox.Controls.Add(this.Requirements_Name_Label);
            this.Requirements_Input_GroupBox.Location = new System.Drawing.Point(384, 166);
            this.Requirements_Input_GroupBox.Name = "Requirements_Input_GroupBox";
            this.Requirements_Input_GroupBox.Size = new System.Drawing.Size(226, 253);
            this.Requirements_Input_GroupBox.TabIndex = 15;
            this.Requirements_Input_GroupBox.TabStop = false;
            this.Requirements_Input_GroupBox.Text = "Requirements Input";
            // 
            // NonFunctional_RadioButton
            // 
            this.NonFunctional_RadioButton.AutoSize = true;
            this.NonFunctional_RadioButton.Location = new System.Drawing.Point(33, 138);
            this.NonFunctional_RadioButton.Name = "NonFunctional_RadioButton";
            this.NonFunctional_RadioButton.Size = new System.Drawing.Size(160, 17);
            this.NonFunctional_RadioButton.TabIndex = 16;
            this.NonFunctional_RadioButton.TabStop = true;
            this.NonFunctional_RadioButton.Text = "Non-Functional Requirement";
            this.NonFunctional_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Functional_RadioButton
            // 
            this.Functional_RadioButton.AutoSize = true;
            this.Functional_RadioButton.Location = new System.Drawing.Point(33, 114);
            this.Functional_RadioButton.Name = "Functional_RadioButton";
            this.Functional_RadioButton.Size = new System.Drawing.Size(137, 17);
            this.Functional_RadioButton.TabIndex = 15;
            this.Functional_RadioButton.TabStop = true;
            this.Functional_RadioButton.Text = "Functional Requirement";
            this.Functional_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Requirements_ListBox
            // 
            this.Requirements_ListBox.FormattingEnabled = true;
            this.Requirements_ListBox.Location = new System.Drawing.Point(22, 162);
            this.Requirements_ListBox.Name = "Requirements_ListBox";
            this.Requirements_ListBox.Size = new System.Drawing.Size(193, 82);
            this.Requirements_ListBox.TabIndex = 14;
            // 
            // Requirements_Description_RichTextBox
            // 
            this.Requirements_Description_RichTextBox.Location = new System.Drawing.Point(88, 62);
            this.Requirements_Description_RichTextBox.Name = "Requirements_Description_RichTextBox";
            this.Requirements_Description_RichTextBox.Size = new System.Drawing.Size(127, 46);
            this.Requirements_Description_RichTextBox.TabIndex = 11;
            this.Requirements_Description_RichTextBox.Text = "";
            // 
            // Requirements_Description_Label
            // 
            this.Requirements_Description_Label.AutoSize = true;
            this.Requirements_Description_Label.Location = new System.Drawing.Point(19, 65);
            this.Requirements_Description_Label.Name = "Requirements_Description_Label";
            this.Requirements_Description_Label.Size = new System.Drawing.Size(63, 13);
            this.Requirements_Description_Label.TabIndex = 10;
            this.Requirements_Description_Label.Text = "Description:";
            // 
            // Requirements_Name_TextBox
            // 
            this.Requirements_Name_TextBox.Location = new System.Drawing.Point(88, 23);
            this.Requirements_Name_TextBox.Name = "Requirements_Name_TextBox";
            this.Requirements_Name_TextBox.Size = new System.Drawing.Size(127, 20);
            this.Requirements_Name_TextBox.TabIndex = 1;
            // 
            // Requirements_Name_Label
            // 
            this.Requirements_Name_Label.AutoSize = true;
            this.Requirements_Name_Label.Location = new System.Drawing.Point(42, 26);
            this.Requirements_Name_Label.Name = "Requirements_Name_Label";
            this.Requirements_Name_Label.Size = new System.Drawing.Size(38, 13);
            this.Requirements_Name_Label.TabIndex = 0;
            this.Requirements_Name_Label.Text = "Name:";
            // 
            // Risk_Input_GroupBox
            // 
            this.Risk_Input_GroupBox.Controls.Add(this.Risks_ListBox);
            this.Risk_Input_GroupBox.Controls.Add(this.Risk_Status_Label);
            this.Risk_Input_GroupBox.Controls.Add(this.Risk_Status_ComboBox);
            this.Risk_Input_GroupBox.Controls.Add(this.Risk_Description_RichTextBox);
            this.Risk_Input_GroupBox.Controls.Add(this.Risk_Description_Label);
            this.Risk_Input_GroupBox.Controls.Add(this.Risk_Name_Textbox);
            this.Risk_Input_GroupBox.Controls.Add(this.Risk_Name_Label);
            this.Risk_Input_GroupBox.Location = new System.Drawing.Point(31, 166);
            this.Risk_Input_GroupBox.Name = "Risk_Input_GroupBox";
            this.Risk_Input_GroupBox.Size = new System.Drawing.Size(226, 253);
            this.Risk_Input_GroupBox.TabIndex = 9;
            this.Risk_Input_GroupBox.TabStop = false;
            this.Risk_Input_GroupBox.Text = "Risks Input";
            // 
            // Risks_ListBox
            // 
            this.Risks_ListBox.FormattingEnabled = true;
            this.Risks_ListBox.Location = new System.Drawing.Point(22, 162);
            this.Risks_ListBox.Name = "Risks_ListBox";
            this.Risks_ListBox.Size = new System.Drawing.Size(193, 82);
            this.Risks_ListBox.TabIndex = 14;
            // 
            // Risk_Status_Label
            // 
            this.Risk_Status_Label.AutoSize = true;
            this.Risk_Status_Label.Location = new System.Drawing.Point(19, 128);
            this.Risk_Status_Label.Name = "Risk_Status_Label";
            this.Risk_Status_Label.Size = new System.Drawing.Size(64, 13);
            this.Risk_Status_Label.TabIndex = 13;
            this.Risk_Status_Label.Text = "Risk Status:";
            // 
            // Risk_Status_ComboBox
            // 
            this.Risk_Status_ComboBox.FormattingEnabled = true;
            this.Risk_Status_ComboBox.Items.AddRange(new object[] {
            "Identified",
            "Assessed",
            "Planned",
            "In-Process",
            "Closed",
            "Not Occurred",
            "Rejected"});
            this.Risk_Status_ComboBox.Location = new System.Drawing.Point(88, 125);
            this.Risk_Status_ComboBox.Name = "Risk_Status_ComboBox";
            this.Risk_Status_ComboBox.Size = new System.Drawing.Size(127, 21);
            this.Risk_Status_ComboBox.TabIndex = 12;
            // 
            // Risk_Description_RichTextBox
            // 
            this.Risk_Description_RichTextBox.Location = new System.Drawing.Point(88, 62);
            this.Risk_Description_RichTextBox.Name = "Risk_Description_RichTextBox";
            this.Risk_Description_RichTextBox.Size = new System.Drawing.Size(127, 46);
            this.Risk_Description_RichTextBox.TabIndex = 11;
            this.Risk_Description_RichTextBox.Text = "";
            // 
            // Risk_Description_Label
            // 
            this.Risk_Description_Label.AutoSize = true;
            this.Risk_Description_Label.Location = new System.Drawing.Point(19, 65);
            this.Risk_Description_Label.Name = "Risk_Description_Label";
            this.Risk_Description_Label.Size = new System.Drawing.Size(63, 13);
            this.Risk_Description_Label.TabIndex = 10;
            this.Risk_Description_Label.Text = "Description:";
            // 
            // Risk_Name_Textbox
            // 
            this.Risk_Name_Textbox.Location = new System.Drawing.Point(88, 23);
            this.Risk_Name_Textbox.Name = "Risk_Name_Textbox";
            this.Risk_Name_Textbox.Size = new System.Drawing.Size(127, 20);
            this.Risk_Name_Textbox.TabIndex = 1;
            // 
            // Risk_Name_Label
            // 
            this.Risk_Name_Label.AutoSize = true;
            this.Risk_Name_Label.Location = new System.Drawing.Point(42, 26);
            this.Risk_Name_Label.Name = "Risk_Name_Label";
            this.Risk_Name_Label.Size = new System.Drawing.Size(38, 13);
            this.Risk_Name_Label.TabIndex = 0;
            this.Risk_Name_Label.Text = "Name:";
            // 
            // Project_Description_RichTextBox
            // 
            this.Project_Description_RichTextBox.Location = new System.Drawing.Point(132, 82);
            this.Project_Description_RichTextBox.Name = "Project_Description_RichTextBox";
            this.Project_Description_RichTextBox.Size = new System.Drawing.Size(128, 59);
            this.Project_Description_RichTextBox.TabIndex = 8;
            this.Project_Description_RichTextBox.Text = "";
            // 
            // Project_Description_Label
            // 
            this.Project_Description_Label.AutoSize = true;
            this.Project_Description_Label.Location = new System.Drawing.Point(27, 82);
            this.Project_Description_Label.Name = "Project_Description_Label";
            this.Project_Description_Label.Size = new System.Drawing.Size(99, 13);
            this.Project_Description_Label.TabIndex = 7;
            this.Project_Description_Label.Text = "Project Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "*One member per line";
            // 
            // Team_Members_RichTextBox
            // 
            this.Team_Members_RichTextBox.Location = new System.Drawing.Point(482, 79);
            this.Team_Members_RichTextBox.Name = "Team_Members_RichTextBox";
            this.Team_Members_RichTextBox.Size = new System.Drawing.Size(127, 46);
            this.Team_Members_RichTextBox.TabIndex = 5;
            this.Team_Members_RichTextBox.Text = "";
            // 
            // Team_Members_Label
            // 
            this.Team_Members_Label.AutoSize = true;
            this.Team_Members_Label.Location = new System.Drawing.Point(391, 79);
            this.Team_Members_Label.Name = "Team_Members_Label";
            this.Team_Members_Label.Size = new System.Drawing.Size(83, 13);
            this.Team_Members_Label.TabIndex = 4;
            this.Team_Members_Label.Text = "Team Members:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(482, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Project_Manager_Label
            // 
            this.Project_Manager_Label.AutoSize = true;
            this.Project_Manager_Label.Location = new System.Drawing.Point(388, 37);
            this.Project_Manager_Label.Name = "Project_Manager_Label";
            this.Project_Manager_Label.Size = new System.Drawing.Size(88, 13);
            this.Project_Manager_Label.TabIndex = 2;
            this.Project_Manager_Label.Text = "Project Manager:";
            // 
            // Project_Name_Textbox
            // 
            this.Project_Name_Textbox.Location = new System.Drawing.Point(132, 37);
            this.Project_Name_Textbox.Name = "Project_Name_Textbox";
            this.Project_Name_Textbox.Size = new System.Drawing.Size(127, 20);
            this.Project_Name_Textbox.TabIndex = 1;
            // 
            // Project_Name_Label
            // 
            this.Project_Name_Label.AutoSize = true;
            this.Project_Name_Label.Location = new System.Drawing.Point(52, 40);
            this.Project_Name_Label.Name = "Project_Name_Label";
            this.Project_Name_Label.Size = new System.Drawing.Size(74, 13);
            this.Project_Name_Label.TabIndex = 0;
            this.Project_Name_Label.Text = "Project Name:";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(665, 519);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 570);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main_Form";
            this.Text = "Project Tracker";
            this.tabControl1.ResumeLayout(false);
            this.Home_Tab.ResumeLayout(false);
            this.Add_Project_Tab.ResumeLayout(false);
            this.Add_Project_Tab.PerformLayout();
            this.Requirements_Input_GroupBox.ResumeLayout(false);
            this.Requirements_Input_GroupBox.PerformLayout();
            this.Risk_Input_GroupBox.ResumeLayout(false);
            this.Risk_Input_GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add_Project_Button;
        private System.Windows.Forms.ListBox Projects_Listbox;
        private System.Windows.Forms.Button Edit_Project_Button;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Home_Tab;
        private System.Windows.Forms.TabPage Add_Project_Tab;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Team_Members_RichTextBox;
        private System.Windows.Forms.Label Team_Members_Label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Project_Manager_Label;
        private System.Windows.Forms.TextBox Project_Name_Textbox;
        private System.Windows.Forms.Label Project_Name_Label;
        private System.Windows.Forms.Label Project_Description_Label;
        private System.Windows.Forms.RichTextBox Project_Description_RichTextBox;
        private System.Windows.Forms.GroupBox Risk_Input_GroupBox;
        private System.Windows.Forms.Label Risk_Status_Label;
        private System.Windows.Forms.ComboBox Risk_Status_ComboBox;
        private System.Windows.Forms.RichTextBox Risk_Description_RichTextBox;
        private System.Windows.Forms.Label Risk_Description_Label;
        private System.Windows.Forms.TextBox Risk_Name_Textbox;
        private System.Windows.Forms.Label Risk_Name_Label;
        private System.Windows.Forms.ListBox Risks_ListBox;
        private System.Windows.Forms.GroupBox Requirements_Input_GroupBox;
        private System.Windows.Forms.RadioButton NonFunctional_RadioButton;
        private System.Windows.Forms.RadioButton Functional_RadioButton;
        private System.Windows.Forms.ListBox Requirements_ListBox;
        private System.Windows.Forms.RichTextBox Requirements_Description_RichTextBox;
        private System.Windows.Forms.Label Requirements_Description_Label;
        private System.Windows.Forms.TextBox Requirements_Name_TextBox;
        private System.Windows.Forms.Label Requirements_Name_Label;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Modify_Button;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Save_Project_Button;
    }
}

