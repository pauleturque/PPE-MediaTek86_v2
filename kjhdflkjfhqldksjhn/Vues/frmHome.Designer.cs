
namespace kjhdflkjfhqldksjhn
{
    partial class frmHome
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
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.btnAddPerso = new System.Windows.Forms.Button();
            this.btnDelPerso = new System.Windows.Forms.Button();
            this.btnAbsPerso = new System.Windows.Forms.Button();
            this.btnModifierPerso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Location = new System.Drawing.Point(58, 264);
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.RowHeadersWidth = 82;
            this.dgvPersonnel.RowTemplate.Height = 41;
            this.dgvPersonnel.Size = new System.Drawing.Size(672, 458);
            this.dgvPersonnel.TabIndex = 0;
            // 
            // btnAddPerso
            // 
            this.btnAddPerso.Location = new System.Drawing.Point(58, 196);
            this.btnAddPerso.Name = "btnAddPerso";
            this.btnAddPerso.Size = new System.Drawing.Size(150, 46);
            this.btnAddPerso.TabIndex = 1;
            this.btnAddPerso.Text = "Ajouter";
            this.btnAddPerso.UseVisualStyleBackColor = true;
            this.btnAddPerso.Click += new System.EventHandler(this.btnAddPerso_Click);
            // 
            // btnDelPerso
            // 
            this.btnDelPerso.Location = new System.Drawing.Point(230, 196);
            this.btnDelPerso.Name = "btnDelPerso";
            this.btnDelPerso.Size = new System.Drawing.Size(150, 46);
            this.btnDelPerso.TabIndex = 2;
            this.btnDelPerso.Text = "Supprimer";
            this.btnDelPerso.UseVisualStyleBackColor = true;
            this.btnDelPerso.Click += new System.EventHandler(this.btnDelPerso_Click);
            // 
            // btnAbsPerso
            // 
            this.btnAbsPerso.Location = new System.Drawing.Point(580, 196);
            this.btnAbsPerso.Name = "btnAbsPerso";
            this.btnAbsPerso.Size = new System.Drawing.Size(150, 46);
            this.btnAbsPerso.TabIndex = 4;
            this.btnAbsPerso.Text = "Absences";
            this.btnAbsPerso.UseVisualStyleBackColor = true;
            this.btnAbsPerso.Click += new System.EventHandler(this.btnAbsPerso_Click);
            // 
            // btnModifierPerso
            // 
            this.btnModifierPerso.Location = new System.Drawing.Point(408, 196);
            this.btnModifierPerso.Name = "btnModifierPerso";
            this.btnModifierPerso.Size = new System.Drawing.Size(150, 46);
            this.btnModifierPerso.TabIndex = 5;
            this.btnModifierPerso.Text = "Modifier";
            this.btnModifierPerso.UseVisualStyleBackColor = true;
            this.btnModifierPerso.Click += new System.EventHandler(this.btnModifierPerso_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 759);
            this.Controls.Add(this.btnModifierPerso);
            this.Controls.Add(this.btnAbsPerso);
            this.Controls.Add(this.btnDelPerso);
            this.Controls.Add(this.btnAddPerso);
            this.Controls.Add(this.dgvPersonnel);
            this.Name = "frmHome";
            this.Text = "MediaTek86 - Liste Personnel";
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Windows.Forms.Button btnAddPerso;
        private System.Windows.Forms.Button btnDelPerso;
        //private System.Windows.Forms.Button btnModPerso;
        private System.Windows.Forms.Button btnAbsPerso;
        private System.Windows.Forms.Button btnModifierPerso;
    }
}