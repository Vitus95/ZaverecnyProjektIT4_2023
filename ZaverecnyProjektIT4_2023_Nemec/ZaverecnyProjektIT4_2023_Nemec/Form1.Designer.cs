namespace ZaverecnyProjektIT4_2023_Nemec
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNajdiZ = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtJmeno = new System.Windows.Forms.TextBox();
            this.txtPrijmeni = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.dataZamestnanci = new System.Windows.Forms.DataGridView();
            this.btnVymazZ = new System.Windows.Forms.Button();
            this.btnEditujZ = new System.Windows.Forms.Button();
            this.btnPridatZ = new System.Windows.Forms.Button();
            this.txtNarozeni = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.listUser = new System.Windows.Forms.ListView();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataZamestnanci)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtID.Location = new System.Drawing.Point(198, 90);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(150, 30);
            this.txtID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Číslo Zaměstnance";
            // 
            // btnNajdiZ
            // 
            this.btnNajdiZ.Location = new System.Drawing.Point(354, 90);
            this.btnNajdiZ.Name = "btnNajdiZ";
            this.btnNajdiZ.Size = new System.Drawing.Size(144, 30);
            this.btnNajdiZ.TabIndex = 16;
            this.btnNajdiZ.Text = "Najít";
            this.btnNajdiZ.UseVisualStyleBackColor = true;
            this.btnNajdiZ.Click += new System.EventHandler(this.btnNajdiZ_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(120, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Jméno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(111, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Příjmení";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(43, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Datum narození";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(132, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(114, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Telefon";
            // 
            // txtJmeno
            // 
            this.txtJmeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtJmeno.Location = new System.Drawing.Point(198, 126);
            this.txtJmeno.Name = "txtJmeno";
            this.txtJmeno.Size = new System.Drawing.Size(300, 30);
            this.txtJmeno.TabIndex = 22;
            // 
            // txtPrijmeni
            // 
            this.txtPrijmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPrijmeni.Location = new System.Drawing.Point(198, 162);
            this.txtPrijmeni.Name = "txtPrijmeni";
            this.txtPrijmeni.Size = new System.Drawing.Size(300, 30);
            this.txtPrijmeni.TabIndex = 23;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtEmail.Location = new System.Drawing.Point(198, 234);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 30);
            this.txtEmail.TabIndex = 25;
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtTel.Location = new System.Drawing.Point(198, 270);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(300, 30);
            this.txtTel.TabIndex = 26;
            // 
            // dataZamestnanci
            // 
            this.dataZamestnanci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataZamestnanci.Location = new System.Drawing.Point(505, 90);
            this.dataZamestnanci.Name = "dataZamestnanci";
            this.dataZamestnanci.Size = new System.Drawing.Size(651, 300);
            this.dataZamestnanci.TabIndex = 27;
            // 
            // btnVymazZ
            // 
            this.btnVymazZ.BackColor = System.Drawing.Color.LightCoral;
            this.btnVymazZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnVymazZ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVymazZ.Location = new System.Drawing.Point(403, 306);
            this.btnVymazZ.Name = "btnVymazZ";
            this.btnVymazZ.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnVymazZ.Size = new System.Drawing.Size(96, 84);
            this.btnVymazZ.TabIndex = 28;
            this.btnVymazZ.Text = "Vymazat";
            this.btnVymazZ.UseVisualStyleBackColor = false;
            this.btnVymazZ.Click += new System.EventHandler(this.btnVymazZ_Click);
            // 
            // btnEditujZ
            // 
            this.btnEditujZ.BackColor = System.Drawing.Color.LightGreen;
            this.btnEditujZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditujZ.Location = new System.Drawing.Point(301, 306);
            this.btnEditujZ.Name = "btnEditujZ";
            this.btnEditujZ.Size = new System.Drawing.Size(96, 84);
            this.btnEditujZ.TabIndex = 29;
            this.btnEditujZ.Text = "Edituj";
            this.btnEditujZ.UseVisualStyleBackColor = false;
            this.btnEditujZ.Click += new System.EventHandler(this.btnEditujZ_Click);
            // 
            // btnPridatZ
            // 
            this.btnPridatZ.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPridatZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPridatZ.Location = new System.Drawing.Point(198, 306);
            this.btnPridatZ.Name = "btnPridatZ";
            this.btnPridatZ.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPridatZ.Size = new System.Drawing.Size(96, 84);
            this.btnPridatZ.TabIndex = 30;
            this.btnPridatZ.Text = "Přidat";
            this.btnPridatZ.UseVisualStyleBackColor = false;
            this.btnPridatZ.Click += new System.EventHandler(this.btnPridatZ_Click);
            // 
            // txtNarozeni
            // 
            this.txtNarozeni.Location = new System.Drawing.Point(197, 204);
            this.txtNarozeni.Name = "txtNarozeni";
            this.txtNarozeni.Size = new System.Drawing.Size(301, 20);
            this.txtNarozeni.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Wide Latin", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(316, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(615, 65);
            this.label7.TabIndex = 32;
            this.label7.Text = "Admin Panel";
            // 
            // listUser
            // 
            this.listUser.HideSelection = false;
            this.listUser.Location = new System.Drawing.Point(17, 396);
            this.listUser.Name = "listUser";
            this.listUser.Size = new System.Drawing.Size(175, 203);
            this.listUser.TabIndex = 33;
            this.listUser.UseCompatibleStateImageBehavior = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label8.Location = new System.Drawing.Point(21, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 31);
            this.label8.TabIndex = 34;
            this.label8.Text = "Uživatelé";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 611);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listUser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNarozeni);
            this.Controls.Add(this.btnPridatZ);
            this.Controls.Add(this.btnEditujZ);
            this.Controls.Add(this.btnVymazZ);
            this.Controls.Add(this.dataZamestnanci);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPrijmeni);
            this.Controls.Add(this.txtJmeno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNajdiZ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataZamestnanci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNajdiZ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtJmeno;
        private System.Windows.Forms.TextBox txtPrijmeni;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.DataGridView dataZamestnanci;
        private System.Windows.Forms.Button btnVymazZ;
        private System.Windows.Forms.Button btnEditujZ;
        private System.Windows.Forms.Button btnPridatZ;
        private System.Windows.Forms.DateTimePicker txtNarozeni;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listUser;
        private System.Windows.Forms.Label label8;
    }
}

