namespace ABCD_Member_Details_of_Bank
{
    partial class Activate_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.productid_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productkey_txt = new System.Windows.Forms.TextBox();
            this.ok_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productid_lbl
            // 
            this.productid_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productid_lbl.AutoSize = true;
            this.productid_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productid_lbl.ForeColor = System.Drawing.Color.Lime;
            this.productid_lbl.Location = new System.Drawing.Point(94, 14);
            this.productid_lbl.Name = "productid_lbl";
            this.productid_lbl.Size = new System.Drawing.Size(0, 15);
            this.productid_lbl.TabIndex = 1;
            this.productid_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Key";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productkey_txt
            // 
            this.productkey_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productkey_txt.BackColor = System.Drawing.Color.Black;
            this.productkey_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productkey_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productkey_txt.ForeColor = System.Drawing.Color.Lime;
            this.productkey_txt.Location = new System.Drawing.Point(94, 40);
            this.productkey_txt.Name = "productkey_txt";
            this.productkey_txt.Size = new System.Drawing.Size(272, 21);
            this.productkey_txt.TabIndex = 3;
            this.productkey_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ok_btn
            // 
            this.ok_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ok_btn.BackColor = System.Drawing.Color.Black;
            this.ok_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ok_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ok_btn.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.ok_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.ok_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.ok_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_btn.ForeColor = System.Drawing.Color.Lime;
            this.ok_btn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ok_btn.Location = new System.Drawing.Point(325, 67);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(41, 23);
            this.ok_btn.TabIndex = 32;
            this.ok_btn.Text = "Ok";
            this.ok_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ok_btn.UseVisualStyleBackColor = false;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // Activate_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(382, 103);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.productkey_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productid_lbl);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Activate_form";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activate";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Activate_form_FormClosing);
            this.Load += new System.EventHandler(this.Activate_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label productid_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productkey_txt;
        private System.Windows.Forms.Button ok_btn;
    }
}