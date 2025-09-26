namespace WinForms_EF_CF
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            
            this.dataGridView1.Location = new System.Drawing.Point(14, 14);
            this.dataGridView1.Size = new System.Drawing.Size(500, 250);
            
            this.txtName.Location = new System.Drawing.Point(12, 230);
            this.txtName.PlaceholderText = "Name";
            
            this.txtAge.Location = new System.Drawing.Point(12, 260);
            this.txtAge.PlaceholderText = "Age";
            
            this.txtDepartment.Location = new System.Drawing.Point(12, 290);
            this.txtDepartment.PlaceholderText = "Dept";
            
            this.btnAdd.Text = "Add";
            this.btnAdd.Location = new System.Drawing.Point(11, 310);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Location = new System.Drawing.Point(85, 310);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            
            this.btnDelete.Text = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(180, 310);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            
            this.btnReset.Text = "Reset";
            this.btnReset.Location = new System.Drawing.Point(260, 310);
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReset);
            this.Text = "Student Management (Code First)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}


