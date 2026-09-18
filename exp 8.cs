using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentForm
{
    public class Form1 : Form
    {
        TextBox txtName;
        ComboBox cmbDepartment;
        RadioButton rdoMale;
        RadioButton rdoFemale;
        CheckBox chkCSharp;
        CheckBox chkJava;
        CheckBox chkPython;
        Button btnSubmit;

        public Form1()
        {
            this.Text = "Student Registration";
            this.Size = new Size(500, 420);
            this.BackColor = Color.LightBlue;

            // Name
            Label lblName = new Label();
            lblName.Text = "Name:";
            lblName.Location = new Point(40, 40);
            lblName.AutoSize = true;

            txtName = new TextBox();
            txtName.Location = new Point(150, 40);
            txtName.Width = 250;

            // Department
            Label lblDepartment = new Label();
            lblDepartment.Text = "Department:";
            lblDepartment.Location = new Point(40, 80);
            lblDepartment.AutoSize = true;

            cmbDepartment = new ComboBox();
            cmbDepartment.Location = new Point(150, 80);
            cmbDepartment.Width = 250;

            cmbDepartment.Items.Add("CSE");
            cmbDepartment.Items.Add("IT");
            cmbDepartment.Items.Add("ECE");
            cmbDepartment.Items.Add("EEE");

            // Gender
            Label lblGender = new Label();
            lblGender.Text = "Gender:";
            lblGender.Location = new Point(40, 125);
            lblGender.AutoSize = true;

            rdoMale = new RadioButton();
            rdoMale.Text = "Male";
            rdoMale.Location = new Point(150, 125);
            rdoMale.AutoSize = true;

            rdoFemale = new RadioButton();
            rdoFemale.Text = "Female";
            rdoFemale.Location = new Point(230, 125);
            rdoFemale.AutoSize = true;

            // Skills
            Label lblSkills = new Label();
            lblSkills.Text = "Skills:";
            lblSkills.Location = new Point(40, 170);
            lblSkills.AutoSize = true;

            chkCSharp = new CheckBox();
            chkCSharp.Text = "C#";
            chkCSharp.Location = new Point(150, 170);
            chkCSharp.AutoSize = true;

            chkJava = new CheckBox();
            chkJava.Text = "Java";
            chkJava.Location = new Point(220, 170);
            chkJava.AutoSize = true;

            chkPython = new CheckBox();
            chkPython.Text = "Python";
            chkPython.Location = new Point(300, 170);
            chkPython.AutoSize = true;

            // Submit Button
            btnSubmit = new Button();
            btnSubmit.Text = "Submit";
            btnSubmit.Location = new Point(150, 230);
            btnSubmit.Width = 120;
            btnSubmit.Height = 40;

            btnSubmit.BackColor = Color.DarkBlue;
            btnSubmit.ForeColor = Color.White;

            btnSubmit.Click += btnSubmit_Click;

            // Add controls
            this.Controls.Add(lblName);
            this.Controls.Add(txtName);

            this.Controls.Add(lblDepartment);
            this.Controls.Add(cmbDepartment);

            this.Controls.Add(lblGender);
            this.Controls.Add(rdoMale);
            this.Controls.Add(rdoFemale);

            this.Controls.Add(lblSkills);
            this.Controls.Add(chkCSharp);
            this.Controls.Add(chkJava);
            this.Controls.Add(chkPython);

            this.Controls.Add(btnSubmit);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string gender = "";

            if (rdoMale.Checked)
                gender = "Male";
            else if (rdoFemale.Checked)
                gender = "Female";

            string skills = "";

            if (chkCSharp.Checked)
                skills += "C# ";

            if (chkJava.Checked)
                skills += "Java ";

            if (chkPython.Checked)
                skills += "Python";

            MessageBox.Show(
                "Name: " + txtName.Text +
                "\nDepartment: " + cmbDepartment.Text +
                "\nGender: " + gender +
                "\nSkills: " + skills,
                "Student Details"
            );
        }
    }
}