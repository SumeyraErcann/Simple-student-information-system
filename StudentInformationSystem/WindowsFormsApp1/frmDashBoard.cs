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
    public partial class frmDashBoard : Form
    {
        StudentManager studentManager;
        public frmDashBoard()
        {
            InitializeComponent();
            studentManager = StudentManager.GetInstance();
        }
        private void frmDashBoard_Load(object sender, EventArgs e)
        {
            List();
        }
        void List()
        {
            dgStudent.DataSource = null;
            dgStudent.DataSource = studentManager.GetList();
            DatagridProbs();
        }
        void DatagridProbs()
        {
            dgStudent.Columns["Id"].Visible=false;
            dgStudent.Columns["Name"].HeaderText = "Ad Soyad";
            dgStudent.Columns["Mail"].HeaderText = "E-posta";
            dgStudent.Columns["Phone"].HeaderText = "Telefon No";
            dgStudent.Columns["Birthday"].HeaderText = "Doğum Tarihi";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtEposta.Text) || string.IsNullOrEmpty(mskphone.Text) || string.IsNullOrEmpty(mskbirth.Text))
            {
                MessageBox.Show("eksik doldurdunuz!!");
                return;

            }
            Student student = new Student(studentManager.GetMaxId(),txtName.Text, txtEposta.Text, mskphone.Text, Convert.ToDateTime(mskbirth.Text));
            MessageBox.Show(studentManager.AddStudent(student));                    
        }
        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List();
        }
        private void detayToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (dgStudent.CurrentRow==null)
            {
                MessageBox.Show("lütfen işlem yapmak istediğiniz öğrenciyi seçin");
                return;
            }
            int id = (int)dgStudent.CurrentRow.Cells["Id"].Value;
            string name = (string)dgStudent.CurrentRow.Cells["Name"].Value;
            string phone = (string)dgStudent.CurrentRow.Cells["Phone"].Value;
            string mail = (string)dgStudent.CurrentRow.Cells["Mail"].Value;
            DateTime birthday= (DateTime)dgStudent.CurrentRow.Cells["Birthday"].Value;

            Student student = new Student(id, name, mail, phone, birthday);
            Güncelle frm = new Güncelle();
            frm.student = student;
            frm.ShowDialog();
            List();
        }
    }
}
