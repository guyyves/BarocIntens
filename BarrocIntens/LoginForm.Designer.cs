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
            this.UserNtxb = new System.Windows.Forms.TextBox();
            this.WachtWtxb = new System.Windows.Forms.TextBox();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.Userlbl = new System.Windows.Forms.Label();
            this.Wachtwoordlbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserNtxb
            // 
            this.UserNtxb.Location = new System.Drawing.Point(133, 47);
            this.UserNtxb.Margin = new System.Windows.Forms.Padding(4);
            this.UserNtxb.Name = "UserNtxb";
            this.UserNtxb.Size = new System.Drawing.Size(272, 22);
            this.UserNtxb.TabIndex = 0;
            // 
            // WachtWtxb
            // 
            this.WachtWtxb.Location = new System.Drawing.Point(133, 134);
            this.WachtWtxb.Margin = new System.Windows.Forms.Padding(4);
            this.WachtWtxb.Name = "WachtWtxb";
            this.WachtWtxb.Size = new System.Drawing.Size(272, 22);
            this.WachtWtxb.TabIndex = 1;
            // 
            // Loginbtn
            // 
            this.Loginbtn.Location = new System.Drawing.Point(16, 225);
            this.Loginbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(273, 64);
            this.Loginbtn.TabIndex = 2;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = true;
            // 
            // Userlbl
            // 
            this.Userlbl.AutoSize = true;
            this.Userlbl.Location = new System.Drawing.Point(16, 50);
            this.Userlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Userlbl.Name = "Userlbl";
            this.Userlbl.Size = new System.Drawing.Size(70, 16);
            this.Userlbl.TabIndex = 3;
            this.Userlbl.Text = "Username";
            // 
            // Wachtwoordlbl
            // 
            this.Wachtwoordlbl.AutoSize = true;
            this.Wachtwoordlbl.Location = new System.Drawing.Point(16, 138);
            this.Wachtwoordlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Wachtwoordlbl.Name = "Wachtwoordlbl";
            this.Wachtwoordlbl.Size = new System.Drawing.Size(82, 16);
            this.Wachtwoordlbl.TabIndex = 4;
            this.Wachtwoordlbl.Text = "Wachtwoord";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 59);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Wachtwoordlbl);
            this.Controls.Add(this.Userlbl);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.WachtWtxb);
            this.Controls.Add(this.UserNtxb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserNtxb;
        private System.Windows.Forms.TextBox WachtWtxb;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Label Userlbl;
        private System.Windows.Forms.Label Wachtwoordlbl;
        private System.Windows.Forms.Button button1;
    }
}

