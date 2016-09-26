namespace hello_user
{
    partial class frmHelloUser
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnHelloUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(106, 127);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 13);
            this.lblWelcome.TabIndex = 0;
            // 
            // btnHelloUser
            // 
            this.btnHelloUser.Location = new System.Drawing.Point(95, 84);
            this.btnHelloUser.Name = "btnHelloUser";
            this.btnHelloUser.Size = new System.Drawing.Size(75, 23);
            this.btnHelloUser.TabIndex = 2;
            this.btnHelloUser.Text = "Hello User";
            this.btnHelloUser.UseVisualStyleBackColor = true;
            this.btnHelloUser.Click += new System.EventHandler(this.btnHelloUser_Click);
            // 
            // frmHelloUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnHelloUser);
            this.Controls.Add(this.lblWelcome);
            this.Name = "frmHelloUser";
            this.Text = "HelloUser";
            this.Load += new System.EventHandler(this.frmHelloUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnHelloUser;
    }
}

