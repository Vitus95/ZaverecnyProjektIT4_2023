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
            this.components = new System.ComponentModel.Container();
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
            this.label8 = new System.Windows.Forms.Label();
            this.dataPrace = new System.Windows.Forms.DataGridView();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnPridatP = new System.Windows.Forms.Button();
            this.btnVymazatP = new System.Windows.Forms.Button();
            this.btnEditujP = new System.Windows.Forms.Button();
            this.dataUser = new System.Windows.Forms.DataGridView();
            this.txtIdContract = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnNajdiP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataZamestnanci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPrace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUser)).BeginInit();
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
            // dataPrace
            // 
            this.dataPrace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPrace.Location = new System.Drawing.Point(504, 396);
            this.dataPrace.Name = "dataPrace";
            this.dataPrace.Size = new System.Drawing.Size(651, 203);
            this.dataPrace.TabIndex = 35;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(398, 436);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtCustomer.TabIndex = 36;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(336, 439);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Zákazník";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(398, 462);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 39;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(399, 488);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 40;
            // 
            // txtEmployee
            // 
            this.txtEmployee.Location = new System.Drawing.Point(398, 514);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(100, 20);
            this.txtEmployee.TabIndex = 41;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(398, 540);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(100, 20);
            this.txtHours.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(351, 465);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Jméno";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(359, 491);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "Popis";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(320, 517);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Zaměstnanec";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(328, 543);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Počet hodin";
            // 
            // btnPridatP
            // 
            this.btnPridatP.Location = new System.Drawing.Point(354, 566);
            this.btnPridatP.Name = "btnPridatP";
            this.btnPridatP.Size = new System.Drawing.Size(52, 23);
            this.btnPridatP.TabIndex = 47;
            this.btnPridatP.Text = "Přidat";
            this.btnPridatP.UseVisualStyleBackColor = true;
            this.btnPridatP.Click += new System.EventHandler(this.btnPridatP_Click);
            // 
            // btnVymazatP
            // 
            this.btnVymazatP.Location = new System.Drawing.Point(412, 566);
            this.btnVymazatP.Name = "btnVymazatP";
            this.btnVymazatP.Size = new System.Drawing.Size(86, 23);
            this.btnVymazatP.TabIndex = 48;
            this.btnVymazatP.Text = "Vymazat";
            this.btnVymazatP.UseVisualStyleBackColor = true;
            this.btnVymazatP.Click += new System.EventHandler(this.btnVymazatP_Click);
            // 
            // btnEditujP
            // 
            this.btnEditujP.Location = new System.Drawing.Point(301, 566);
            this.btnEditujP.Name = "btnEditujP";
            this.btnEditujP.Size = new System.Drawing.Size(51, 23);
            this.btnEditujP.TabIndex = 49;
            this.btnEditujP.Text = "Edituj";
            this.btnEditujP.UseVisualStyleBackColor = true;
            this.btnEditujP.Click += new System.EventHandler(this.btnEditujP_Click);
            // 
            // dataUser
            // 
            this.dataUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUser.Location = new System.Drawing.Point(17, 396);
            this.dataUser.Name = "dataUser";
            this.dataUser.Size = new System.Drawing.Size(175, 203);
            this.dataUser.TabIndex = 50;
            // 
            // txtIdContract
            // 
            this.txtIdContract.Location = new System.Drawing.Point(398, 410);
            this.txtIdContract.Name = "txtIdContract";
            this.txtIdContract.Size = new System.Drawing.Size(100, 20);
            this.txtIdContract.TabIndex = 51;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(303, 413);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 13);
            this.label14.TabIndex = 52;
            this.label14.Text = "Číslo objednávky";
            // 
            // btnNajdiP
            // 
            this.btnNajdiP.Location = new System.Drawing.Point(224, 465);
            this.btnNajdiP.Name = "btnNajdiP";
            this.btnNajdiP.Size = new System.Drawing.Size(70, 70);
            this.btnNajdiP.TabIndex = 53;
            this.btnNajdiP.Text = "Najdi Kontrakt";
            this.btnNajdiP.UseVisualStyleBackColor = true;
            this.btnNajdiP.Click += new System.EventHandler(this.btnNajdiP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 611);
            this.Controls.Add(this.btnNajdiP);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtIdContract);
            this.Controls.Add(this.dataUser);
            this.Controls.Add(this.btnEditujP);
            this.Controls.Add(this.btnVymazatP);
            this.Controls.Add(this.btnPridatP);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.dataPrace);
            this.Controls.Add(this.label8);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataPrace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUser)).EndInit();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataPrace;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnPridatP;
        private System.Windows.Forms.Button btnVymazatP;
        private System.Windows.Forms.Button btnEditujP;
        private System.Windows.Forms.DataGridView dataUser;
        private System.Windows.Forms.TextBox txtIdContract;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnNajdiP;
    }
}

