namespace Application_Cinema.DataModel
{
    partial class FormActeurs
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
            dataGridView1 = new DataGridView();
            actorBindingSource = new BindingSource(components);
            ajouterActeur = new Button();
            modifierActeur = new Button();
            supprimerActeur = new Button();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)actorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn });
            dataGridView1.DataSource = actorBindingSource;
            dataGridView1.Location = new Point(213, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(243, 424);
            dataGridView1.TabIndex = 0;
            // 
            // actorBindingSource
            // 
            actorBindingSource.DataSource = typeof(Actor);
            // 
            // ajouterActeur
            // 
            ajouterActeur.Location = new Point(565, 132);
            ajouterActeur.Name = "ajouterActeur";
            ajouterActeur.Size = new Size(75, 23);
            ajouterActeur.TabIndex = 1;
            ajouterActeur.Text = "Ajouter";
            ajouterActeur.UseVisualStyleBackColor = true;
            ajouterActeur.Click += ajouterActeur_Click;
            // 
            // modifierActeur
            // 
            modifierActeur.Location = new Point(565, 192);
            modifierActeur.Name = "modifierActeur";
            modifierActeur.Size = new Size(75, 23);
            modifierActeur.TabIndex = 2;
            modifierActeur.Text = "Modifier";
            modifierActeur.UseVisualStyleBackColor = true;
            modifierActeur.Click += modifierActeur_Click;
            // 
            // supprimerActeur
            // 
            supprimerActeur.Location = new Point(565, 260);
            supprimerActeur.Name = "supprimerActeur";
            supprimerActeur.Size = new Size(75, 23);
            supprimerActeur.TabIndex = 3;
            supprimerActeur.Text = "Supprimer";
            supprimerActeur.UseVisualStyleBackColor = true;
            supprimerActeur.Click += supprimerActeur_Click;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormActeurs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(supprimerActeur);
            Controls.Add(modifierActeur);
            Controls.Add(ajouterActeur);
            Controls.Add(dataGridView1);
            Name = "FormActeurs";
            Text = "FormActeur";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)actorBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource actorBindingSource;
        private Button ajouterActeur;
        private Button modifierActeur;
        private Button supprimerActeur;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}