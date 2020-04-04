namespace GestionLivres
{
    partial class RemettreLivre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemettreLivre));
            this.metroPanelRemettreLivre = new MetroFramework.Controls.MetroPanel();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.metroComboBoxEtagere = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxCode = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.erreurCode = new System.Windows.Forms.PictureBox();
            this.erreurEtagere = new System.Windows.Forms.PictureBox();
            this.metroPanelRemettreLivre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erreurCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erreurEtagere)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanelRemettreLivre
            // 
            this.metroPanelRemettreLivre.Controls.Add(this.erreurEtagere);
            this.metroPanelRemettreLivre.Controls.Add(this.erreurCode);
            this.metroPanelRemettreLivre.Controls.Add(this.buttonAjouter);
            this.metroPanelRemettreLivre.Controls.Add(this.metroComboBoxEtagere);
            this.metroPanelRemettreLivre.Controls.Add(this.metroLabel1);
            this.metroPanelRemettreLivre.Controls.Add(this.metroComboBoxCode);
            this.metroPanelRemettreLivre.Controls.Add(this.metroLabel4);
            this.metroPanelRemettreLivre.Controls.Add(this.metroLabel2);
            this.metroPanelRemettreLivre.HorizontalScrollbarBarColor = true;
            this.metroPanelRemettreLivre.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelRemettreLivre.HorizontalScrollbarSize = 10;
            this.metroPanelRemettreLivre.Location = new System.Drawing.Point(0, 0);
            this.metroPanelRemettreLivre.Name = "metroPanelRemettreLivre";
            this.metroPanelRemettreLivre.Size = new System.Drawing.Size(854, 377);
            this.metroPanelRemettreLivre.TabIndex = 1;
            this.metroPanelRemettreLivre.VerticalScrollbarBarColor = true;
            this.metroPanelRemettreLivre.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelRemettreLivre.VerticalScrollbarSize = 10;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAjouter.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAjouter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAjouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouter.Location = new System.Drawing.Point(449, 220);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(125, 29);
            this.buttonAjouter.TabIndex = 25;
            this.buttonAjouter.Text = "Remettre";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // metroComboBoxEtagere
            // 
            this.metroComboBoxEtagere.FormattingEnabled = true;
            this.metroComboBoxEtagere.ItemHeight = 23;
            this.metroComboBoxEtagere.Location = new System.Drawing.Point(449, 178);
            this.metroComboBoxEtagere.Name = "metroComboBoxEtagere";
            this.metroComboBoxEtagere.Size = new System.Drawing.Size(125, 29);
            this.metroComboBoxEtagere.TabIndex = 24;
            this.metroComboBoxEtagere.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(299, 182);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(105, 19);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "N° de l\'étagère :";
            // 
            // metroComboBoxCode
            // 
            this.metroComboBoxCode.FormattingEnabled = true;
            this.metroComboBoxCode.ItemHeight = 23;
            this.metroComboBoxCode.Location = new System.Drawing.Point(449, 136);
            this.metroComboBoxCode.Name = "metroComboBoxCode";
            this.metroComboBoxCode.Size = new System.Drawing.Size(125, 29);
            this.metroComboBoxCode.TabIndex = 22;
            this.metroComboBoxCode.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(299, 140);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(95, 19);
            this.metroLabel4.TabIndex = 21;
            this.metroLabel4.Text = "Code du livre :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(77, 20);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(154, 25);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Remettre un livre :";
            // 
            // erreurCode
            // 
            this.erreurCode.Image = ((System.Drawing.Image)(resources.GetObject("erreurCode.Image")));
            this.erreurCode.Location = new System.Drawing.Point(578, 140);
            this.erreurCode.Name = "erreurCode";
            this.erreurCode.Size = new System.Drawing.Size(23, 21);
            this.erreurCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.erreurCode.TabIndex = 26;
            this.erreurCode.TabStop = false;
            this.erreurCode.Visible = false;
            // 
            // erreurEtagere
            // 
            this.erreurEtagere.Image = ((System.Drawing.Image)(resources.GetObject("erreurEtagere.Image")));
            this.erreurEtagere.Location = new System.Drawing.Point(578, 182);
            this.erreurEtagere.Name = "erreurEtagere";
            this.erreurEtagere.Size = new System.Drawing.Size(23, 21);
            this.erreurEtagere.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.erreurEtagere.TabIndex = 27;
            this.erreurEtagere.TabStop = false;
            this.erreurEtagere.Visible = false;
            // 
            // RemettreLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.metroPanelRemettreLivre);
            this.MaximumSize = new System.Drawing.Size(854, 377);
            this.MinimumSize = new System.Drawing.Size(854, 377);
            this.Name = "RemettreLivre";
            this.Size = new System.Drawing.Size(854, 377);
            this.metroPanelRemettreLivre.ResumeLayout(false);
            this.metroPanelRemettreLivre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erreurCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erreurEtagere)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanelRemettreLivre;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Button buttonAjouter;
        private MetroFramework.Controls.MetroComboBox metroComboBoxEtagere;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBoxCode;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.PictureBox erreurEtagere;
        private System.Windows.Forms.PictureBox erreurCode;
    }
}
