namespace GestionLivres
{
    partial class RemplacerLivre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemplacerLivre));
            this.metroPanelRemplacerLivre = new MetroFramework.Controls.MetroPanel();
            this.buttonRemplacer = new System.Windows.Forms.Button();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.erreurLivreRemplacant = new System.Windows.Forms.PictureBox();
            this.metroComboBoxEtagereRemplacant = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.erreurEtagereRemplacant = new System.Windows.Forms.PictureBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxLivreRemplacant = new MetroFramework.Controls.MetroComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxEtagereRetire = new MetroFramework.Controls.MetroComboBox();
            this.erreurEtagereRetire = new System.Windows.Forms.PictureBox();
            this.erreurLivreRetire = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxLivreRetire = new MetroFramework.Controls.MetroComboBox();
            this.metroPanelRemplacerLivre.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erreurLivreRemplacant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erreurEtagereRemplacant)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erreurEtagereRetire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erreurLivreRetire)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanelRemplacerLivre
            // 
            this.metroPanelRemplacerLivre.Controls.Add(this.buttonRemplacer);
            this.metroPanelRemplacerLivre.Controls.Add(this.metroLabel2);
            this.metroPanelRemplacerLivre.Controls.Add(this.groupBox2);
            this.metroPanelRemplacerLivre.Controls.Add(this.groupBox1);
            this.metroPanelRemplacerLivre.HorizontalScrollbarBarColor = true;
            this.metroPanelRemplacerLivre.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelRemplacerLivre.HorizontalScrollbarSize = 10;
            this.metroPanelRemplacerLivre.Location = new System.Drawing.Point(0, 0);
            this.metroPanelRemplacerLivre.Name = "metroPanelRemplacerLivre";
            this.metroPanelRemplacerLivre.Size = new System.Drawing.Size(854, 377);
            this.metroPanelRemplacerLivre.TabIndex = 0;
            this.metroPanelRemplacerLivre.VerticalScrollbarBarColor = true;
            this.metroPanelRemplacerLivre.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelRemplacerLivre.VerticalScrollbarSize = 10;
            // 
            // buttonRemplacer
            // 
            this.buttonRemplacer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonRemplacer.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonRemplacer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonRemplacer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonRemplacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemplacer.Location = new System.Drawing.Point(605, 265);
            this.buttonRemplacer.Name = "buttonRemplacer";
            this.buttonRemplacer.Size = new System.Drawing.Size(125, 29);
            this.buttonRemplacer.TabIndex = 20;
            this.buttonRemplacer.Text = "Remplacer";
            this.buttonRemplacer.UseVisualStyleBackColor = false;
            this.buttonRemplacer.Click += new System.EventHandler(this.buttonRemplacer_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(77, 20);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(165, 25);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Remplacer un livre :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.erreurLivreRemplacant);
            this.groupBox2.Controls.Add(this.metroComboBoxEtagereRemplacant);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.erreurEtagereRemplacant);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.metroComboBoxLivreRemplacant);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(124, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(606, 85);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Livre Remplaçant";
            // 
            // erreurLivreRemplacant
            // 
            this.erreurLivreRemplacant.Image = ((System.Drawing.Image)(resources.GetObject("erreurLivreRemplacant.Image")));
            this.erreurLivreRemplacant.Location = new System.Drawing.Point(559, 35);
            this.erreurLivreRemplacant.Name = "erreurLivreRemplacant";
            this.erreurLivreRemplacant.Size = new System.Drawing.Size(23, 21);
            this.erreurLivreRemplacant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.erreurLivreRemplacant.TabIndex = 26;
            this.erreurLivreRemplacant.TabStop = false;
            this.erreurLivreRemplacant.Visible = false;
            // 
            // metroComboBoxEtagereRemplacant
            // 
            this.metroComboBoxEtagereRemplacant.Enabled = false;
            this.metroComboBoxEtagereRemplacant.FormattingEnabled = true;
            this.metroComboBoxEtagereRemplacant.ItemHeight = 23;
            this.metroComboBoxEtagereRemplacant.Location = new System.Drawing.Point(140, 31);
            this.metroComboBoxEtagereRemplacant.Name = "metroComboBoxEtagereRemplacant";
            this.metroComboBoxEtagereRemplacant.Size = new System.Drawing.Size(125, 29);
            this.metroComboBoxEtagereRemplacant.TabIndex = 19;
            this.metroComboBoxEtagereRemplacant.UseSelectable = true;
            this.metroComboBoxEtagereRemplacant.SelectedIndexChanged += new System.EventHandler(this.metroComboBoxEtagereRemplacant_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(26, 35);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(108, 19);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "N° de L\'étagère :";
            // 
            // erreurEtagereRemplacant
            // 
            this.erreurEtagereRemplacant.Image = ((System.Drawing.Image)(resources.GetObject("erreurEtagereRemplacant.Image")));
            this.erreurEtagereRemplacant.Location = new System.Drawing.Point(269, 35);
            this.erreurEtagereRemplacant.Name = "erreurEtagereRemplacant";
            this.erreurEtagereRemplacant.Size = new System.Drawing.Size(23, 21);
            this.erreurEtagereRemplacant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.erreurEtagereRemplacant.TabIndex = 23;
            this.erreurEtagereRemplacant.TabStop = false;
            this.erreurEtagereRemplacant.Visible = false;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(329, 35);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(95, 19);
            this.metroLabel5.TabIndex = 24;
            this.metroLabel5.Text = "Code du livre :";
            // 
            // metroComboBoxLivreRemplacant
            // 
            this.metroComboBoxLivreRemplacant.Enabled = false;
            this.metroComboBoxLivreRemplacant.FormattingEnabled = true;
            this.metroComboBoxLivreRemplacant.ItemHeight = 23;
            this.metroComboBoxLivreRemplacant.Location = new System.Drawing.Point(430, 31);
            this.metroComboBoxLivreRemplacant.Name = "metroComboBoxLivreRemplacant";
            this.metroComboBoxLivreRemplacant.Size = new System.Drawing.Size(125, 29);
            this.metroComboBoxLivreRemplacant.TabIndex = 25;
            this.metroComboBoxLivreRemplacant.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroComboBoxEtagereRetire);
            this.groupBox1.Controls.Add(this.erreurEtagereRetire);
            this.groupBox1.Controls.Add(this.erreurLivreRetire);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroComboBoxLivreRetire);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(124, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 85);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Livre Retiré";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(26, 37);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(108, 19);
            this.metroLabel4.TabIndex = 34;
            this.metroLabel4.Text = "N° de L\'étagère :";
            // 
            // metroComboBoxEtagereRetire
            // 
            this.metroComboBoxEtagereRetire.FormattingEnabled = true;
            this.metroComboBoxEtagereRetire.ItemHeight = 23;
            this.metroComboBoxEtagereRetire.Location = new System.Drawing.Point(140, 33);
            this.metroComboBoxEtagereRetire.Name = "metroComboBoxEtagereRetire";
            this.metroComboBoxEtagereRetire.Size = new System.Drawing.Size(125, 29);
            this.metroComboBoxEtagereRetire.TabIndex = 35;
            this.metroComboBoxEtagereRetire.UseSelectable = true;
            this.metroComboBoxEtagereRetire.SelectedIndexChanged += new System.EventHandler(this.metroComboBoxEtagereRetire_SelectedIndexChanged);
            // 
            // erreurEtagereRetire
            // 
            this.erreurEtagereRetire.Image = ((System.Drawing.Image)(resources.GetObject("erreurEtagereRetire.Image")));
            this.erreurEtagereRetire.Location = new System.Drawing.Point(269, 37);
            this.erreurEtagereRetire.Name = "erreurEtagereRetire";
            this.erreurEtagereRetire.Size = new System.Drawing.Size(23, 21);
            this.erreurEtagereRetire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.erreurEtagereRetire.TabIndex = 36;
            this.erreurEtagereRetire.TabStop = false;
            this.erreurEtagereRetire.Visible = false;
            // 
            // erreurLivreRetire
            // 
            this.erreurLivreRetire.Image = ((System.Drawing.Image)(resources.GetObject("erreurLivreRetire.Image")));
            this.erreurLivreRetire.Location = new System.Drawing.Point(559, 37);
            this.erreurLivreRetire.Name = "erreurLivreRetire";
            this.erreurLivreRetire.Size = new System.Drawing.Size(23, 21);
            this.erreurLivreRetire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.erreurLivreRetire.TabIndex = 39;
            this.erreurLivreRetire.TabStop = false;
            this.erreurLivreRetire.Visible = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(329, 37);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 19);
            this.metroLabel1.TabIndex = 37;
            this.metroLabel1.Text = "Code du livre :";
            // 
            // metroComboBoxLivreRetire
            // 
            this.metroComboBoxLivreRetire.Enabled = false;
            this.metroComboBoxLivreRetire.FormattingEnabled = true;
            this.metroComboBoxLivreRetire.ItemHeight = 23;
            this.metroComboBoxLivreRetire.Location = new System.Drawing.Point(430, 33);
            this.metroComboBoxLivreRetire.Name = "metroComboBoxLivreRetire";
            this.metroComboBoxLivreRetire.Size = new System.Drawing.Size(125, 29);
            this.metroComboBoxLivreRetire.TabIndex = 38;
            this.metroComboBoxLivreRetire.UseSelectable = true;
            // 
            // RemplacerLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.metroPanelRemplacerLivre);
            this.MaximumSize = new System.Drawing.Size(854, 377);
            this.MinimumSize = new System.Drawing.Size(854, 377);
            this.Name = "RemplacerLivre";
            this.Size = new System.Drawing.Size(854, 377);
            this.metroPanelRemplacerLivre.ResumeLayout(false);
            this.metroPanelRemplacerLivre.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erreurLivreRemplacant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erreurEtagereRemplacant)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erreurEtagereRetire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erreurLivreRetire)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanelRemplacerLivre;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox metroComboBoxEtagereRemplacant;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Button buttonRemplacer;
        private System.Windows.Forms.PictureBox erreurEtagereRemplacant;
        private MetroFramework.Controls.MetroComboBox metroComboBoxLivreRemplacant;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.PictureBox erreurLivreRetire;
        private MetroFramework.Controls.MetroComboBox metroComboBoxLivreRetire;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox erreurEtagereRetire;
        private MetroFramework.Controls.MetroComboBox metroComboBoxEtagereRetire;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox erreurLivreRemplacant;
    }
}
