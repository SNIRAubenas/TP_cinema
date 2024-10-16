﻿namespace Application_Cinema.DataModel
{
    partial class FormFilms
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
            dataGridFilms = new DataGridView();
            filmBindingSource = new BindingSource(components);
            ajouterFilm = new Button();
            modifierFilm = new Button();
            supprimerFilm = new Button();
            quitterFilm = new Button();
            acteurDirecteur = new Button();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lengthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            summaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            posterDataGridViewImageColumn = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridFilms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filmBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridFilms
            // 
            dataGridFilms.AutoGenerateColumns = false;
            dataGridFilms.BackgroundColor = SystemColors.ControlLightLight;
            dataGridFilms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridFilms.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, yearDataGridViewTextBoxColumn, lengthDataGridViewTextBoxColumn, summaryDataGridViewTextBoxColumn, posterDataGridViewImageColumn });
            dataGridFilms.DataSource = filmBindingSource;
            dataGridFilms.Location = new Point(12, 12);
            dataGridFilms.Name = "dataGridFilms";
            dataGridFilms.Size = new Size(1070, 544);
            dataGridFilms.TabIndex = 0;
            // 
            // filmBindingSource
            // 
            filmBindingSource.DataSource = typeof(Film);
            // 
            // ajouterFilm
            // 
            ajouterFilm.Location = new Point(1086, 99);
            ajouterFilm.Name = "ajouterFilm";
            ajouterFilm.Size = new Size(75, 23);
            ajouterFilm.TabIndex = 1;
            ajouterFilm.Text = "Ajouter";
            ajouterFilm.UseVisualStyleBackColor = true;
            ajouterFilm.Click += ajouter_Click;
            // 
            // modifierFilm
            // 
            modifierFilm.Location = new Point(1086, 157);
            modifierFilm.Name = "modifierFilm";
            modifierFilm.Size = new Size(75, 23);
            modifierFilm.TabIndex = 2;
            modifierFilm.Text = "Modifier";
            modifierFilm.UseVisualStyleBackColor = true;
            modifierFilm.Click += modifier_Click;
            // 
            // supprimerFilm
            // 
            supprimerFilm.Location = new Point(1086, 227);
            supprimerFilm.Name = "supprimerFilm";
            supprimerFilm.Size = new Size(75, 23);
            supprimerFilm.TabIndex = 3;
            supprimerFilm.Text = "Supprimer";
            supprimerFilm.UseVisualStyleBackColor = true;
            supprimerFilm.Click += supprimer_Click;
            // 
            // quitterFilm
            // 
            quitterFilm.Location = new Point(1086, 443);
            quitterFilm.Name = "quitterFilm";
            quitterFilm.Size = new Size(75, 23);
            quitterFilm.TabIndex = 4;
            quitterFilm.Text = "Quitter";
            quitterFilm.UseVisualStyleBackColor = true;
            quitterFilm.Click += quitterFilm_Click;
            // 
            // acteurDirecteur
            // 
            acteurDirecteur.Location = new Point(1086, 313);
            acteurDirecteur.Name = "acteurDirecteur";
            acteurDirecteur.Size = new Size(103, 41);
            acteurDirecteur.TabIndex = 5;
            acteurDirecteur.Text = "Acteur et Directeur";
            acteurDirecteur.UseVisualStyleBackColor = true;
            acteurDirecteur.Click += acteurDirecteur_Click;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            yearDataGridViewTextBoxColumn.HeaderText = "Year";
            yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            yearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            lengthDataGridViewTextBoxColumn.HeaderText = "Length";
            lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            lengthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // summaryDataGridViewTextBoxColumn
            // 
            summaryDataGridViewTextBoxColumn.DataPropertyName = "Summary";
            summaryDataGridViewTextBoxColumn.HeaderText = "Summary";
            summaryDataGridViewTextBoxColumn.Name = "summaryDataGridViewTextBoxColumn";
            summaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // posterDataGridViewImageColumn
            // 
            posterDataGridViewImageColumn.DataPropertyName = "Poster";
            posterDataGridViewImageColumn.HeaderText = "Poster";
            posterDataGridViewImageColumn.Name = "posterDataGridViewImageColumn";
            posterDataGridViewImageColumn.ReadOnly = true;
            // 
            // FormFilms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 568);
            Controls.Add(acteurDirecteur);
            Controls.Add(quitterFilm);
            Controls.Add(supprimerFilm);
            Controls.Add(modifierFilm);
            Controls.Add(ajouterFilm);
            Controls.Add(dataGridFilms);
            Name = "FormFilms";
            Text = "FormFilms";
            ((System.ComponentModel.ISupportInitialize)dataGridFilms).EndInit();
            ((System.ComponentModel.ISupportInitialize)filmBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridFilms;
        private DataGridViewTextBoxColumn filmactorsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn filmdirectorsDataGridViewTextBoxColumn;
        private BindingSource filmBindingSource;
        private Button ajouterFilm;
        private Button modifierFilm;
        private Button supprimerFilm;
        private Button quitterFilm;
        private Button acteurDirecteur;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn summaryDataGridViewTextBoxColumn;
        private DataGridViewImageColumn posterDataGridViewImageColumn;
    }
}