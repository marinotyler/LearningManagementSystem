using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherLMSApp
{
    public partial class Form2 : Form
    {
        List<Student> students;
        bool click = false;
        BindingSource source = new BindingSource();
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            students = new List<Student>();
            source.DataSource = students;
            grdStudents.DataSource = source;


        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            students.Add(new Student(id: txtStuId.Text, name: txtStuName.Text, gpa: double.Parse(txtGpa.Text )));
            txtGpa.Clear();
            txtStuId.Clear();
            txtStuName.Clear();
            MessageBox.Show("Student added successfully!");
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (grdStudents.Visible)
            {
                grdStudents.Visible = false;
                grdStudents.DataSource = null;
            }
           Student remove = students.Find(x => x.Name == txtStuName.Text);
            students.Remove(remove);
            txtStuName.Clear();
            if (grdStudents.DataSource == null)
                grdStudents.DataSource = source;
       
            MessageBox.Show("Student removed successfully!");
            
            
        }

        private void btnStarPupil_Click(object sender, EventArgs e)
        {
            Student starPupil = students[0];
            foreach(var student in students)
            {
                if(student.gpa> starPupil.gpa)
                    starPupil=student;
            }
            string filePath = $"C:\\MSSA\\20483\\TeacherLMSApp\\starStudentFiles\\" + starPupil.Name.ToString();
            StreamWriter sw = null;

          
                if(!File.Exists(filePath))
                {
                   sw = File.CreateText(filePath);
                sw.Close();
                   File.WriteAllText(filePath, starPupil.ToString());
                }
                else
                {
                   File.Delete(filePath);
                   sw = File.CreateText(filePath);
                sw.Close();
                   File.WriteAllText(filePath, starPupil.ToString());
                sw.Close();
            }
           
            using (StreamReader sr = new StreamReader(filePath)) {
                MessageBox.Show(File.ReadAllText(filePath));
                 
                    }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!click)
            {
                grdStudents.Visible = true;
                btnShowGrid.Text = "Hide Students";
                click = true;
            }
            else
            {
                grdStudents.Visible = false;
                btnShowGrid.Text = "Show All Students";
                click = false;
            }
        }

        private void txtGpa_Validating(object sender, CancelEventArgs e)
        {
            if (!(double.Parse(txtGpa.Text) <=4.00D && double.Parse(txtGpa.Text) >= 0.00D))
            {
                throw new InvalidInputException("Input must be between 0.00 and 4.00");
               
            }
        }
    }
}
