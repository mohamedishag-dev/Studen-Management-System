namespace Student_Management_System
{
    partial class frmDashboard
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlLogout = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnUser = new System.Windows.Forms.Button();
            this.pnlAddStudent = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.pnlStudents = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStudents = new System.Windows.Forms.Button();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.pctDashboard = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.pnlLogout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlAddStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctDashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlSidebar.Controls.Add(this.pnlLogout);
            this.pnlSidebar.Controls.Add(this.pnlUser);
            this.pnlSidebar.Controls.Add(this.pnlAddStudent);
            this.pnlSidebar.Controls.Add(this.pnlStudents);
            this.pnlSidebar.Controls.Add(this.pnlDashboard);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSidebar.ForeColor = System.Drawing.Color.White;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(240, 561);
            this.pnlSidebar.TabIndex = 2;
            // 
            // pnlLogout
            // 
            this.pnlLogout.Controls.Add(this.pictureBox4);
            this.pnlLogout.Controls.Add(this.btnLogout);
            this.pnlLogout.Location = new System.Drawing.Point(3, 346);
            this.pnlLogout.Name = "pnlLogout";
            this.pnlLogout.Size = new System.Drawing.Size(240, 54);
            this.pnlLogout.TabIndex = 2;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Student_Management_System.Properties.Resources.sign_out;
            this.pictureBox4.Location = new System.Drawing.Point(16, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(64, 6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(167, 45);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseEnter += new System.EventHandler(this.btnLogout_MouseEnter);
            this.btnLogout.MouseLeave += new System.EventHandler(this.btnLogout_MouseLeave);
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.pictureBox3);
            this.pnlUser.Controls.Add(this.btnUser);
            this.pnlUser.Location = new System.Drawing.Point(0, 289);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(240, 54);
            this.pnlUser.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Student_Management_System.Properties.Resources.person;
            this.pictureBox3.Location = new System.Drawing.Point(16, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.Transparent;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Location = new System.Drawing.Point(67, 6);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(167, 45);
            this.btnUser.TabIndex = 3;
            this.btnUser.Text = "Users";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            this.btnUser.MouseEnter += new System.EventHandler(this.btnUser_MouseEnter);
            this.btnUser.MouseLeave += new System.EventHandler(this.btnUser_MouseLeave);
            // 
            // pnlAddStudent
            // 
            this.pnlAddStudent.Controls.Add(this.pictureBox2);
            this.pnlAddStudent.Controls.Add(this.btnAddStudent);
            this.pnlAddStudent.Location = new System.Drawing.Point(3, 232);
            this.pnlAddStudent.Name = "pnlAddStudent";
            this.pnlAddStudent.Size = new System.Drawing.Size(240, 54);
            this.pnlAddStudent.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Student_Management_System.Properties.Resources.person_add;
            this.pictureBox2.Location = new System.Drawing.Point(16, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.Transparent;
            this.btnAddStudent.FlatAppearance.BorderSize = 0;
            this.btnAddStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Location = new System.Drawing.Point(64, 6);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(167, 45);
            this.btnAddStudent.TabIndex = 2;
            this.btnAddStudent.Text = "AddStudent";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            this.btnAddStudent.MouseEnter += new System.EventHandler(this.btnAddStudent_MouseEnter);
            this.btnAddStudent.MouseLeave += new System.EventHandler(this.btnAddStudent_MouseLeave);
            // 
            // pnlStudents
            // 
            this.pnlStudents.Controls.Add(this.pictureBox1);
            this.pnlStudents.Controls.Add(this.btnStudents);
            this.pnlStudents.Location = new System.Drawing.Point(3, 175);
            this.pnlStudents.Name = "pnlStudents";
            this.pnlStudents.Size = new System.Drawing.Size(240, 54);
            this.pnlStudents.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Student_Management_System.Properties.Resources.people_community;
            this.pictureBox1.Location = new System.Drawing.Point(16, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnStudents
            // 
            this.btnStudents.BackColor = System.Drawing.Color.Transparent;
            this.btnStudents.FlatAppearance.BorderSize = 0;
            this.btnStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudents.Location = new System.Drawing.Point(64, 6);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(167, 45);
            this.btnStudents.TabIndex = 1;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = false;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            this.btnStudents.MouseEnter += new System.EventHandler(this.btnStudents_MouseEnter);
            this.btnStudents.MouseLeave += new System.EventHandler(this.btnStudents_MouseLeave);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.pctDashboard);
            this.pnlDashboard.Controls.Add(this.btnDashboard);
            this.pnlDashboard.Location = new System.Drawing.Point(3, 118);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(240, 54);
            this.pnlDashboard.TabIndex = 0;
            // 
            // pctDashboard
            // 
            this.pctDashboard.BackColor = System.Drawing.Color.Transparent;
            this.pctDashboard.Image = global::Student_Management_System.Properties.Resources.home;
            this.pctDashboard.Location = new System.Drawing.Point(16, 6);
            this.pctDashboard.Name = "pctDashboard";
            this.pctDashboard.Size = new System.Drawing.Size(45, 45);
            this.pctDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctDashboard.TabIndex = 1;
            this.pctDashboard.TabStop = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(64, 6);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(167, 45);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnDashboard.MouseEnter += new System.EventHandler(this.btnDashboard_MouseEnter);
            this.btnDashboard.MouseLeave += new System.EventHandler(this.btnDashboard_MouseLeave);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(240, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(744, 561);
            this.panelContainer.TabIndex = 1;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlLogout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnlUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlAddStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctDashboard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.PictureBox pctDashboard;
        private System.Windows.Forms.Panel pnlLogout;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Panel pnlAddStudent;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStudents;
    }
}

