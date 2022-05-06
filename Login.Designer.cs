namespace EmployesManagement
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UidTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(207, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gest Emp Soft";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // UidTb
            // 
            this.UidTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UidTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UidTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UidTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UidTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UidTb.ForeColor = System.Drawing.Color.OrangeRed;
            this.UidTb.HintForeColor = System.Drawing.Color.Empty;
            this.UidTb.HintText = "";
            this.UidTb.isPassword = false;
            this.UidTb.LineFocusedColor = System.Drawing.Color.Brown;
            this.UidTb.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.UidTb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.UidTb.LineThickness = 3;
            this.UidTb.Location = new System.Drawing.Point(212, 95);
            this.UidTb.Margin = new System.Windows.Forms.Padding(4);
            this.UidTb.MaxLength = 32767;
            this.UidTb.Name = "UidTb";
            this.UidTb.Size = new System.Drawing.Size(220, 33);
            this.UidTb.TabIndex = 3;
            this.UidTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(126, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "User Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(89, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "User Name";
            // 
            // UNameTb
            // 
            this.UNameTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UNameTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UNameTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UNameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UNameTb.ForeColor = System.Drawing.Color.OrangeRed;
            this.UNameTb.HintForeColor = System.Drawing.Color.Empty;
            this.UNameTb.HintText = "";
            this.UNameTb.isPassword = false;
            this.UNameTb.LineFocusedColor = System.Drawing.Color.Brown;
            this.UNameTb.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.UNameTb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.UNameTb.LineThickness = 3;
            this.UNameTb.Location = new System.Drawing.Point(212, 154);
            this.UNameTb.Margin = new System.Windows.Forms.Padding(4);
            this.UNameTb.MaxLength = 32767;
            this.UNameTb.Name = "UNameTb";
            this.UNameTb.Size = new System.Drawing.Size(220, 33);
            this.UNameTb.TabIndex = 5;
            this.UNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.Color.OrangeRed;
            this.Loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginbtn.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.ForeColor = System.Drawing.Color.White;
            this.Loginbtn.Location = new System.Drawing.Point(153, 215);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(128, 43);
            this.Loginbtn.TabIndex = 7;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.BackColor = System.Drawing.Color.OrangeRed;
            this.Clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clearbtn.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbtn.ForeColor = System.Drawing.Color.White;
            this.Clearbtn.Location = new System.Drawing.Point(313, 215);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(128, 43);
            this.Clearbtn.TabIndex = 8;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = false;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(444, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(472, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UNameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UidTb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UidTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UNameTb;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Label label4;
    }
}