namespace ZaverecnyProjektIT4_2023_Nemec
{
    partial class Uzivatel
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
            this.btnNajitK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdContract = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.dataKotrakty = new System.Windows.Forms.DataGridView();
            this.btnPridejK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataKotrakty)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kozuka Gothic Pr6N M", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uživatel";
            // 
            // btnNajitK
            // 
            this.btnNajitK.Location = new System.Drawing.Point(249, 116);
            this.btnNajitK.Name = "btnNajitK";
            this.btnNajitK.Size = new System.Drawing.Size(135, 30);
            this.btnNajitK.TabIndex = 1;
            this.btnNajitK.Text = "Najít číslo Kotraktu";
            this.btnNajitK.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(22, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Číslo kontraktu";
            // 
            // txtIdContract
            // 
            this.txtIdContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtIdContract.Location = new System.Drawing.Point(169, 116);
            this.txtIdContract.Name = "txtIdContract";
            this.txtIdContract.Size = new System.Drawing.Size(74, 30);
            this.txtIdContract.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(449, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Zadejte počet odpracovaných hodin";
            // 
            // txtHours
            // 
            this.txtHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txtHours.Location = new System.Drawing.Point(531, 99);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(79, 53);
            this.txtHours.TabIndex = 5;
            // 
            // dataKotrakty
            // 
            this.dataKotrakty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKotrakty.Location = new System.Drawing.Point(27, 174);
            this.dataKotrakty.Name = "dataKotrakty";
            this.dataKotrakty.Size = new System.Drawing.Size(791, 425);
            this.dataKotrakty.TabIndex = 6;
            // 
            // btnPridejK
            // 
            this.btnPridejK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnPridejK.Location = new System.Drawing.Point(616, 98);
            this.btnPridejK.Name = "btnPridejK";
            this.btnPridejK.Size = new System.Drawing.Size(93, 54);
            this.btnPridejK.TabIndex = 7;
            this.btnPridejK.Text = "Odeslat";
            this.btnPridejK.UseVisualStyleBackColor = true;
            // 
            // Uzivatel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 611);
            this.Controls.Add(this.btnPridejK);
            this.Controls.Add(this.dataKotrakty);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdContract);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNajitK);
            this.Controls.Add(this.label1);
            this.Name = "Uzivatel";
            this.Text = "Uzivatel";
            this.Load += new System.EventHandler(this.Uzivatel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataKotrakty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNajitK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdContract;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.DataGridView dataKotrakty;
        private System.Windows.Forms.Button btnPridejK;
    }
}