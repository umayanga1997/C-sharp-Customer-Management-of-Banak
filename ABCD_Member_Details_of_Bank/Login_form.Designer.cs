namespace ABCD_Member_Details_of_Bank
{
    partial class Login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.password_txt);
            this.panel1.Controls.Add(this.username_txt);
            this.panel1.Location = new System.Drawing.Point(415, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 134);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ABCD_Member_Details_of_Bank.Properties.Resources.login;
            this.pictureBox3.Location = new System.Drawing.Point(28, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(140, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ABCD_Member_Details_of_Bank.Properties.Resources.Status_dialog_password_icon;
            this.pictureBox2.Location = new System.Drawing.Point(11, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ABCD_Member_Details_of_Bank.Properties.Resources.Places_user_identity_icon;
            this.pictureBox1.Location = new System.Drawing.Point(11, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // password_txt
            // 
            this.password_txt.BackColor = System.Drawing.Color.Black;
            this.password_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_txt.ForeColor = System.Drawing.Color.Gray;
            this.password_txt.Location = new System.Drawing.Point(46, 103);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(135, 16);
            this.password_txt.TabIndex = 3;
            this.password_txt.Text = "Enter Password";
            this.password_txt.Enter += new System.EventHandler(this.password_txt_Enter);
            this.password_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_txt_KeyDown);
            // 
            // username_txt
            // 
            this.username_txt.BackColor = System.Drawing.Color.Black;
            this.username_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_txt.ForeColor = System.Drawing.Color.Gray;
            this.username_txt.Location = new System.Drawing.Point(46, 74);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(135, 16);
            this.username_txt.TabIndex = 2;
            this.username_txt.Text = "Enter Username";
            this.username_txt.Enter += new System.EventHandler(this.username_txt_Enter);
            this.username_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.username_txt_KeyDown);
            // 
            // Login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Login_form";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_form_FormClosing);
            this.Load += new System.EventHandler(this.Login_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

