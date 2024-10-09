namespace Application_Cinema
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            acteurToolStripMenuItem = new ToolStripMenuItem();
            filmToolStripMenuItem = new ToolStripMenuItem();
            acteurToolStripMenuItem1 = new ToolStripMenuItem();
            directeurToolStripMenuItem = new ToolStripMenuItem();
            nouveauFilmToolStripMenuItem = new ToolStripMenuItem();
            nouvelleActeurToolStripMenuItem = new ToolStripMenuItem();
            nouveauDirecteurToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            Film = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            filmBindingSource = new BindingSource(components);
            acteur = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            actorBindingSource1 = new BindingSource(components);
            actorBindingSource = new BindingSource(components);
            directorBindingSource = new BindingSource(components);
            directorBindingSource1 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            filmdirectorsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            directorBindingSource2 = new BindingSource(components);
            sauvegarderToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Film).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filmBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)acteur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)actorBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)actorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)directorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)directorBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)directorBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { acteurToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // acteurToolStripMenuItem
            // 
            acteurToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { filmToolStripMenuItem, acteurToolStripMenuItem1, directeurToolStripMenuItem, nouveauFilmToolStripMenuItem, nouvelleActeurToolStripMenuItem, nouveauDirecteurToolStripMenuItem, sauvegarderToolStripMenuItem, quitterToolStripMenuItem });
            acteurToolStripMenuItem.Name = "acteurToolStripMenuItem";
            acteurToolStripMenuItem.Size = new Size(97, 20);
            acteurToolStripMenuItem.Text = "Menu complet";
            // 
            // filmToolStripMenuItem
            // 
            filmToolStripMenuItem.Name = "filmToolStripMenuItem";
            filmToolStripMenuItem.Size = new Size(180, 22);
            filmToolStripMenuItem.Text = "Film";
            filmToolStripMenuItem.Click += filmToolStripMenuItem_Click;
            // 
            // acteurToolStripMenuItem1
            // 
            acteurToolStripMenuItem1.Name = "acteurToolStripMenuItem1";
            acteurToolStripMenuItem1.Size = new Size(180, 22);
            acteurToolStripMenuItem1.Text = "Acteur";
            acteurToolStripMenuItem1.Click += acteurToolStripMenuItem1_Click;
            // 
            // directeurToolStripMenuItem
            // 
            directeurToolStripMenuItem.Name = "directeurToolStripMenuItem";
            directeurToolStripMenuItem.Size = new Size(180, 22);
            directeurToolStripMenuItem.Text = "Directeur";
            directeurToolStripMenuItem.Click += directeurToolStripMenuItem_Click;
            // 
            // nouveauFilmToolStripMenuItem
            // 
            nouveauFilmToolStripMenuItem.Name = "nouveauFilmToolStripMenuItem";
            nouveauFilmToolStripMenuItem.Size = new Size(180, 22);
            nouveauFilmToolStripMenuItem.Text = "Nouveau Film";
            nouveauFilmToolStripMenuItem.Click += nouveauFilmToolStripMenuItem_Click;
            // 
            // nouvelleActeurToolStripMenuItem
            // 
            nouvelleActeurToolStripMenuItem.Name = "nouvelleActeurToolStripMenuItem";
            nouvelleActeurToolStripMenuItem.Size = new Size(180, 22);
            nouvelleActeurToolStripMenuItem.Text = "Nouvelle acteur";
            nouvelleActeurToolStripMenuItem.Click += nouvelleActeurToolStripMenuItem_Click;
            // 
            // nouveauDirecteurToolStripMenuItem
            // 
            nouveauDirecteurToolStripMenuItem.Name = "nouveauDirecteurToolStripMenuItem";
            nouveauDirecteurToolStripMenuItem.Size = new Size(180, 22);
            nouveauDirecteurToolStripMenuItem.Text = "Nouveau directeur";
            nouveauDirecteurToolStripMenuItem.Click += nouveauDirecteurToolStripMenuItem_Click;
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(180, 22);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // Film
            // 
            Film.AutoGenerateColumns = false;
            Film.BackgroundColor = SystemColors.ButtonHighlight;
            Film.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Film.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn });
            Film.DataSource = filmBindingSource;
            Film.Location = new Point(26, 70);
            Film.Name = "Film";
            Film.Size = new Size(330, 170);
            Film.TabIndex = 1;
            Film.SelectionChanged += Film_SelectionChanged;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmBindingSource
            // 
            filmBindingSource.DataSource = typeof(DataModel.Film);
            // 
            // acteur
            // 
            acteur.AutoGenerateColumns = false;
            acteur.BackgroundColor = SystemColors.ButtonHighlight;
            acteur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            acteur.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn });
            acteur.DataSource = actorBindingSource1;
            acteur.Location = new Point(240, 256);
            acteur.Name = "acteur";
            acteur.Size = new Size(244, 163);
            acteur.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // actorBindingSource1
            // 
            actorBindingSource1.DataSource = typeof(DataModel.Actor);
            // 
            // actorBindingSource
            // 
            actorBindingSource.DataSource = typeof(DataModel.Actor);
            // 
            // directorBindingSource
            // 
            directorBindingSource.DataSource = typeof(DataModel.Director);
            // 
            // directorBindingSource1
            // 
            directorBindingSource1.DataSource = typeof(DataModel.Director);
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.HighlightText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn2, nameDataGridViewTextBoxColumn1, filmdirectorsDataGridViewTextBoxColumn });
            dataGridView1.DataSource = directorBindingSource;
            dataGridView1.Location = new Point(450, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(338, 150);
            dataGridView1.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn2.HeaderText = "Id";
            idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // filmdirectorsDataGridViewTextBoxColumn
            // 
            filmdirectorsDataGridViewTextBoxColumn.DataPropertyName = "Filmdirectors";
            filmdirectorsDataGridViewTextBoxColumn.HeaderText = "Filmdirectors";
            filmdirectorsDataGridViewTextBoxColumn.Name = "filmdirectorsDataGridViewTextBoxColumn";
            // 
            // directorBindingSource2
            // 
            directorBindingSource2.DataSource = typeof(DataModel.Director);
            // 
            // sauvegarderToolStripMenuItem
            // 
            sauvegarderToolStripMenuItem.Name = "sauvegarderToolStripMenuItem";
            sauvegarderToolStripMenuItem.Size = new Size(180, 22);
            sauvegarderToolStripMenuItem.Text = "Sauvegarder";
            sauvegarderToolStripMenuItem.Click += sauvegarderToolStripMenuItem_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(acteur);
            Controls.Add(Film);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Form2";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Film).EndInit();
            ((System.ComponentModel.ISupportInitialize)filmBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)acteur).EndInit();
            ((System.ComponentModel.ISupportInitialize)actorBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)actorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)directorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)directorBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)directorBindingSource2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem acteurToolStripMenuItem;
        private ToolStripMenuItem acteurToolStripMenuItem1;
        private ToolStripMenuItem directeurToolStripMenuItem;
        private ToolStripMenuItem nouvelleActeurToolStripMenuItem;
        private ToolStripMenuItem nouveauDirecteurToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem filmToolStripMenuItem;
        private ToolStripMenuItem nouveauFilmToolStripMenuItem;
        private DataGridView Film;
        private DataGridView acteur;
        private BindingSource filmBindingSource;
        private BindingSource actorBindingSource;
        private BindingSource actorBindingSource1;
        private BindingSource directorBindingSource;
        private BindingSource directorBindingSource1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn filmdirectorsDataGridViewTextBoxColumn;
        private BindingSource directorBindingSource2;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private ToolStripMenuItem sauvegarderToolStripMenuItem;
    }
}