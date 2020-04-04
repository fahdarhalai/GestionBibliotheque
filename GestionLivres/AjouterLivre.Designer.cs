namespace GestionLivres
{
    partial class AjouterLivre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterLivre));
            this.metroPanelAjouterLivre = new MetroFramework.Controls.MetroPanel();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.metroTextBoxPrix = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxTitre = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.erreurCode = new System.Windows.Forms.PictureBox();
            this.erreurTitre = new System.Windows.Forms.PictureBox();
            this.erreurPrix = new System.Windows.Forms.PictureBox();
            this.metroPanelAjouterLivre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erreurCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erreurTitre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erreurPrix)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanelAjouterLivre
            // 
            this.metroPanelAjouterLivre.Controls.Add(this.erreurPrix);
            this.metroPanelAjouterLivre.Controls.Add(this.erreurTitre);
            this.metroPanelAjouterLivre.Controls.Add(this.erreurCode);
            this.metroPanelAjouterLivre.Controls.Add(this.buttonAjouter);
            this.metroPanelAjouterLivre.Controls.Add(this.metroTextBoxPrix);
            this.metroPanelAjouterLivre.Controls.Add(this.metroTextBoxTitre);
            this.metroPanelAjouterLivre.Controls.Add(this.metroTextBoxCode);
            this.metroPanelAjouterLivre.Controls.Add(this.metroLabel6);
            this.metroPanelAjouterLivre.Controls.Add(this.metroLabel4);
            this.metroPanelAjouterLivre.Controls.Add(this.metroLabel3);
            this.metroPanelAjouterLivre.Controls.Add(this.metroLabel2);
            this.metroPanelAjouterLivre.HorizontalScrollbarBarColor = true;
            this.metroPanelAjouterLivre.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelAjouterLivre.HorizontalScrollbarSize = 10;
            this.metroPanelAjouterLivre.Location = new System.Drawing.Point(0, 0);
            this.metroPanelAjouterLivre.Name = "metroPanelAjouterLivre";
            this.metroPanelAjouterLivre.Size = new System.Drawing.Size(854, 377);
            this.metroPanelAjouterLivre.TabIndex = 9;
            this.metroPanelAjouterLivre.VerticalScrollbarBarColor = true;
            this.metroPanelAjouterLivre.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelAjouterLivre.VerticalScrollbarSize = 10;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAjouter.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAjouter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAjouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouter.Location = new System.Drawing.Point(551, 224);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(125, 29);
            this.buttonAjouter.TabIndex = 13;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // metroTextBoxPrix
            // 
            // 
            // 
            // 
            this.metroTextBoxPrix.CustomButton.Image = null;
            this.metroTextBoxPrix.CustomButton.Location = new System.Drawing.Point(328, 1);
            this.metroTextBoxPrix.CustomButton.Name = "";
            this.metroTextBoxPrix.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxPrix.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPrix.CustomButton.TabIndex = 1;
            this.metroTextBoxPrix.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPrix.CustomButton.UseSelectable = true;
            this.metroTextBoxPrix.CustomButton.Visible = false;
            this.metroTextBoxPrix.Lines = new string[0];
            this.metroTextBoxPrix.Location = new System.Drawing.Point(327, 182);
            this.metroTextBoxPrix.MaxLength = 32767;
            this.metroTextBoxPrix.Name = "metroTextBoxPrix";
            this.metroTextBoxPrix.PasswordChar = '\0';
            this.metroTextBoxPrix.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPrix.SelectedText = "";
            this.metroTextBoxPrix.SelectionLength = 0;
            this.metroTextBoxPrix.SelectionStart = 0;
            this.metroTextBoxPrix.ShortcutsEnabled = true;
            this.metroTextBoxPrix.Size = new System.Drawing.Size(350, 23);
            this.metroTextBoxPrix.TabIndex = 12;
            this.metroTextBoxPrix.UseSelectable = true;
            this.metroTextBoxPrix.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPrix.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxPrix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBoxPrix_KeyPress);
            // 
            // metroTextBoxTitre
            // 
            // 
            // 
            // 
            this.metroTextBoxTitre.CustomButton.Image = null;
            this.metroTextBoxTitre.CustomButton.Location = new System.Drawing.Point(328, 1);
            this.metroTextBoxTitre.CustomButton.Name = "";
            this.metroTextBoxTitre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxTitre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxTitre.CustomButton.TabIndex = 1;
            this.metroTextBoxTitre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxTitre.CustomButton.UseSelectable = true;
            this.metroTextBoxTitre.CustomButton.Visible = false;
            this.metroTextBoxTitre.Lines = new string[0];
            this.metroTextBoxTitre.Location = new System.Drawing.Point(327, 140);
            this.metroTextBoxTitre.MaxLength = 32767;
            this.metroTextBoxTitre.Name = "metroTextBoxTitre";
            this.metroTextBoxTitre.PasswordChar = '\0';
            this.metroTextBoxTitre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxTitre.SelectedText = "";
            this.metroTextBoxTitre.SelectionLength = 0;
            this.metroTextBoxTitre.SelectionStart = 0;
            this.metroTextBoxTitre.ShortcutsEnabled = true;
            this.metroTextBoxTitre.Size = new System.Drawing.Size(350, 23);
            this.metroTextBoxTitre.TabIndex = 11;
            this.metroTextBoxTitre.UseSelectable = true;
            this.metroTextBoxTitre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxTitre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxCode
            // 
            // 
            // 
            // 
            this.metroTextBoxCode.CustomButton.Image = null;
            this.metroTextBoxCode.CustomButton.Location = new System.Drawing.Point(328, 1);
            this.metroTextBoxCode.CustomButton.Name = "";
            this.metroTextBoxCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxCode.CustomButton.TabIndex = 1;
            this.metroTextBoxCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxCode.CustomButton.UseSelectable = true;
            this.metroTextBoxCode.CustomButton.Visible = false;
            this.metroTextBoxCode.Lines = new string[0];
            this.metroTextBoxCode.Location = new System.Drawing.Point(327, 97);
            this.metroTextBoxCode.MaxLength = 32767;
            this.metroTextBoxCode.Name = "metroTextBoxCode";
            this.metroTextBoxCode.PasswordChar = '\0';
            this.metroTextBoxCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxCode.SelectedText = "";
            this.metroTextBoxCode.SelectionLength = 0;
            this.metroTextBoxCode.SelectionStart = 0;
            this.metroTextBoxCode.ShortcutsEnabled = true;
            this.metroTextBoxCode.Size = new System.Drawing.Size(350, 23);
            this.metroTextBoxCode.TabIndex = 10;
            this.metroTextBoxCode.UseSelectable = true;
            this.metroTextBoxCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(177, 182);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(85, 19);
            this.metroLabel6.TabIndex = 9;
            this.metroLabel6.Text = "Prix du livre :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(177, 140);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(89, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Titre du livre :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(177, 98);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(95, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Code du livre :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(77, 20);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(141, 25);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Ajouter un livre :";
            // 
            // erreurCode
            // 
            this.erreurCode.Image = ((System.Drawing.Image)(resources.GetObject("erreurCode.Image")));
            this.erreurCode.Location = new System.Drawing.Point(652, 98);
            this.erreurCode.Name = "erreurCode";
            this.erreurCode.Size = new System.Drawing.Size(23, 21);
            this.erreurCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.erreurCode.TabIndex = 14;
            this.erreurCode.TabStop = false;
            this.erreurCode.Visible = false;
            // 
            // erreurTitre
            // 
            this.erreurTitre.Image = ((System.Drawing.Image)(resources.GetObject("erreurTitre.Image")));
            this.erreurTitre.Location = new System.Drawing.Point(652, 141);
            this.erreurTitre.Name = "erreurTitre";
            this.erreurTitre.Size = new System.Drawing.Size(23, 21);
            this.erreurTitre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.erreurTitre.TabIndex = 15;
            this.erreurTitre.TabStop = false;
            this.erreurTitre.Visible = false;
            // 
            // erreurPrix
            // 
            this.erreurPrix.Image = ((System.Drawing.Image)(resources.GetObject("erreurPrix.Image")));
            this.erreurPrix.Location = new System.Drawing.Point(652, 183);
            this.erreurPrix.Name = "erreurPrix";
            this.erreurPrix.Size = new System.Drawing.Size(23, 21);
            this.erreurPrix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.erreurPrix.TabIndex = 16;
            this.erreurPrix.TabStop = false;
            this.erreurPrix.Visible = false;
            // 
            // AjouterLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.metroPanelAjouterLivre);
            this.MaximumSize = new System.Drawing.Size(854, 377);
            this.MinimumSize = new System.Drawing.Size(854, 377);
            this.Name = "AjouterLivre";
            this.Size = new System.Drawing.Size(854, 377);
            this.metroPanelAjouterLivre.ResumeLayout(false);
            this.metroPanelAjouterLivre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erreurCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erreurTitre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erreurPrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanelAjouterLivre;
        private System.Windows.Forms.Button buttonAjouter;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPrix;
        private MetroFramework.Controls.MetroTextBox metroTextBoxTitre;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCode;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox erreurCode;
        private System.Windows.Forms.PictureBox erreurTitre;
        private System.Windows.Forms.PictureBox erreurPrix;
    }
}
