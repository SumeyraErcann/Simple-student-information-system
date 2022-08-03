using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Güncelle : Form
    {
        public Student student;
        StudentManager studentManager;
        //public int studentId;
        bool start = true;
        public Güncelle()
        {
            InitializeComponent();            
            studentManager = StudentManager.GetInstance();
        }
        private void Güncelle_Load(object sender, EventArgs e)
        {
            StudentInfo();
            CmbStudentLoad();
            start = false;
        }
        void CmbStudentLoad()
        {
            cbstudents.DataSource=studentManager.GetList();
            cbstudents.DisplayMember = "Name";
            cbstudents.ValueMember = "Id";
            cbstudents.SelectedValue = 0;
        }
        void StudentInfo()
        {
            güncelleName.Text = student.Name;
            güncelleEposta.Text = student.Mail;
            güncellemskphone.Text = student.Phone;            

            string date = "";
            if (student.Birthday.ToString().Split('.')[0].Length==1)
            {
                date += "0"+student.Birthday.ToString().Split('.')[0] + ".";
            }
            else
            {
                date += student.Birthday.ToString().Split('.')[0] + ".";
            }

            if (student.Birthday.ToString().Split('.')[1].Length == 1)
            {
                date += "0" + student.Birthday.ToString().Split('.')[1] + "."+student.Birthday.ToString().Split('.')[2];
            }
            else
            {
                date += student.Birthday.ToString().Split('.')[1] + "."+student.Birthday.ToString().Split('.')[2];
            }
            güncellemskbirth.Text = date; 
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show(student.Name+" Öğrencisi güncellenecektir.Emin misiniz ?","Soru",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Student new_student = new Student(student.Id,güncelleName.Text, güncelleEposta.Text, güncelleEposta.Text, Convert.ToDateTime(güncellemskbirth.Text));
                studentManager.UpdateStudent(new_student);
            }           
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(student.Name + " Öğrencisi silinecek.Emin misiniz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {                
                studentManager.DeleteStudent(student.Id);
            }
        }
        private void cbstudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (start)
            {
                return;
            }
            if ((int)cbstudents.SelectedValue < 1)
            {
                return;
            }
            int choosenId = (int)cbstudents.SelectedValue;
            student = studentManager.GetStudentById(choosenId);
            StudentInfo();
        }
    }
}
