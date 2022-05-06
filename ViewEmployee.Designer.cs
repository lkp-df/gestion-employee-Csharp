namespace EmployesManagement
{
    partial class ViewEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEmployee));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HomeBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EmpGenderLbl = new System.Windows.Forms.Label();
            this.EmpEduLbl = new System.Windows.Forms.Label();
            this.EmpDOBLbl = new System.Windows.Forms.Label();
            this.EmpNameLbl = new System.Windows.Forms.Label();
            this.EmpIDLbl = new System.Windows.Forms.Label();
            this.EmpPhoneLbl = new System.Windows.Forms.Label();
            this.EmpPosLbl = new System.Windows.Forms.Label();
            this.EmpAdresseLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.refreshBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PrintBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.pictureBox1.Location = new System.Drawing.Point(40, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1062, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 25);
            this.label11.TabIndex = 29;
            this.label11.Text = "X";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(99, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Employee Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.HomeBtn);
            this.panel1.Controls.Add(this.EmpGenderLbl);
            this.panel1.Controls.Add(this.EmpEduLbl);
            this.panel1.Controls.Add(this.EmpDOBLbl);
            this.panel1.Controls.Add(this.EmpNameLbl);
            this.panel1.Controls.Add(this.EmpIDLbl);
            this.panel1.Controls.Add(this.EmpPhoneLbl);
            this.panel1.Controls.Add(this.EmpPosLbl);
            this.panel1.Controls.Add(this.EmpAdresseLbl);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Controls.Add(this.PrintBtn);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.EmpIdTb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-5, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 492);
            this.panel1.TabIndex = 31;
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
            this.HomeBtn.Location = new System.Drawing.Point(581, 426);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(78, 45);
            this.HomeBtn.TabIndex = 36;
            this.HomeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // EmpGenderLbl
            // 
            this.EmpGenderLbl.AutoSize = true;
            this.EmpGenderLbl.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpGenderLbl.ForeColor = System.Drawing.Color.Navy;
            this.EmpGenderLbl.Location = new System.Drawing.Point(807, 206);
            this.EmpGenderLbl.Name = "EmpGenderLbl";
            this.EmpGenderLbl.Size = new System.Drawing.Size(138, 19);
            this.EmpGenderLbl.TabIndex = 35;
            this.EmpGenderLbl.Text = "Employee Gender";
            this.EmpGenderLbl.Visible = false;
            // 
            // EmpEduLbl
            // 
            this.EmpEduLbl.AutoSize = true;
            this.EmpEduLbl.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpEduLbl.ForeColor = System.Drawing.Color.Navy;
            this.EmpEduLbl.Location = new System.Drawing.Point(806, 376);
            this.EmpEduLbl.Name = "EmpEduLbl";
            this.EmpEduLbl.Size = new System.Drawing.Size(154, 19);
            this.EmpEduLbl.TabIndex = 34;
            this.EmpEduLbl.Text = "Employee Education";
            this.EmpEduLbl.Visible = false;
            // 
            // EmpDOBLbl
            // 
            this.EmpDOBLbl.AutoSize = true;
            this.EmpDOBLbl.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpDOBLbl.ForeColor = System.Drawing.Color.Navy;
            this.EmpDOBLbl.Location = new System.Drawing.Point(806, 293);
            this.EmpDOBLbl.Name = "EmpDOBLbl";
            this.EmpDOBLbl.Size = new System.Drawing.Size(106, 19);
            this.EmpDOBLbl.TabIndex = 33;
            this.EmpDOBLbl.Text = "Birthday date";
            this.EmpDOBLbl.Visible = false;
            // 
            // EmpNameLbl
            // 
            this.EmpNameLbl.AutoSize = true;
            this.EmpNameLbl.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpNameLbl.ForeColor = System.Drawing.Color.Navy;
            this.EmpNameLbl.Location = new System.Drawing.Point(806, 129);
            this.EmpNameLbl.Name = "EmpNameLbl";
            this.EmpNameLbl.Size = new System.Drawing.Size(125, 19);
            this.EmpNameLbl.TabIndex = 32;
            this.EmpNameLbl.Text = "Employee Name";
            this.EmpNameLbl.Visible = false;
            // 
            // EmpIDLbl
            // 
            this.EmpIDLbl.AutoSize = true;
            this.EmpIDLbl.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpIDLbl.ForeColor = System.Drawing.Color.Navy;
            this.EmpIDLbl.Location = new System.Drawing.Point(343, 129);
            this.EmpIDLbl.Name = "EmpIDLbl";
            this.EmpIDLbl.Size = new System.Drawing.Size(97, 19);
            this.EmpIDLbl.TabIndex = 31;
            this.EmpIDLbl.Text = "Employee Id";
            this.EmpIDLbl.Visible = false;
            // 
            // EmpPhoneLbl
            // 
            this.EmpPhoneLbl.AutoSize = true;
            this.EmpPhoneLbl.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpPhoneLbl.ForeColor = System.Drawing.Color.Navy;
            this.EmpPhoneLbl.Location = new System.Drawing.Point(339, 380);
            this.EmpPhoneLbl.Name = "EmpPhoneLbl";
            this.EmpPhoneLbl.Size = new System.Drawing.Size(129, 19);
            this.EmpPhoneLbl.TabIndex = 30;
            this.EmpPhoneLbl.Text = "Employee Phone";
            this.EmpPhoneLbl.Visible = false;
            // 
            // EmpPosLbl
            // 
            this.EmpPosLbl.AutoSize = true;
            this.EmpPosLbl.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpPosLbl.ForeColor = System.Drawing.Color.Navy;
            this.EmpPosLbl.Location = new System.Drawing.Point(338, 297);
            this.EmpPosLbl.Name = "EmpPosLbl";
            this.EmpPosLbl.Size = new System.Drawing.Size(141, 19);
            this.EmpPosLbl.TabIndex = 29;
            this.EmpPosLbl.Text = "Employee Position";
            this.EmpPosLbl.Visible = false;
            // 
            // EmpAdresseLbl
            // 
            this.EmpAdresseLbl.AutoSize = true;
            this.EmpAdresseLbl.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpAdresseLbl.ForeColor = System.Drawing.Color.Navy;
            this.EmpAdresseLbl.Location = new System.Drawing.Point(338, 211);
            this.EmpAdresseLbl.Name = "EmpAdresseLbl";
            this.EmpAdresseLbl.Size = new System.Drawing.Size(142, 19);
            this.EmpAdresseLbl.TabIndex = 28;
            this.EmpAdresseLbl.Text = "Employee Address";
            this.EmpAdresseLbl.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.OrangeRed;
            this.label10.Location = new System.Drawing.Point(139, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 19);
            this.label10.TabIndex = 27;
            this.label10.Text = "Employee Id";
            // 
            // refreshBtn
            // 
            this.refreshBtn.ActiveBorderThickness = 1;
            this.refreshBtn.ActiveCornerRadius = 20;
            this.refreshBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.refreshBtn.ActiveForecolor = System.Drawing.Color.White;
            this.refreshBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.refreshBtn.BackColor = System.Drawing.Color.White;
            this.refreshBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshBtn.BackgroundImage")));
            this.refreshBtn.ButtonText = "Refresh";
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.refreshBtn.IdleBorderThickness = 1;
            this.refreshBtn.IdleCornerRadius = 20;
            this.refreshBtn.IdleFillColor = System.Drawing.Color.OrangeRed;
            this.refreshBtn.IdleForecolor = System.Drawing.Color.White;
            this.refreshBtn.IdleLineColor = System.Drawing.Color.OrangeRed;
            this.refreshBtn.Location = new System.Drawing.Point(539, 19);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(86, 45);
            this.refreshBtn.TabIndex = 26;
            this.refreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
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
            this.PrintBtn.Location = new System.Drawing.Point(436, 426);
            this.PrintBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(78, 45);
            this.PrintBtn.TabIndex = 22;
            this.PrintBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.OrangeRed;
            this.label9.Location = new System.Drawing.Point(600, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Employee Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.OrangeRed;
            this.label8.Location = new System.Drawing.Point(599, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Employee Education";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(135, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Employee Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(599, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Birthday date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(134, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Employee Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(134, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Employee Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(599, 134);
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
            this.EmpIdTb.Location = new System.Drawing.Point(436, 32);
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
            this.label2.Location = new System.Drawing.Point(332, 40);
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
            // ViewEmployee
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
            this.Name = "ViewEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewEmployee";
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
        private Bunifu.Framework.UI.BunifuThinButton2 PrintBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmpIdTb;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 refreshBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label EmpGenderLbl;
        private System.Windows.Forms.Label EmpEduLbl;
        private System.Windows.Forms.Label EmpDOBLbl;
        private System.Windows.Forms.Label EmpNameLbl;
        private System.Windows.Forms.Label EmpIDLbl;
        private System.Windows.Forms.Label EmpPhoneLbl;
        private System.Windows.Forms.Label EmpPosLbl;
        private System.Windows.Forms.Label EmpAdresseLbl;
        private Bunifu.Framework.UI.BunifuThinButton2 HomeBtn;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}