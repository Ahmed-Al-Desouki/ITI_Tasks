using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsEfCrud.Models;
using WinFormsEfCrud.Repositories;

namespace WinFormsEfCrud.Forms
{
    public partial class MainForm : Form
    {
        private readonly IRepository<Student> _studentRepo;
        private BindingSource _bindingSource = new BindingSource();
        private Student? _selectedStudent;

        public MainForm(IRepository<Student> studentRepo)
        {
            InitializeComponent();
            _studentRepo = studentRepo;

            dgvStudents.AutoGenerateColumns = false;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.MultiSelect = false;
            dgvStudents.ReadOnly = true;
            dgvStudents.AllowUserToAddRows = false;

            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID" });
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FirstName", HeaderText = "First Name" });
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LastName", HeaderText = "Last Name" });
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Email", HeaderText = "Email" });
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "EnrollmentDate", HeaderText = "Enrolled" });

            dgvStudents.DataSource = _bindingSource;

            this.Load += MainForm_Load;
            dgvStudents.SelectionChanged += DgvStudents_SelectionChanged;
            btnAdd.Click += async (_, __) => await BtnAdd_Click();
            btnUpdate.Click += async (_, __) => await BtnUpdate_Click();
            btnDelete.Click += async (_, __) => await BtnDelete_Click();
            btnReset.Click += BtnReset_Click;

            SetButtonStates(noSelection: true);
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            List<Student> students = await _studentRepo.GetAllAsync();
            _bindingSource.DataSource = students;
            ClearInputs();
            SetButtonStates(noSelection: true);
        }

        private void DgvStudents_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                _selectedStudent = null;
                ClearInputs();
                SetButtonStates(noSelection: true);
                return;
            }

            var row = dgvStudents.SelectedRows[0];
            if (row.DataBoundItem is Student s)
            {
                _selectedStudent = s;
                PopulateInputs(s);
                SetButtonStates(noSelection: false);
            }
        }

        private void PopulateInputs(Student s)
        {
            txtFirstName.Text = s.FirstName;
            txtLastName.Text = s.LastName;
            txtEmail.Text = s.Email;
            dtpEnrollment.Value = s.EnrollmentDate == DateTime.MinValue ? DateTime.Today : s.EnrollmentDate;
        }

        private void ClearInputs()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            dtpEnrollment.Value = DateTime.Today;
        }

        private void SetButtonStates(bool noSelection)
        {
            btnAdd.Enabled = noSelection;
            btnUpdate.Enabled = !noSelection;
            btnDelete.Enabled = !noSelection;
            btnReset.Visible = true;
        }

        private bool ValidateInputs(out string validationMessage)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                validationMessage = "First name is required.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                validationMessage = "Last name is required.";
                return false;
            }
            if (!IsValidEmail(txtEmail.Text))
            {
                validationMessage = "Invalid email address.";
                return false;
            }
            validationMessage = string.Empty;
            return true;
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase);
            }
            catch
            {
                return false;
            }
        }

        private async Task BtnAdd_Click()
        {
            if (!ValidateInputs(out string msg))
            {
                MessageBox.Show(msg, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newStudent = new Student
            {
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                EnrollmentDate = dtpEnrollment.Value.Date
            };

            await _studentRepo.AddAsync(newStudent);
            await _studentRepo.SaveChangesAsync();

            await LoadDataAsync();
        }

        private async Task BtnUpdate_Click()
        {
            if (_selectedStudent == null)
            {
                MessageBox.Show("Select a record to update.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidateInputs(out string msg))
            {
                MessageBox.Show(msg, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var studentToUpdate = await _studentRepo.GetByIdAsync(_selectedStudent.Id);
            if (studentToUpdate == null)
            {
                MessageBox.Show("Record not found (might have been removed).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                await LoadDataAsync();
                return;
            }

            studentToUpdate.FirstName = txtFirstName.Text.Trim();
            studentToUpdate.LastName = txtLastName.Text.Trim();
            studentToUpdate.Email = txtEmail.Text.Trim();
            studentToUpdate.EnrollmentDate = dtpEnrollment.Value.Date;

            await _studentRepo.UpdateAsync(studentToUpdate);
            await _studentRepo.SaveChangesAsync();

            await LoadDataAsync();
        }

        private async Task BtnDelete_Click()
        {
            if (_selectedStudent == null)
            {
                MessageBox.Show("Select a record to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete selected student?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            var studentToDelete = await _studentRepo.GetByIdAsync(_selectedStudent.Id);
            if (studentToDelete == null)
            {
                MessageBox.Show("Record not found (might have been removed).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                await LoadDataAsync();
                return;
            }

            await _studentRepo.DeleteAsync(studentToDelete);
            await _studentRepo.SaveChangesAsync();

            await LoadDataAsync();
        }

        private void BtnReset_Click(object? sender, EventArgs e)
        {
            dgvStudents.ClearSelection();
            _selectedStudent = null;
            ClearInputs();
            SetButtonStates(noSelection: true);
        }
    }
}
