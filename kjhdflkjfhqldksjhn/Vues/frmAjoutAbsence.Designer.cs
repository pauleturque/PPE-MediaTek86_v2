
namespace kjhdflkjfhqldksjhn
{
    partial class frmAjoutAbsence
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
            this.btnValiderAbsence = new System.Windows.Forms.Button();
            this.btnAnnulerAbsence = new System.Windows.Forms.Button();
            this.dateDebut = new System.Windows.Forms.DateTimePicker();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.cbMotif = new System.Windows.Forms.ComboBox();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnValiderAbsence
            // 
            this.btnValiderAbsence.Location = new System.Drawing.Point(732, 138);
            this.btnValiderAbsence.Name = "btnValiderAbsence";
            this.btnValiderAbsence.Size = new System.Drawing.Size(150, 46);
            this.btnValiderAbsence.TabIndex = 0;
            this.btnValiderAbsence.Text = "Valider";
            this.btnValiderAbsence.UseVisualStyleBackColor = true;
            this.btnValiderAbsence.Click += new System.EventHandler(this.btnValiderAbsence_Click);
            // 
            // btnAnnulerAbsence
            // 
            this.btnAnnulerAbsence.Location = new System.Drawing.Point(732, 230);
            this.btnAnnulerAbsence.Name = "btnAnnulerAbsence";
            this.btnAnnulerAbsence.Size = new System.Drawing.Size(150, 46);
            this.btnAnnulerAbsence.TabIndex = 1;
            this.btnAnnulerAbsence.Text = "Annuler";
            this.btnAnnulerAbsence.UseVisualStyleBackColor = true;
            this.btnAnnulerAbsence.Click += new System.EventHandler(this.btnAnnulerAbsence_Click);
            // 
            // dateDebut
            // 
            this.dateDebut.Location = new System.Drawing.Point(254, 90);
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.Size = new System.Drawing.Size(358, 39);
            this.dateDebut.TabIndex = 2;
            // 
            // dateFin
            // 
            this.dateFin.Location = new System.Drawing.Point(254, 180);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(358, 39);
            this.dateFin.TabIndex = 3;
            // 
            // cbMotif
            // 
            this.cbMotif.FormattingEnabled = true;
            this.cbMotif.Location = new System.Drawing.Point(254, 274);
            this.cbMotif.Name = "cbMotif";
            this.cbMotif.Size = new System.Drawing.Size(358, 40);
            this.cbMotif.TabIndex = 4;
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Location = new System.Drawing.Point(40, 95);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(168, 32);
            this.lblDateDebut.TabIndex = 5;
            this.lblDateDebut.Text = "Date de début";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(75, 187);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(133, 32);
            this.lblDateFin.TabIndex = 6;
            this.lblDateFin.Text = "Date de fin";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(130, 277);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(72, 32);
            this.lblMotif.TabIndex = 7;
            this.lblMotif.Text = "Motif";
            // 
            // frmAjoutAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 496);
            this.Controls.Add(this.lblMotif);
            this.Controls.Add(this.lblDateFin);
            this.Controls.Add(this.lblDateDebut);
            this.Controls.Add(this.cbMotif);
            this.Controls.Add(this.dateFin);
            this.Controls.Add(this.dateDebut);
            this.Controls.Add(this.btnAnnulerAbsence);
            this.Controls.Add(this.btnValiderAbsence);
            this.Name = "frmAjoutAbsence";
            this.Text = "Ajouter une absence à";
            this.Load += new System.EventHandler(this.frmAjoutModifAbsence_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValiderAbsence;
        private System.Windows.Forms.Button btnAnnulerAbsence;
        private System.Windows.Forms.DateTimePicker dateDebut;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.ComboBox cbMotif;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblMotif;
    }
}