namespace Student_Management_System
{
    partial class ucStudents
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv1.ColumnHeadersHeight = 30;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColName,
            this.ColAge,
            this.ColGender,
            this.ColPhone,
            this.ColAdress});
            this.dgv1.EnableHeadersVisualStyles = false;
            this.dgv1.Location = new System.Drawing.Point(25, 179);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.RowTemplate.Height = 30;
            this.dgv1.Size = new System.Drawing.Size(687, 357);
            this.dgv1.TabIndex = 7;
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Width = 80;
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Name";
            this.ColName.Name = "ColName";
            this.ColName.Width = 175;
            // 
            // ColAge
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.ColAge.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColAge.HeaderText = "Age";
            this.ColAge.Name = "ColAge";
            this.ColAge.Width = 80;
            // 
            // ColGender
            // 
            this.ColGender.HeaderText = "Gender";
            this.ColGender.Name = "ColGender";
            // 
            // ColPhone
            // 
            this.ColPhone.HeaderText = "Phone";
            this.ColPhone.Name = "ColPhone";
            this.ColPhone.Width = 150;
            // 
            // ColAdress
            // 
            this.ColAdress.HeaderText = "Adress";
            this.ColAdress.Name = "ColAdress";
            this.ColAdress.Width = 120;
            // 
            // ucStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.dgv1);
            this.Name = "ucStudents";
            this.Size = new System.Drawing.Size(744, 561);
            this.Load += new System.EventHandler(this.ucStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAdress;
    }
}
