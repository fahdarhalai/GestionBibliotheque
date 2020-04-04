namespace GestionLivres
{
    partial class Lister
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanelLister = new MetroFramework.Controls.MetroPanel();
            this.buttonLister = new System.Windows.Forms.Button();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxEtagere = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TITRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ETAGERE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanelLister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanelLister
            // 
            this.metroPanelLister.Controls.Add(this.buttonLister);
            this.metroPanelLister.Controls.Add(this.metroLabel5);
            this.metroPanelLister.Controls.Add(this.metroComboBoxEtagere);
            this.metroPanelLister.Controls.Add(this.metroLabel1);
            this.metroPanelLister.Controls.Add(this.dataGridView);
            this.metroPanelLister.HorizontalScrollbarBarColor = true;
            this.metroPanelLister.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelLister.HorizontalScrollbarSize = 10;
            this.metroPanelLister.Location = new System.Drawing.Point(0, 0);
            this.metroPanelLister.Name = "metroPanelLister";
            this.metroPanelLister.Size = new System.Drawing.Size(854, 377);
            this.metroPanelLister.TabIndex = 4;
            this.metroPanelLister.VerticalScrollbarBarColor = true;
            this.metroPanelLister.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelLister.VerticalScrollbarSize = 10;
            // 
            // buttonLister
            // 
            this.buttonLister.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLister.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonLister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonLister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonLister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLister.Location = new System.Drawing.Point(550, 65);
            this.buttonLister.Name = "buttonLister";
            this.buttonLister.Size = new System.Drawing.Size(125, 29);
            this.buttonLister.TabIndex = 6;
            this.buttonLister.Text = "Lister";
            this.buttonLister.UseVisualStyleBackColor = false;
            this.buttonLister.Click += new System.EventHandler(this.buttonLister_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(77, 20);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(185, 25);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Lister la bibliothèque :";
            // 
            // metroComboBoxEtagere
            // 
            this.metroComboBoxEtagere.FormattingEnabled = true;
            this.metroComboBoxEtagere.ItemHeight = 23;
            this.metroComboBoxEtagere.Location = new System.Drawing.Point(328, 65);
            this.metroComboBoxEtagere.Name = "metroComboBoxEtagere";
            this.metroComboBoxEtagere.Size = new System.Drawing.Size(125, 29);
            this.metroComboBoxEtagere.TabIndex = 4;
            this.metroComboBoxEtagere.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(177, 69);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(130, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Choisir une étagère :";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TITRE,
            this.CODE,
            this.PRIX,
            this.ETAGERE});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView.Location = new System.Drawing.Point(124, 120);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.Size = new System.Drawing.Size(606, 233);
            this.dataGridView.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.DataPropertyName = "id";
            this.ID.FillWeight = 25F;
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 48;
            // 
            // TITRE
            // 
            this.TITRE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TITRE.DataPropertyName = "titre";
            this.TITRE.FillWeight = 150F;
            this.TITRE.Frozen = true;
            this.TITRE.HeaderText = "TITRE";
            this.TITRE.Name = "TITRE";
            this.TITRE.ReadOnly = true;
            this.TITRE.Width = 251;
            // 
            // CODE
            // 
            this.CODE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODE.DataPropertyName = "code";
            this.CODE.FillWeight = 50F;
            this.CODE.HeaderText = "CODE";
            this.CODE.Name = "CODE";
            this.CODE.ReadOnly = true;
            // 
            // PRIX
            // 
            this.PRIX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRIX.DataPropertyName = "prix";
            this.PRIX.FillWeight = 50F;
            this.PRIX.HeaderText = "PRIX";
            this.PRIX.Name = "PRIX";
            this.PRIX.ReadOnly = true;
            // 
            // ETAGERE
            // 
            this.ETAGERE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ETAGERE.DataPropertyName = "numero";
            this.ETAGERE.FillWeight = 50F;
            this.ETAGERE.HeaderText = "ETAGERE";
            this.ETAGERE.Name = "ETAGERE";
            this.ETAGERE.ReadOnly = true;
            // 
            // Lister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.metroPanelLister);
            this.MaximumSize = new System.Drawing.Size(854, 377);
            this.MinimumSize = new System.Drawing.Size(854, 377);
            this.Name = "Lister";
            this.Size = new System.Drawing.Size(854, 377);
            this.metroPanelLister.ResumeLayout(false);
            this.metroPanelLister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanelLister;
        private System.Windows.Forms.Button buttonLister;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox metroComboBoxEtagere;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ETAGERE;
    }
}
