namespace XML_Database
{
    partial class frmMain
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
            this.gbPerson = new System.Windows.Forms.GroupBox();
            this.btnAddPet = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkCool = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPet = new System.Windows.Forms.GroupBox();
            this.btnAddThePet = new System.Windows.Forms.Button();
            this.chkTrained = new System.Windows.Forms.CheckBox();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPetType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPetName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveToDatabase = new System.Windows.Forms.Button();
            this.dgvPerson = new System.Windows.Forms.DataGridView();
            this.dgvPet = new System.Windows.Forms.DataGridView();
            this.gbPerson.SuspendLayout();
            this.gbPet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPet)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPerson
            // 
            this.gbPerson.Controls.Add(this.btnAddPet);
            this.gbPerson.Controls.Add(this.btnAdd);
            this.gbPerson.Controls.Add(this.rbFemale);
            this.gbPerson.Controls.Add(this.rbMale);
            this.gbPerson.Controls.Add(this.txtFamily);
            this.gbPerson.Controls.Add(this.label2);
            this.gbPerson.Controls.Add(this.chkCool);
            this.gbPerson.Controls.Add(this.txtName);
            this.gbPerson.Controls.Add(this.label1);
            this.gbPerson.Location = new System.Drawing.Point(12, 12);
            this.gbPerson.Name = "gbPerson";
            this.gbPerson.Size = new System.Drawing.Size(194, 191);
            this.gbPerson.TabIndex = 7;
            this.gbPerson.TabStop = false;
            this.gbPerson.Text = "Person";
            // 
            // btnAddPet
            // 
            this.btnAddPet.Location = new System.Drawing.Point(114, 150);
            this.btnAddPet.Name = "btnAddPet";
            this.btnAddPet.Size = new System.Drawing.Size(66, 29);
            this.btnAddPet.TabIndex = 15;
            this.btnAddPet.Text = "Add Pet";
            this.btnAddPet.UseVisualStyleBackColor = true;
            this.btnAddPet.Click += new System.EventHandler(this.btnAddPet_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(114, 112);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 29);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(21, 112);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 13;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(21, 89);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 12;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(59, 48);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(105, 20);
            this.txtFamily.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Family";
            // 
            // chkCool
            // 
            this.chkCool.AutoSize = true;
            this.chkCool.Location = new System.Drawing.Point(21, 157);
            this.chkCool.Name = "chkCool";
            this.chkCool.Size = new System.Drawing.Size(47, 17);
            this.chkCool.TabIndex = 9;
            this.chkCool.Text = "Cool";
            this.chkCool.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(59, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(105, 20);
            this.txtName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // gbPet
            // 
            this.gbPet.Controls.Add(this.btnAddThePet);
            this.gbPet.Controls.Add(this.chkTrained);
            this.gbPet.Controls.Add(this.nudAge);
            this.gbPet.Controls.Add(this.label6);
            this.gbPet.Controls.Add(this.txtPetType);
            this.gbPet.Controls.Add(this.label3);
            this.gbPet.Controls.Add(this.txtPetName);
            this.gbPet.Controls.Add(this.label4);
            this.gbPet.Location = new System.Drawing.Point(235, 12);
            this.gbPet.Name = "gbPet";
            this.gbPet.Size = new System.Drawing.Size(213, 150);
            this.gbPet.TabIndex = 8;
            this.gbPet.TabStop = false;
            this.gbPet.Text = "Pet";
            // 
            // btnAddThePet
            // 
            this.btnAddThePet.Location = new System.Drawing.Point(131, 108);
            this.btnAddThePet.Name = "btnAddThePet";
            this.btnAddThePet.Size = new System.Drawing.Size(66, 29);
            this.btnAddThePet.TabIndex = 19;
            this.btnAddThePet.Text = "Add";
            this.btnAddThePet.UseVisualStyleBackColor = true;
            this.btnAddThePet.Click += new System.EventHandler(this.btnAddThePet_Click);
            // 
            // chkTrained
            // 
            this.chkTrained.AutoSize = true;
            this.chkTrained.Location = new System.Drawing.Point(21, 120);
            this.chkTrained.Name = "chkTrained";
            this.chkTrained.Size = new System.Drawing.Size(62, 17);
            this.chkTrained.TabIndex = 18;
            this.chkTrained.Text = "Trained";
            this.chkTrained.UseVisualStyleBackColor = true;
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(59, 78);
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(39, 20);
            this.nudAge.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Age";
            // 
            // txtPetType
            // 
            this.txtPetType.Location = new System.Drawing.Point(59, 47);
            this.txtPetType.Name = "txtPetType";
            this.txtPetType.Size = new System.Drawing.Size(138, 20);
            this.txtPetType.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Type";
            // 
            // txtPetName
            // 
            this.txtPetName.Location = new System.Drawing.Point(59, 21);
            this.txtPetName.Name = "txtPetName";
            this.txtPetName.Size = new System.Drawing.Size(138, 20);
            this.txtPetName.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Name";
            // 
            // btnSaveToDatabase
            // 
            this.btnSaveToDatabase.Location = new System.Drawing.Point(12, 420);
            this.btnSaveToDatabase.Name = "btnSaveToDatabase";
            this.btnSaveToDatabase.Size = new System.Drawing.Size(149, 29);
            this.btnSaveToDatabase.TabIndex = 20;
            this.btnSaveToDatabase.Text = "Save To Database";
            this.btnSaveToDatabase.UseVisualStyleBackColor = true;
            this.btnSaveToDatabase.Click += new System.EventHandler(this.btnSaveToDatabase_Click);
            // 
            // dgvPerson
            // 
            this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerson.Location = new System.Drawing.Point(548, 33);
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.Size = new System.Drawing.Size(555, 192);
            this.dgvPerson.TabIndex = 21;
            this.dgvPerson.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvPerson_MouseDown);
            // 
            // dgvPet
            // 
            this.dgvPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPet.Location = new System.Drawing.Point(548, 243);
            this.dgvPet.Name = "dgvPet";
            this.dgvPet.Size = new System.Drawing.Size(555, 192);
            this.dgvPet.TabIndex = 22;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 461);
            this.Controls.Add(this.dgvPet);
            this.Controls.Add(this.dgvPerson);
            this.Controls.Add(this.btnSaveToDatabase);
            this.Controls.Add(this.gbPet);
            this.Controls.Add(this.gbPerson);
            this.Name = "frmMain";
            this.Text = "XML Database";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbPerson.ResumeLayout(false);
            this.gbPerson.PerformLayout();
            this.gbPet.ResumeLayout(false);
            this.gbPet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPerson;
        private System.Windows.Forms.Button btnAddPet;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkCool;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPet;
        private System.Windows.Forms.Button btnAddThePet;
        private System.Windows.Forms.CheckBox chkTrained;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPetType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPetName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveToDatabase;
        private System.Windows.Forms.DataGridView dgvPerson;
        private System.Windows.Forms.DataGridView dgvPet;
    }
}

