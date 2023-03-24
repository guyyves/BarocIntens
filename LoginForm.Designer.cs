namespace BarrocIntens
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.UserNtxb = new System.Windows.Forms.TextBox();
            this.WachtWtxb = new System.Windows.Forms.TextBox();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.Userlbl = new System.Windows.Forms.Label();
            this.Wachtwoordlbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNtxb
            // 
            this.UserNtxb.Location = new System.Drawing.Point(86, 124);
            this.UserNtxb.Name = "UserNtxb";
            this.UserNtxb.Size = new System.Drawing.Size(131, 20);
            this.UserNtxb.TabIndex = 0;
            // 
            // WachtWtxb
            // 
            this.WachtWtxb.Location = new System.Drawing.Point(86, 154);
            this.WachtWtxb.Name = "WachtWtxb";
            this.WachtWtxb.Size = new System.Drawing.Size(131, 20);
            this.WachtWtxb.TabIndex = 1;
            // 
            // Loginbtn
            // 
            this.Loginbtn.Location = new System.Drawing.Point(12, 183);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(205, 52);
            this.Loginbtn.TabIndex = 2;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = true;
            // 
            // Userlbl
            // 
            this.Userlbl.AutoSize = true;
            this.Userlbl.Location = new System.Drawing.Point(12, 127);
            this.Userlbl.Name = "Userlbl";
            this.Userlbl.Size = new System.Drawing.Size(55, 13);
            this.Userlbl.TabIndex = 3;
            this.Userlbl.Text = "Username";
            // 
            // Wachtwoordlbl
            // 
            this.Wachtwoordlbl.AutoSize = true;
            this.Wachtwoordlbl.Location = new System.Drawing.Point(12, 157);
            this.Wachtwoordlbl.Name = "Wachtwoordlbl";
            this.Wachtwoordlbl.Size = new System.Drawing.Size(68, 13);
            this.Wachtwoordlbl.TabIndex = 4;
            this.Wachtwoordlbl.Text = "Wachtwoord";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 88);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 287);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Wachtwoordlbl);
            this.Controls.Add(this.Userlbl);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.WachtWtxb);
            this.Controls.Add(this.UserNtxb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserNtxb;
        private System.Windows.Forms.TextBox WachtWtxb;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Label Userlbl;
        private System.Windows.Forms.Label Wachtwoordlbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

