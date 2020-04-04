namespace GestionLivres
{
    partial class RetirerLivre
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetirerLivre));
            this.metroPanelRetirerLivre = new MetroFramework.Controls.MetroPanel();
            this.erreurCode = new System.Windows.Forms.PictureBox();
            this.erreurNumero = new System.Windows.Forms.PictureBox();
            this.buttonRetirer = new System.Windows.Forms.Button();
            this.metroComboBoxLivre = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxEtagere = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanelRetirerLivre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erreurCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erreurNumero)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanelRetirerLivre
            // 
            this.metroPanelRetirerLivre.Controls.Add(this.erreurCode);
            this.metroPanelRetirerLivre.Controls.Add(this.erreurNumero);
            this.metroPanelRetirerLivre.Controls.Add(this.buttonRetirer);
            this.metroPanelRetirerLivre.Controls.Add(this.metroComboBoxLivre);
            this.metroPanelRetirerLivre.Controls.Add(this.metroLabel1);
            this.metroPanelRetirerLivre.Controls.Add(this.metroComboBoxEtagere);
            this.metroPanelRetirerLivre.Controls.Add(this.metroLabel4);
            this.metroPanelRetirerLivre.Controls.Add(this.metroLabel2);
            this.metroPanelRetirerLivre.HorizontalScrollbarBarColor = true;
            this.metroPanelRetirerLivre.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelRetirerLivre.HorizontalScrollbarSize = 10;
            this.metroPanelRetirerLivre.Location = new System.Drawing.Point(0, 0);
            this.metroPanelRetirerLivre.Name = "metroPanelRetirerLivre";
            this.metroPanelRetirerLivre.Size = new System.Drawing.Size(854, 377);
            this.metroPanelRetirerLivre.TabIndex = 1;
            this.metroPanelRetirerLivre.VerticalScrollbarBarColor = true;
            this.metroPanelRetirerLivre.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelRetirerLivre.VerticalScrollbarSize = 10;
            // 
            // erreurCode
            // 
            this.erreurCode.Image = ((System.Drawing.Image)(resources.GetObject("erreurCode.Image")));
            this.erreurCode.Location = new System.Drawing.Point(578, 182);
            this.erreurCode.Name = "erreurCode";
            this.erreurCode.Size = new System.Drawing.Size(23, 21);
            this.erreurCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.erreurCode.TabIndex = 32;
            this.erreurCode.TabStop = false;
            this.erreurCode.Visible = false;
            // 
            // erreurNumero
            // 
            this.erreurNumero.Image = ((System.Drawing.Image)(resources.GetObject("erreurNumero.Image")));
            this.erreurNumero.Location = new System.Drawing.Point(578, 140);
            this.erreurNumero.Name = "erreurNumero";
            this.erreurNumero.Size = new System.Drawing.Size(23, 21);
            this.erreurNumero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.erreurNumero.TabIndex = 31;
            this.erreurNumero.TabStop = false;
            this.erreurNumero.Visible = false;
            // 
            // buttonRetirer
            // 
            this.buttonRetirer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonRetirer.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonRetirer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonRetirer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonRetirer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetirer.Location = new System.Drawing.Point(449, 220);
            this.buttonRetirer.Name = "buttonRetirer";
            this.buttonRetirer.Size = new System.Drawing.Size(125, 29);
            this.buttonRetirer.TabIndex = 30;
            this.buttonRetirer.Text = "Retirer";
            this.buttonRetirer.UseVisualStyleBackColor = false;
            this.buttonRetirer.Click += new System.EventHandler(this.buttonRetirer_Click);
            // 
            // metroComboBoxLivre
            // 
            this.metroComboBoxLivre.FormattingEnabled = true;
            this.metroComboBoxLivre.ItemHeight = 23;
            this.metroComboBoxLivre.Location = new System.Drawing.Point(449, 178);
            this.metroComboBoxLivre.Name = "metroComboBoxLivre";
            this.metroComboBoxLivre.Size = new System.Drawing.Size(125, 29);
            this.metroComboBoxLivre.TabIndex = 29;
            this.metroComboBoxLivre.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(299, 182);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 19);
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "Code du livre :";
            // 
            // metroComboBoxEtagere
            // 
            this.metroComboBoxEtagere.FormattingEnabled = true;
            this.metroComboBoxEtagere.ItemHeight = 23;
            this.metroComboBoxEtagere.Location = new System.Drawing.Point(449, 136);
            this.metroComboBoxEtagere.Name = "metroComboBoxEtagere";
            this.metroComboBoxEtagere.Size = new System.Drawing.Size(125, 29);
            this.metroComboBoxEtagere.TabIndex = 27;
            this.metroComboBoxEtagere.UseSelectable = true;
            this.metroComboBoxEtagere.SelectedIndexChanged += new System.EventHandler(this.metroComboBoxEtagere_SelectedIndexChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(299, 140);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(105, 19);
            this.metroLabel4.TabIndex = 26;
            this.metroLabel4.Text = "N° de l\'étagère :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(77, 20);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(133, 25);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Retirer un livre :";
            // 
            // RetirerLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.metroPanelRetirerLivre);
            this.MaximumSize = new System.Drawing.Size(854, 377);
            this.MinimumSize = new System.Drawing.Size(854, 377);
            this.Name = "RetirerLivre";
            this.Size = new System.Drawing.Size(854, 377);
            this.metroPanelRetirerLivre.ResumeLayout(false);
            this.metroPanelRetirerLivre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erreurCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erreurNumero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanelRetirerLivre;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Button buttonRetirer;
        private MetroFramework.Controls.MetroComboBox metroComboBoxLivre;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBoxEtagere;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.PictureBox erreurNumero;
        private System.Windows.Forms.PictureBox erreurCode;
    }
}
