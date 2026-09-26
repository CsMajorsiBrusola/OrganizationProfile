namespace OrganizationProfile
{
    partial class frmRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtStudentNo = new TextBox();
            txtLastName = new TextBox();
            txtAge = new TextBox();
            DPBirthday = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            cbPrograms = new ComboBox();
            txtFirstName = new TextBox();
            label10 = new Label();
            txtMiddleInitial = new TextBox();
            cbGender = new ComboBox();
            txtContactNo = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 41);
            label1.Name = "label1";
            label1.Size = new Size(191, 41);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 140);
            label2.Name = "label2";
            label2.Size = new Size(116, 28);
            label2.TabIndex = 1;
            label2.Text = "Student No.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 215);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(96, 296);
            label4.Name = "label4";
            label4.Size = new Size(47, 28);
            label4.TabIndex = 3;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(61, 363);
            label5.Name = "label5";
            label5.Size = new Size(85, 28);
            label5.TabIndex = 4;
            label5.Text = "Birthday";
            // 
            // txtStudentNo
            // 
            txtStudentNo.BorderStyle = BorderStyle.FixedSingle;
            txtStudentNo.Location = new Point(145, 140);
            txtStudentNo.Margin = new Padding(3, 4, 3, 4);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(226, 27);
            txtStudentNo.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Location = new Point(145, 217);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(226, 27);
            txtLastName.TabIndex = 6;
            // 
            // txtAge
            // 
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Location = new Point(145, 299);
            txtAge.Margin = new Padding(3, 4, 3, 4);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(123, 27);
            txtAge.TabIndex = 7;
            // 
            // DPBirthday
            // 
            DPBirthday.Location = new Point(145, 367);
            DPBirthday.Margin = new Padding(3, 4, 3, 4);
            DPBirthday.Name = "DPBirthday";
            DPBirthday.Size = new Size(282, 27);
            DPBirthday.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(408, 140);
            label6.Name = "label6";
            label6.Size = new Size(88, 28);
            label6.TabIndex = 9;
            label6.Text = "Program";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(391, 215);
            label7.Name = "label7";
            label7.Size = new Size(106, 28);
            label7.TabIndex = 10;
            label7.Text = "First Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(419, 299);
            label8.Name = "label8";
            label8.Size = new Size(76, 28);
            label8.TabIndex = 11;
            label8.Text = "Gender";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(501, 365);
            label9.Name = "label9";
            label9.Size = new Size(116, 28);
            label9.TabIndex = 12;
            label9.Text = "Contact No.";
            // 
            // cbPrograms
            // 
            cbPrograms.FormattingEnabled = true;
            cbPrograms.Location = new Point(501, 140);
            cbPrograms.Margin = new Padding(3, 4, 3, 4);
            cbPrograms.Name = "cbPrograms";
            cbPrograms.Size = new Size(386, 28);
            cbPrograms.TabIndex = 13;
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Location = new Point(501, 217);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(207, 27);
            txtFirstName.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(729, 215);
            label10.Name = "label10";
            label10.Size = new Size(43, 28);
            label10.TabIndex = 15;
            label10.Text = "M.I.";
            label10.Click += label10_Click;
            // 
            // txtMiddleInitial
            // 
            txtMiddleInitial.BorderStyle = BorderStyle.FixedSingle;
            txtMiddleInitial.Location = new Point(775, 217);
            txtMiddleInitial.Margin = new Padding(3, 4, 3, 4);
            txtMiddleInitial.Name = "txtMiddleInitial";
            txtMiddleInitial.Size = new Size(111, 27);
            txtMiddleInitial.TabIndex = 16;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(501, 301);
            cbGender.Margin = new Padding(3, 4, 3, 4);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(207, 28);
            cbGender.TabIndex = 17;
            // 
            // txtContactNo
            // 
            txtContactNo.BorderStyle = BorderStyle.FixedSingle;
            txtContactNo.Location = new Point(623, 367);
            txtContactNo.Margin = new Padding(3, 4, 3, 4);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(263, 27);
            txtContactNo.TabIndex = 18;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(378, 448);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(160, 40);
            button1.TabIndex = 19;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 516);
            Controls.Add(button1);
            Controls.Add(txtContactNo);
            Controls.Add(cbGender);
            Controls.Add(txtMiddleInitial);
            Controls.Add(label10);
            Controls.Add(txtFirstName);
            Controls.Add(cbPrograms);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(DPBirthday);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentNo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmRegistration";
            Text = "Organization Profile";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtStudentNo;
        private TextBox txtLastName;
        private TextBox txtAge;
        private DateTimePicker DPBirthday;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox cbPrograms;
        private TextBox textBox4;
        private Label label10;
        private TextBox txtMiddleInitial;
        private ComboBox cbGender;
        private TextBox txtContactNo;
        private Button button1;
        private TextBox txtFirstName;
    }
}
