namespace ZaverecnyProjektIT4_2023_Nemec
{
    partial class Signup
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrihlasit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOdejit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtUsername.Location = new System.Drawing.Point(201, 166);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 38);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtPassword.Location = new System.Drawing.Point(201, 229);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 38);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(25, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Uživatelské jméno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(133, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Heslo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 58);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vítejte";
            // 
            // btnPrihlasit
            // 
            this.btnPrihlasit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPrihlasit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrihlasit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.btnPrihlasit.FlatAppearance.BorderSize = 3;
            this.btnPrihlasit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrihlasit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrihlasit.Location = new System.Drawing.Point(276, 292);
            this.btnPrihlasit.Name = "btnPrihlasit";
            this.btnPrihlasit.Size = new System.Drawing.Size(124, 37);
            this.btnPrihlasit.TabIndex = 5;
            this.btnPrihlasit.Text = "Přihlásit";
            this.btnPrihlasit.UseVisualStyleBackColor = false;
            this.btnPrihlasit.Click += new System.EventHandler(this.btnPrihlasit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(201, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Vyčistit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOdejit
            // 
            this.btnOdejit.BackColor = System.Drawing.Color.IndianRed;
            this.btnOdejit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdejit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnOdejit.Location = new System.Drawing.Point(12, 309);
            this.btnOdejit.Name = "btnOdejit";
            this.btnOdejit.Size = new System.Drawing.Size(40, 40);
            this.btnOdejit.TabIndex = 7;
            this.btnOdejit.Text = "X";
            this.btnOdejit.UseVisualStyleBackColor = false;
            this.btnOdejit.Click += new System.EventHandler(this.btnOdejit_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.btnOdejit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPrihlasit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "Signup";
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrihlasit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOdejit;
    }
}