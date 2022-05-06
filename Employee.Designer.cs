namespace EmployesManagement
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.EmpIdTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.EmpNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmpPhoneTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmpAdresseTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.EmpPositionCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EmpDoB = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.EmpEduCb = new System.Windows.Forms.ComboBox();
            this.EmpGenderCb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AddBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EditBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DeleteBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.HomeBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EmpDGView = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(99, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manage Employee";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.EmpDGView);
            this.panel1.Controls.Add(this.HomeBtn);
            this.panel1.Controls.Add(this.DeleteBtn);
            this.panel1.Controls.Add(this.EditBtn);
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Controls.Add(this.EmpGenderCb);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.EmpEduCb);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.EmpDoB);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.EmpPositionCb);
            this.panel1.Controls.Add(this.EmpPhoneTb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.EmpAdresseTb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.EmpNameTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.EmpIdTb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1093, 492);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Employee Id";
            // 
            // EmpIdTb
            // 
            this.EmpIdTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.EmpIdTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.EmpIdTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.EmpIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpIdTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EmpIdTb.ForeColor = System.Drawing.Color.OrangeRed;
            this.EmpIdTb.HintForeColor = System.Drawing.Color.Empty;
            this.EmpIdTb.HintText = "";
            this.EmpIdTb.isPassword = false;
            this.EmpIdTb.LineFocusedColor = System.Drawing.Color.Brown;
            this.EmpIdTb.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.EmpIdTb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.EmpIdTb.LineThickness = 3;
            this.EmpIdTb.Location = new System.Drawing.Point(16, 94);
            this.EmpIdTb.Margin = new System.Windows.Forms.Padding(4);
            this.EmpIdTb.MaxLength = 32767;
            this.EmpIdTb.Name = "EmpIdTb";
            this.EmpIdTb.Size = new System.Drawing.Size(93, 27);
            this.EmpIdTb.TabIndex = 6;
            this.EmpIdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // EmpNameTb
            // 
            this.EmpNameTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.EmpNameTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.EmpNameTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.EmpNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpNameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EmpNameTb.ForeColor = System.Drawing.Color.OrangeRed;
            this.EmpNameTb.HintForeColor = System.Drawing.Color.Empty;
            this.EmpNameTb.HintText = "";
            this.EmpNameTb.isPassword = false;
            this.EmpNameTb.LineFocusedColor = System.Drawing.Color.Brown;
            this.EmpNameTb.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.EmpNameTb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.EmpNameTb.LineThickness = 3;
            this.EmpNameTb.Location = new System.Drawing.Point(163, 95);
            this.EmpNameTb.Margin = new System.Windows.Forms.Padding(4);
            this.EmpNameTb.MaxLength = 32767;
            this.EmpNameTb.Name = "EmpNameTb";
            this.EmpNameTb.Size = new System.Drawing.Size(144, 26);
            this.EmpNameTb.TabIndex = 8;
            this.EmpNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(188, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Employee Name";
            // 
            // EmpPhoneTb
            // 
            this.EmpPhoneTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.EmpPhoneTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.EmpPhoneTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.EmpPhoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpPhoneTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EmpPhoneTb.ForeColor = System.Drawing.Color.OrangeRed;
            this.EmpPhoneTb.HintForeColor = System.Drawing.Color.Empty;
            this.EmpPhoneTb.HintText = "";
            this.EmpPhoneTb.isPassword = false;
            this.EmpPhoneTb.LineFocusedColor = System.Drawing.Color.Brown;
            this.EmpPhoneTb.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.EmpPhoneTb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.EmpPhoneTb.LineThickness = 3;
            this.EmpPhoneTb.Location = new System.Drawing.Point(17, 343);
            this.EmpPhoneTb.Margin = new System.Windows.Forms.Padding(4);
            this.EmpPhoneTb.MaxLength = 32767;
            this.EmpPhoneTb.Name = "EmpPhoneTb";
            this.EmpPhoneTb.Size = new System.Drawing.Size(115, 33);
            this.EmpPhoneTb.TabIndex = 12;
            this.EmpPhoneTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(12, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Employee Position";
            // 
            // EmpAdresseTb
            // 
            this.EmpAdresseTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.EmpAdresseTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.EmpAdresseTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.EmpAdresseTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpAdresseTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EmpAdresseTb.ForeColor = System.Drawing.Color.OrangeRed;
            this.EmpAdresseTb.HintForeColor = System.Drawing.Color.Empty;
            this.EmpAdresseTb.HintText = "";
            this.EmpAdresseTb.isPassword = false;
            this.EmpAdresseTb.LineFocusedColor = System.Drawing.Color.Brown;
            this.EmpAdresseTb.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.EmpAdresseTb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.EmpAdresseTb.LineThickness = 3;
            this.EmpAdresseTb.Location = new System.Drawing.Point(16, 172);
            this.EmpAdresseTb.Margin = new System.Windows.Forms.Padding(4);
            this.EmpAdresseTb.MaxLength = 32767;
            this.EmpAdresseTb.Name = "EmpAdresseTb";
            this.EmpAdresseTb.Size = new System.Drawing.Size(126, 33);
            this.EmpAdresseTb.TabIndex = 10;
            this.EmpAdresseTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(12, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Employee Address";
            // 
            // EmpPositionCb
            // 
            this.EmpPositionCb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EmpPositionCb.FormattingEnabled = true;
            this.EmpPositionCb.Items.AddRange(new object[] {
            "Manager",
            "Senior Developper",
            "Junior Developper",
            "Accountant",
            "Receptionist"});
            this.EmpPositionCb.Location = new System.Drawing.Point(16, 271);
            this.EmpPositionCb.Name = "EmpPositionCb";
            this.EmpPositionCb.Size = new System.Drawing.Size(121, 25);
            this.EmpPositionCb.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(159, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Birthday date";
            // 
            // EmpDoB
            // 
            this.EmpDoB.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EmpDoB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EmpDoB.Location = new System.Drawing.Point(161, 273);
            this.EmpDoB.Name = "EmpDoB";
            this.EmpDoB.Size = new System.Drawing.Size(165, 23);
            this.EmpDoB.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(13, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Employee Phone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.OrangeRed;
            this.label8.Location = new System.Drawing.Point(159, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Employee Education";
            // 
            // EmpEduCb
            // 
            this.EmpEduCb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EmpEduCb.FormattingEnabled = true;
            this.EmpEduCb.Items.AddRange(new object[] {
            "BTech",
            "MTech",
            "BBA",
            "BCA",
            "MBA",
            "BCom",
            "MCom"});
            this.EmpEduCb.Location = new System.Drawing.Point(163, 351);
            this.EmpEduCb.Name = "EmpEduCb";
            this.EmpEduCb.Size = new System.Drawing.Size(150, 25);
            this.EmpEduCb.TabIndex = 19;
            // 
            // EmpGenderCb
            // 
            this.EmpGenderCb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EmpGenderCb.FormattingEnabled = true;
            this.EmpGenderCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.EmpGenderCb.Location = new System.Drawing.Point(163, 180);
            this.EmpGenderCb.Name = "EmpGenderCb";
            this.EmpGenderCb.Size = new System.Drawing.Size(126, 25);
            this.EmpGenderCb.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.OrangeRed;
            this.label9.Location = new System.Drawing.Point(160, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Employee Gender";
            // 
            // AddBtn
            // 
            this.AddBtn.ActiveBorderThickness = 1;
            this.AddBtn.ActiveCornerRadius = 20;
            this.AddBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.AddBtn.ActiveForecolor = System.Drawing.Color.White;
            this.AddBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.AddBtn.BackColor = System.Drawing.Color.White;
            this.AddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddBtn.BackgroundImage")));
            this.AddBtn.ButtonText = "Add";
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.AddBtn.IdleBorderThickness = 1;
            this.AddBtn.IdleCornerRadius = 20;
            this.AddBtn.IdleFillColor = System.Drawing.Color.OrangeRed;
            this.AddBtn.IdleForecolor = System.Drawing.Color.White;
            this.AddBtn.IdleLineColor = System.Drawing.Color.OrangeRed;
            this.AddBtn.Location = new System.Drawing.Point(6, 409);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(78, 45);
            this.AddBtn.TabIndex = 22;
            this.AddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.ActiveBorderThickness = 1;
            this.EditBtn.ActiveCornerRadius = 20;
            this.EditBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.EditBtn.ActiveForecolor = System.Drawing.Color.White;
            this.EditBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.EditBtn.BackColor = System.Drawing.Color.White;
            this.EditBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditBtn.BackgroundImage")));
            this.EditBtn.ButtonText = "Edit";
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.EditBtn.IdleBorderThickness = 1;
            this.EditBtn.IdleCornerRadius = 20;
            this.EditBtn.IdleFillColor = System.Drawing.Color.OrangeRed;
            this.EditBtn.IdleForecolor = System.Drawing.Color.White;
            this.EditBtn.IdleLineColor = System.Drawing.Color.OrangeRed;
            this.EditBtn.Location = new System.Drawing.Point(96, 409);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(78, 45);
            this.EditBtn.TabIndex = 23;
            this.EditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.ActiveBorderThickness = 1;
            this.DeleteBtn.ActiveCornerRadius = 20;
            this.DeleteBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.DeleteBtn.ActiveForecolor = System.Drawing.Color.White;
            this.DeleteBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.DeleteBtn.BackColor = System.Drawing.Color.White;
            this.DeleteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.BackgroundImage")));
            this.DeleteBtn.ButtonText = "Delete";
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.DeleteBtn.IdleBorderThickness = 1;
            this.DeleteBtn.IdleCornerRadius = 20;
            this.DeleteBtn.IdleFillColor = System.Drawing.Color.OrangeRed;
            this.DeleteBtn.IdleForecolor = System.Drawing.Color.White;
            this.DeleteBtn.IdleLineColor = System.Drawing.Color.OrangeRed;
            this.DeleteBtn.Location = new System.Drawing.Point(186, 409);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(66, 45);
            this.DeleteBtn.TabIndex = 24;
            this.DeleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.ActiveBorderThickness = 1;
            this.HomeBtn.ActiveCornerRadius = 20;
            this.HomeBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.HomeBtn.ActiveForecolor = System.Drawing.Color.White;
            this.HomeBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.HomeBtn.BackColor = System.Drawing.Color.White;
            this.HomeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomeBtn.BackgroundImage")));
            this.HomeBtn.ButtonText = "Home";
            this.HomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeBtn.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.HomeBtn.IdleBorderThickness = 1;
            this.HomeBtn.IdleCornerRadius = 20;
            this.HomeBtn.IdleFillColor = System.Drawing.Color.OrangeRed;
            this.HomeBtn.IdleForecolor = System.Drawing.Color.White;
            this.HomeBtn.IdleLineColor = System.Drawing.Color.OrangeRed;
            this.HomeBtn.Location = new System.Drawing.Point(264, 409);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(74, 45);
            this.HomeBtn.TabIndex = 25;
            this.HomeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // EmpDGView
            // 
            this.EmpDGView.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.EmpDGView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EmpDGView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmpDGView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmpDGView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmpDGView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmpDGView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmpDGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmpDGView.ColumnHeadersHeight = 40;
            this.EmpDGView.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(191)))));
            this.EmpDGView.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.EmpDGView.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.EmpDGView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(102)))));
            this.EmpDGView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.EmpDGView.CurrentTheme.BackColor = System.Drawing.Color.Orange;
            this.EmpDGView.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(173)))));
            this.EmpDGView.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.OrangeRed;
            this.EmpDGView.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.EmpDGView.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.EmpDGView.CurrentTheme.Name = null;
            this.EmpDGView.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.EmpDGView.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.EmpDGView.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.EmpDGView.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(102)))));
            this.EmpDGView.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmpDGView.DefaultCellStyle = dataGridViewCellStyle3;
            this.EmpDGView.EnableHeadersVisualStyles = false;
            this.EmpDGView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(173)))));
            this.EmpDGView.HeaderBackColor = System.Drawing.Color.OrangeRed;
            this.EmpDGView.HeaderBgColor = System.Drawing.Color.Empty;
            this.EmpDGView.HeaderForeColor = System.Drawing.Color.White;
            this.EmpDGView.Location = new System.Drawing.Point(368, 54);
            this.EmpDGView.Name = "EmpDGView";
            this.EmpDGView.RowHeadersVisible = false;
            this.EmpDGView.RowTemplate.Height = 40;
            this.EmpDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmpDGView.Size = new System.Drawing.Size(722, 409);
            this.EmpDGView.TabIndex = 26;
            this.EmpDGView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Orange;
            this.EmpDGView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpDGView_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(917, 581);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 19);
            this.label10.TabIndex = 6;
            this.label10.Text = "PMD Developper 2022";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(887, 575);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(29, 27);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1062, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 25);
            this.label11.TabIndex = 7;
            this.label11.Text = "X";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(1093, 603);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmpIdTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmpPhoneTb;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmpAdresseTb;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmpNameTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox EmpPositionCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker EmpDoB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox EmpEduCb;
        private System.Windows.Forms.ComboBox EmpGenderCb;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuThinButton2 AddBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 EditBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 HomeBtn;
        private Bunifu.UI.WinForms.BunifuDataGridView EmpDGView;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}