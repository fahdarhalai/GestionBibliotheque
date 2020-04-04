namespace GestionLivres
{
    partial class Acceuil
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acceuil));
            this.metroTileAjouterLivre = new MetroFramework.Controls.MetroTile();
            this.metroTileAjouterEtagere = new MetroFramework.Controls.MetroTile();
            this.metroTileLister = new MetroFramework.Controls.MetroTile();
            this.metroTileRemplacerLivre = new MetroFramework.Controls.MetroTile();
            this.metroTileRemettreLivre = new MetroFramework.Controls.MetroTile();
            this.metroTileRetirerLivre = new MetroFramework.Controls.MetroTile();
            this.modeSombre = new MetroFramework.Controls.MetroCheckBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroPanelAcceuil = new MetroFramework.Controls.MetroPanel();
            this.metroTileQuitter = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.metroPanelAcceuil.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTileAjouterLivre
            // 
            this.metroTileAjouterLivre.ActiveControl = null;
            this.metroTileAjouterLivre.Location = new System.Drawing.Point(427, 86);
            this.metroTileAjouterLivre.Name = "metroTileAjouterLivre";
            this.metroTileAjouterLivre.Size = new System.Drawing.Size(120, 120);
            this.metroTileAjouterLivre.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTileAjouterLivre.TabIndex = 1;
            this.metroTileAjouterLivre.Text = "Ajouter Livre";
            this.metroTileAjouterLivre.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTileAjouterLivre.TileImage")));
            this.metroTileAjouterLivre.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAjouterLivre.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileAjouterLivre.UseSelectable = true;
            this.metroTileAjouterLivre.UseTileImage = true;
            this.metroTileAjouterLivre.Click += new System.EventHandler(this.metroTileAjouterLivre_Click);
            // 
            // metroTileAjouterEtagere
            // 
            this.metroTileAjouterEtagere.ActiveControl = null;
            this.metroTileAjouterEtagere.Location = new System.Drawing.Point(550, 86);
            this.metroTileAjouterEtagere.Name = "metroTileAjouterEtagere";
            this.metroTileAjouterEtagere.Size = new System.Drawing.Size(120, 120);
            this.metroTileAjouterEtagere.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTileAjouterEtagere.TabIndex = 1;
            this.metroTileAjouterEtagere.Text = "Ajouter Etagère";
            this.metroTileAjouterEtagere.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTileAjouterEtagere.TileImage")));
            this.metroTileAjouterEtagere.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAjouterEtagere.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileAjouterEtagere.UseSelectable = true;
            this.metroTileAjouterEtagere.UseTileImage = true;
            this.metroTileAjouterEtagere.Click += new System.EventHandler(this.metroTileAjouterEtagere_Click);
            // 
            // metroTileLister
            // 
            this.metroTileLister.ActiveControl = null;
            this.metroTileLister.BackColor = System.Drawing.Color.White;
            this.metroTileLister.Location = new System.Drawing.Point(184, 86);
            this.metroTileLister.Name = "metroTileLister";
            this.metroTileLister.Size = new System.Drawing.Size(240, 120);
            this.metroTileLister.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTileLister.TabIndex = 1;
            this.metroTileLister.Text = "Lister la Bibliothèque";
            this.metroTileLister.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTileLister.TileImage")));
            this.metroTileLister.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileLister.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileLister.UseSelectable = true;
            this.metroTileLister.UseTileImage = true;
            this.metroTileLister.Click += new System.EventHandler(this.metroTileLister_Click);
            // 
            // metroTileRemplacerLivre
            // 
            this.metroTileRemplacerLivre.ActiveControl = null;
            this.metroTileRemplacerLivre.Location = new System.Drawing.Point(184, 209);
            this.metroTileRemplacerLivre.Name = "metroTileRemplacerLivre";
            this.metroTileRemplacerLivre.Size = new System.Drawing.Size(240, 120);
            this.metroTileRemplacerLivre.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTileRemplacerLivre.TabIndex = 1;
            this.metroTileRemplacerLivre.Text = "Remplacer un Livre par un autre";
            this.metroTileRemplacerLivre.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTileRemplacerLivre.TileImage")));
            this.metroTileRemplacerLivre.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileRemplacerLivre.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileRemplacerLivre.UseSelectable = true;
            this.metroTileRemplacerLivre.UseTileImage = true;
            this.metroTileRemplacerLivre.Click += new System.EventHandler(this.metroTileRemplacerLivre_Click);
            // 
            // metroTileRemettreLivre
            // 
            this.metroTileRemettreLivre.ActiveControl = null;
            this.metroTileRemettreLivre.Location = new System.Drawing.Point(427, 209);
            this.metroTileRemettreLivre.Name = "metroTileRemettreLivre";
            this.metroTileRemettreLivre.Size = new System.Drawing.Size(120, 120);
            this.metroTileRemettreLivre.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTileRemettreLivre.TabIndex = 1;
            this.metroTileRemettreLivre.Text = "Remettre Livre";
            this.metroTileRemettreLivre.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTileRemettreLivre.TileImage")));
            this.metroTileRemettreLivre.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileRemettreLivre.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileRemettreLivre.UseSelectable = true;
            this.metroTileRemettreLivre.UseTileImage = true;
            this.metroTileRemettreLivre.Click += new System.EventHandler(this.metroTileRemettreLivre_Click);
            // 
            // metroTileRetirerLivre
            // 
            this.metroTileRetirerLivre.ActiveControl = null;
            this.metroTileRetirerLivre.Location = new System.Drawing.Point(550, 209);
            this.metroTileRetirerLivre.Name = "metroTileRetirerLivre";
            this.metroTileRetirerLivre.Size = new System.Drawing.Size(120, 120);
            this.metroTileRetirerLivre.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTileRetirerLivre.TabIndex = 1;
            this.metroTileRetirerLivre.Text = "Retirer Livre";
            this.metroTileRetirerLivre.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTileRetirerLivre.TileImage")));
            this.metroTileRetirerLivre.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileRetirerLivre.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileRetirerLivre.UseSelectable = true;
            this.metroTileRetirerLivre.UseTileImage = true;
            this.metroTileRetirerLivre.Click += new System.EventHandler(this.metroTileRetirerLivre_Click);
            // 
            // modeSombre
            // 
            this.modeSombre.AutoSize = true;
            this.modeSombre.Location = new System.Drawing.Point(655, 42);
            this.modeSombre.Name = "modeSombre";
            this.modeSombre.Size = new System.Drawing.Size(98, 15);
            this.modeSombre.TabIndex = 5;
            this.modeSombre.Text = "Mode Sombre";
            this.modeSombre.UseSelectable = true;
            this.modeSombre.CheckedChanged += new System.EventHandler(this.modeSombre_CheckedChanged);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // metroPanelAcceuil
            // 
            this.metroPanelAcceuil.Controls.Add(this.metroTileQuitter);
            this.metroPanelAcceuil.Controls.Add(this.metroTileRemplacerLivre);
            this.metroPanelAcceuil.Controls.Add(this.metroTileAjouterEtagere);
            this.metroPanelAcceuil.Controls.Add(this.metroTileRetirerLivre);
            this.metroPanelAcceuil.Controls.Add(this.metroTileAjouterLivre);
            this.metroPanelAcceuil.Controls.Add(this.metroTileRemettreLivre);
            this.metroPanelAcceuil.Controls.Add(this.metroTileLister);
            this.metroPanelAcceuil.HorizontalScrollbarBarColor = true;
            this.metroPanelAcceuil.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelAcceuil.HorizontalScrollbarSize = 10;
            this.metroPanelAcceuil.Location = new System.Drawing.Point(23, 63);
            this.metroPanelAcceuil.Name = "metroPanelAcceuil";
            this.metroPanelAcceuil.Size = new System.Drawing.Size(854, 414);
            this.metroPanelAcceuil.TabIndex = 6;
            this.metroPanelAcceuil.VerticalScrollbarBarColor = true;
            this.metroPanelAcceuil.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelAcceuil.VerticalScrollbarSize = 10;
            // 
            // metroTileQuitter
            // 
            this.metroTileQuitter.ActiveControl = null;
            this.metroTileQuitter.Location = new System.Drawing.Point(730, 374);
            this.metroTileQuitter.Name = "metroTileQuitter";
            this.metroTileQuitter.Size = new System.Drawing.Size(124, 40);
            this.metroTileQuitter.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTileQuitter.TabIndex = 2;
            this.metroTileQuitter.Text = "Quitter";
            this.metroTileQuitter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileQuitter.UseSelectable = true;
            this.metroTileQuitter.Click += new System.EventHandler(this.metroTileQuitter_Click);
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.metroPanelAcceuil);
            this.Controls.Add(this.modeSombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "Acceuil";
            this.Text = "Gestion de Livres";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.metroPanelAcceuil.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTileAjouterLivre;
        private MetroFramework.Controls.MetroTile metroTileAjouterEtagere;
        private MetroFramework.Controls.MetroTile metroTileLister;
        private MetroFramework.Controls.MetroTile metroTileRemplacerLivre;
        private MetroFramework.Controls.MetroTile metroTileRemettreLivre;
        private MetroFramework.Controls.MetroTile metroTileRetirerLivre;
        private MetroFramework.Controls.MetroCheckBox modeSombre;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroPanel metroPanelAcceuil;
        private MetroFramework.Controls.MetroTile metroTileQuitter;
    }
}

