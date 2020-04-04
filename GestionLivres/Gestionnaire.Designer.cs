namespace GestionLivres
{
    partial class Gestionnaire
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestionnaire));
            this.pictureBoxLightRetourner = new System.Windows.Forms.PictureBox();
            this.pictureBoxDarkRetourner = new System.Windows.Forms.PictureBox();
            this.modeSombre = new MetroFramework.Controls.MetroCheckBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroPanelContenu = new MetroFramework.Controls.MetroPanel();
            this.lister = new GestionLivres.Lister();
            this.retirerLivre = new GestionLivres.RetirerLivre();
            this.remettreLivre = new GestionLivres.RemettreLivre();
            this.remplacerLivre = new GestionLivres.RemplacerLivre();
            this.ajouterEtagere = new GestionLivres.AjouterEtagere();
            this.ajouterLivre = new GestionLivres.AjouterLivre();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLightRetourner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDarkRetourner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.metroPanelContenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxLightRetourner
            // 
            this.pictureBoxLightRetourner.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLightRetourner.Image")));
            this.pictureBoxLightRetourner.Location = new System.Drawing.Point(21, 63);
            this.pictureBoxLightRetourner.Name = "pictureBoxLightRetourner";
            this.pictureBoxLightRetourner.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxLightRetourner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLightRetourner.TabIndex = 9;
            this.pictureBoxLightRetourner.TabStop = false;
            this.pictureBoxLightRetourner.Click += new System.EventHandler(this.pictureBoxLightRetourner_Click);
            // 
            // pictureBoxDarkRetourner
            // 
            this.pictureBoxDarkRetourner.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDarkRetourner.Image")));
            this.pictureBoxDarkRetourner.Location = new System.Drawing.Point(21, 63);
            this.pictureBoxDarkRetourner.Name = "pictureBoxDarkRetourner";
            this.pictureBoxDarkRetourner.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxDarkRetourner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDarkRetourner.TabIndex = 10;
            this.pictureBoxDarkRetourner.TabStop = false;
            this.pictureBoxDarkRetourner.Visible = false;
            this.pictureBoxDarkRetourner.Click += new System.EventHandler(this.pictureBoxDarkRetourner_Click);
            // 
            // modeSombre
            // 
            this.modeSombre.AutoSize = true;
            this.modeSombre.Location = new System.Drawing.Point(655, 42);
            this.modeSombre.Name = "modeSombre";
            this.modeSombre.Size = new System.Drawing.Size(98, 15);
            this.modeSombre.TabIndex = 11;
            this.modeSombre.Text = "Mode Sombre";
            this.modeSombre.UseSelectable = true;
            this.modeSombre.CheckedChanged += new System.EventHandler(this.modeSombre_CheckedChanged);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // metroPanelContenu
            // 
            this.metroPanelContenu.Controls.Add(this.lister);
            this.metroPanelContenu.Controls.Add(this.retirerLivre);
            this.metroPanelContenu.Controls.Add(this.remettreLivre);
            this.metroPanelContenu.Controls.Add(this.remplacerLivre);
            this.metroPanelContenu.Controls.Add(this.ajouterEtagere);
            this.metroPanelContenu.Controls.Add(this.ajouterLivre);
            this.metroPanelContenu.HorizontalScrollbarBarColor = true;
            this.metroPanelContenu.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelContenu.HorizontalScrollbarSize = 10;
            this.metroPanelContenu.Location = new System.Drawing.Point(21, 100);
            this.metroPanelContenu.Name = "metroPanelContenu";
            this.metroPanelContenu.Size = new System.Drawing.Size(854, 377);
            this.metroPanelContenu.TabIndex = 8;
            this.metroPanelContenu.VerticalScrollbarBarColor = true;
            this.metroPanelContenu.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelContenu.VerticalScrollbarSize = 10;
            // 
            // lister
            // 
            this.lister.BackColor = System.Drawing.Color.White;
            this.lister.Location = new System.Drawing.Point(0, 0);
            this.lister.MaximumSize = new System.Drawing.Size(854, 377);
            this.lister.MinimumSize = new System.Drawing.Size(854, 377);
            this.lister.Name = "lister";
            this.lister.Size = new System.Drawing.Size(854, 377);
            this.lister.TabIndex = 8;
            // 
            // retirerLivre
            // 
            this.retirerLivre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.retirerLivre.Location = new System.Drawing.Point(0, 0);
            this.retirerLivre.MaximumSize = new System.Drawing.Size(854, 377);
            this.retirerLivre.MinimumSize = new System.Drawing.Size(854, 377);
            this.retirerLivre.Name = "retirerLivre";
            this.retirerLivre.Size = new System.Drawing.Size(854, 377);
            this.retirerLivre.TabIndex = 7;
            // 
            // remettreLivre
            // 
            this.remettreLivre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.remettreLivre.Location = new System.Drawing.Point(0, 0);
            this.remettreLivre.MaximumSize = new System.Drawing.Size(854, 377);
            this.remettreLivre.MinimumSize = new System.Drawing.Size(854, 377);
            this.remettreLivre.Name = "remettreLivre";
            this.remettreLivre.Size = new System.Drawing.Size(854, 377);
            this.remettreLivre.TabIndex = 6;
            // 
            // remplacerLivre
            // 
            this.remplacerLivre.BackColor = System.Drawing.Color.White;
            this.remplacerLivre.Location = new System.Drawing.Point(0, 0);
            this.remplacerLivre.MaximumSize = new System.Drawing.Size(854, 377);
            this.remplacerLivre.MinimumSize = new System.Drawing.Size(854, 377);
            this.remplacerLivre.Name = "remplacerLivre";
            this.remplacerLivre.Size = new System.Drawing.Size(854, 377);
            this.remplacerLivre.TabIndex = 5;
            // 
            // ajouterEtagere
            // 
            this.ajouterEtagere.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ajouterEtagere.Location = new System.Drawing.Point(0, 0);
            this.ajouterEtagere.MaximumSize = new System.Drawing.Size(854, 377);
            this.ajouterEtagere.MinimumSize = new System.Drawing.Size(854, 377);
            this.ajouterEtagere.Name = "ajouterEtagere";
            this.ajouterEtagere.Size = new System.Drawing.Size(854, 377);
            this.ajouterEtagere.TabIndex = 4;
            // 
            // ajouterLivre
            // 
            this.ajouterLivre.BackColor = System.Drawing.Color.White;
            this.ajouterLivre.Location = new System.Drawing.Point(0, 0);
            this.ajouterLivre.MaximumSize = new System.Drawing.Size(854, 377);
            this.ajouterLivre.MinimumSize = new System.Drawing.Size(854, 377);
            this.ajouterLivre.Name = "ajouterLivre";
            this.ajouterLivre.Size = new System.Drawing.Size(854, 377);
            this.ajouterLivre.TabIndex = 2;
            // 
            // Gestionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.modeSombre);
            this.Controls.Add(this.pictureBoxLightRetourner);
            this.Controls.Add(this.pictureBoxDarkRetourner);
            this.Controls.Add(this.metroPanelContenu);
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "Gestionnaire";
            this.Text = "Gestion de Livres";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLightRetourner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDarkRetourner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.metroPanelContenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxLightRetourner;
        private System.Windows.Forms.PictureBox pictureBoxDarkRetourner;
        private MetroFramework.Controls.MetroCheckBox modeSombre;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroPanel metroPanelContenu;
        private AjouterLivre ajouterLivre;
        private RetirerLivre retirerLivre;
        private RemettreLivre remettreLivre;
        private RemplacerLivre remplacerLivre;
        private AjouterEtagere ajouterEtagere;
        private Lister lister;
    }
}