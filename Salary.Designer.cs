namespace EmployesManagement
{
    partial class Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PrintBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SalarySlip = new System.Windows.Forms.RichTextBox();
            this.FetchBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ViewBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.AddBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label9 = new System.Windows.Forms.Label();
            this.EmpWorkDayTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.EmpPosTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.EmpNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmpIdTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1059, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 25);
            this.label11.TabIndex = 32;
            this.label11.Text = "X";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(96, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Employee Payements";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.PrintBtn);
            this.panel1.Controls.Add(this.SalarySlip);
            this.panel1.Controls.Add(this.FetchBtn);
            this.panel1.Controls.Add(this.ViewBtn);
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.EmpWorkDayTb);
            this.panel1.Controls.Add(this.EmpPosTb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.EmpNameTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.EmpIdTb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1093, 492);
            this.panel1.TabIndex = 34;
            // 
            // PrintBtn
            // 
            this.PrintBtn.ActiveBorderThickness = 1;
            this.PrintBtn.ActiveCornerRadius = 20;
            this.PrintBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.PrintBtn.ActiveForecolor = System.Drawing.Color.White;
            this.PrintBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.PrintBtn.BackColor = System.Drawing.Color.White;
            this.PrintBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PrintBtn.BackgroundImage")));
            this.PrintBtn.ButtonText = "Print";
            this.PrintBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintBtn.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.PrintBtn.IdleBorderThickness = 1;
            this.PrintBtn.IdleCornerRadius = 20;
            this.PrintBtn.IdleFillColor = System.Drawing.Color.OrangeRed;
            this.PrintBtn.IdleForecolor = System.Drawing.Color.White;
            this.PrintBtn.IdleLineColor = System.Drawing.Color.OrangeRed;
            this.PrintBtn.Location = new System.Drawing.Point(939, 426);
            this.PrintBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(83, 45);
            this.PrintBtn.TabIndex = 27;
            this.PrintBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // SalarySlip
            // 
            this.SalarySlip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalarySlip.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalarySlip.ForeColor = System.Drawing.Color.Navy;
            this.SalarySlip.Location = new System.Drawing.Point(504, 40);
            this.SalarySlip.Name = "SalarySlip";
            this.SalarySlip.Size = new System.Drawing.Size(518, 345);
            this.SalarySlip.TabIndex = 26;
            this.SalarySlip.Text = "";
            // 
            // FetchBtn
            // 
            this.FetchBtn.ActiveBorderThickness = 1;
            this.FetchBtn.ActiveCornerRadius = 20;
            this.FetchBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.FetchBtn.ActiveForecolor = System.Drawing.Color.White;
            this.FetchBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.FetchBtn.BackColor = System.Drawing.Color.White;
            this.FetchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FetchBtn.BackgroundImage")));
            this.FetchBtn.ButtonText = "Fetch Data";
            this.FetchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FetchBtn.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FetchBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.FetchBtn.IdleBorderThickness = 1;
            this.FetchBtn.IdleCornerRadius = 20;
            this.FetchBtn.IdleFillColor = System.Drawing.Color.OrangeRed;
            this.FetchBtn.IdleForecolor = System.Drawing.Color.White;
            this.FetchBtn.IdleLineColor = System.Drawing.Color.OrangeRed;
            this.FetchBtn.Location = new System.Drawing.Point(239, 40);
            this.FetchBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.FetchBtn.Name = "FetchBtn";
            this.FetchBtn.Size = new System.Drawing.Size(142, 45);
            this.FetchBtn.TabIndex = 24;
            this.FetchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FetchBtn.Click += new System.EventHandler(this.FetchBtn_Click);
            // 
            // ViewBtn
            // 
            this.ViewBtn.ActiveBorderThickness = 1;
            this.ViewBtn.ActiveCornerRadius = 20;
            this.ViewBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.ViewBtn.ActiveForecolor = System.Drawing.Color.White;
            this.ViewBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.ViewBtn.BackColor = System.Drawing.Color.White;
            this.ViewBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ViewBtn.BackgroundImage")));
            this.ViewBtn.ButtonText = "View";
            this.ViewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewBtn.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.ViewBtn.IdleBorderThickness = 1;
            this.ViewBtn.IdleCornerRadius = 20;
            this.ViewBtn.IdleFillColor = System.Drawing.Color.OrangeRed;
            this.ViewBtn.IdleForecolor = System.Drawing.Color.White;
            this.ViewBtn.IdleLineColor = System.Drawing.Color.OrangeRed;
            this.ViewBtn.Location = new System.Drawing.Point(193, 426);
            this.ViewBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(78, 45);
            this.ViewBtn.TabIndex = 23;
            this.ViewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
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
            this.AddBtn.ButtonText = "Home";
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.AddBtn.IdleBorderThickness = 1;
            this.AddBtn.IdleCornerRadius = 20;
            this.AddBtn.IdleFillColor = System.Drawing.Color.OrangeRed;
            this.AddBtn.IdleForecolor = System.Drawing.Color.White;
            this.AddBtn.IdleLineColor = System.Drawing.Color.OrangeRed;
            this.AddBtn.Location = new System.Drawing.Point(67, 426);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(78, 45);
            this.AddBtn.TabIndex = 22;
            this.AddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.OrangeRed;
            this.label9.Location = new System.Drawing.Point(73, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Worked days";
            // 
            // EmpWorkDayTb
            // 
            this.EmpWorkDayTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.EmpWorkDayTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.EmpWorkDayTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.EmpWorkDayTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpWorkDayTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EmpWorkDayTb.ForeColor = System.Drawing.Color.OrangeRed;
            this.EmpWorkDayTb.HintForeColor = System.Drawing.Color.Empty;
            this.EmpWorkDayTb.HintText = "";
            this.EmpWorkDayTb.isPassword = false;
            this.EmpWorkDayTb.LineFocusedColor = System.Drawing.Color.Brown;
            this.EmpWorkDayTb.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.EmpWorkDayTb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.EmpWorkDayTb.LineThickness = 3;
            this.EmpWorkDayTb.Location = new System.Drawing.Point(77, 257);
            this.EmpWorkDayTb.Margin = new System.Windows.Forms.Padding(4);
            this.EmpWorkDayTb.MaxLength = 32767;
            this.EmpWorkDayTb.Name = "EmpWorkDayTb";
            this.EmpWorkDayTb.Size = new System.Drawing.Size(138, 33);
            this.EmpWorkDayTb.TabIndex = 12;
            this.EmpWorkDayTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // EmpPosTb
            // 
            this.EmpPosTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.EmpPosTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.EmpPosTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.EmpPosTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpPosTb.Enabled = false;
            this.EmpPosTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EmpPosTb.ForeColor = System.Drawing.Color.OrangeRed;
            this.EmpPosTb.HintForeColor = System.Drawing.Color.Empty;
            this.EmpPosTb.HintText = "";
            this.EmpPosTb.isPassword = false;
            this.EmpPosTb.LineFocusedColor = System.Drawing.Color.Brown;
            this.EmpPosTb.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.EmpPosTb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.EmpPosTb.LineThickness = 3;
            this.EmpPosTb.Location = new System.Drawing.Point(77, 352);
            this.EmpPosTb.Margin = new System.Windows.Forms.Padding(4);
            this.EmpPosTb.MaxLength = 32767;
            this.EmpPosTb.Name = "EmpPosTb";
            this.EmpPosTb.Size = new System.Drawing.Size(137, 33);
            this.EmpPosTb.TabIndex = 10;
            this.EmpPosTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(73, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Employee Position";
            // 
            // EmpNameTb
            // 
            this.EmpNameTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.EmpNameTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.EmpNameTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.EmpNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpNameTb.Enabled = false;
            this.EmpNameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EmpNameTb.ForeColor = System.Drawing.Color.OrangeRed;
            this.EmpNameTb.HintForeColor = System.Drawing.Color.Empty;
            this.EmpNameTb.HintText = "";
            this.EmpNameTb.isPassword = false;
            this.EmpNameTb.LineFocusedColor = System.Drawing.Color.Brown;
            this.EmpNameTb.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.EmpNameTb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.EmpNameTb.LineThickness = 3;
            this.EmpNameTb.Location = new System.Drawing.Point(71, 167);
            this.EmpNameTb.Margin = new System.Windows.Forms.Padding(4);
            this.EmpNameTb.MaxLength = 32767;
            this.EmpNameTb.Name = "EmpNameTb";
            this.EmpNameTb.Size = new System.Drawing.Size(144, 41);
            this.EmpNameTb.TabIndex = 8;
            this.EmpNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(73, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Employee Name";
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
            this.EmpIdTb.Location = new System.Drawing.Point(77, 80);
            this.EmpIdTb.Margin = new System.Windows.Forms.Padding(4);
            this.EmpIdTb.MaxLength = 32767;
            this.EmpIdTb.Name = "EmpIdTb";
            this.EmpIdTb.Size = new System.Drawing.Size(93, 27);
            this.EmpIdTb.TabIndex = 6;
            this.EmpIdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(73, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Employee Id";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(1093, 603);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary";
            this.Load += new System.EventHandler(this.Salary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 FetchBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 ViewBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 AddBtn;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmpWorkDayTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmpPosTb;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmpNameTb;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmpIdTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox SalarySlip;
        private Bunifu.Framework.UI.BunifuThinButton2 PrintBtn;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}