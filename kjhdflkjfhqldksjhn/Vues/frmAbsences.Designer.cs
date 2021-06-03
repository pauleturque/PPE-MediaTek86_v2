
namespace kjhdflkjfhqldksjhn
{
    partial class frmAbsences
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
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.btnAjoutAbsence = new System.Windows.Forms.Button();
            this.btnSupprimerAbsence = new System.Windows.Forms.Button();
            this.btnModifierAbsence = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(40, 294);
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.RowHeadersWidth = 82;
            this.dgvAbsences.RowTemplate.Height = 41;
            this.dgvAbsences.Size = new System.Drawing.Size(718, 434);
            this.dgvAbsences.TabIndex = 0;
            // 
            // btnAjoutAbsence
            // 
            this.btnAjoutAbsence.Location = new System.Drawing.Point(40, 220);
            this.btnAjoutAbsence.Name = "btnAjoutAbsence";
            this.btnAjoutAbsence.Size = new System.Drawing.Size(150, 46);
            this.btnAjoutAbsence.TabIndex = 1;
            this.btnAjoutAbsence.Text = "Ajouter";
            this.btnAjoutAbsence.UseVisualStyleBackColor = true;
            this.btnAjoutAbsence.Click += new System.EventHandler(this.btnAjoutAbsence_Click);
            // 
            // btnSupprimerAbsence
            // 
            this.btnSupprimerAbsence.Location = new System.Drawing.Point(210, 220);
            this.btnSupprimerAbsence.Name = "btnSupprimerAbsence";
            this.btnSupprimerAbsence.Size = new System.Drawing.Size(150, 46);
            this.btnSupprimerAbsence.TabIndex = 2;
            this.btnSupprimerAbsence.Text = "Supprimer";
            this.btnSupprimerAbsence.UseVisualStyleBackColor = true;
            this.btnSupprimerAbsence.Click += new System.EventHandler(this.btnSupprimerAbsence_Click);
            // 
            // btnModifierAbsence
            // 
            this.btnModifierAbsence.Location = new System.Drawing.Point(384, 220);
            this.btnModifierAbsence.Name = "btnModifierAbsence";
            this.btnModifierAbsence.Size = new System.Drawing.Size(150, 46);
            this.btnModifierAbsence.TabIndex = 3;
            this.btnModifierAbsence.Text = "Modifier";
            this.btnModifierAbsence.UseVisualStyleBackColor = true;
            this.btnModifierAbsence.Click += new System.EventHandler(this.btnModifierAbsence_Click);
            // 
            // frmAbsences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 759);
            this.Controls.Add(this.btnModifierAbsence);
            this.Controls.Add(this.btnSupprimerAbsence);
            this.Controls.Add(this.btnAjoutAbsence);
            this.Controls.Add(this.dgvAbsences);
            this.Name = "frmAbsences";
            this.Text = "MediaTek86 - Absences de ";
            this.Load += new System.EventHandler(this.frmAbsences_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAbsences;
        private System.Windows.Forms.Button btnAjoutAbsence;
        private System.Windows.Forms.Button btnSupprimerAbsence;
        private System.Windows.Forms.Button btnModifierAbsence;
    }
}