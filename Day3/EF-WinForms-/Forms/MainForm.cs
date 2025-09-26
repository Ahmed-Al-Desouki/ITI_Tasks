using System;
using System.Linq;
using System.Windows.Forms;
using WinForms_EF_CF.Models;
using WinForms_EF_CF.Repositories;

namespace WinForms_EF_CF
{
    public partial class MainForm : Form
    {
        private readonly StudentRepository _repository;

        public MainForm()
        {
            InitializeComponent();
            _repository = new StudentRepository();
            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.DataSource = _repository.GetAll().ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var student = new Student
            {
                Name = txtName.Text,
                Age = int.Parse(txtAge.Text),
                Department = txtDepartment.Text
            };
            _repository.Add(student);
            LoadData();
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                var student = _repository.GetById(id);
                student.Name = txtName.Text;
                student.Age = int.Parse(txtAge.Text);
                student.Department = txtDepartment.Text;
                _repository.Update(student);
                LoadData();
                ClearInputs();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                _repository.Delete(id);
                LoadData();
                ClearInputs();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtName.Text = "";
            txtAge.Text = "";
            txtDepartment.Text = "";
        }
    }
}
