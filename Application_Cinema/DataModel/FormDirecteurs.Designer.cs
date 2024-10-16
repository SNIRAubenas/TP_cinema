namespace Application_Cinema.DataModel
{
    partial class FormDirecteurs
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
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            directorBindingSource = new BindingSource(components);
            ajouterDirecteur = new Button();
            modifierDirecteur = new Button();
            supprimerDirecteur = new Button();
            quitterDirecteur = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)directorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn });
            dataGridView1.DataSource = directorBindingSource;
            dataGridView1.Location = new Point(12, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(591, 389);
            dataGridView1.TabIndex = 0;
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
            // directorBindingSource
            // 
            directorBindingSource.DataSource = typeof(Director);
            // 
            // ajouterDirecteur
            // 
            ajouterDirecteur.Location = new Point(627, 97);
            ajouterDirecteur.Name = "ajouterDirecteur";
            ajouterDirecteur.Size = new Size(75, 23);
            ajouterDirecteur.TabIndex = 1;
            ajouterDirecteur.Text = "Ajouter";
            ajouterDirecteur.UseVisualStyleBackColor = true;
            ajouterDirecteur.Click += ajouterDirecteur_Click;
            // 
            // modifierDirecteur
            // 
            modifierDirecteur.Location = new Point(627, 155);
            modifierDirecteur.Name = "modifierDirecteur";
            modifierDirecteur.Size = new Size(75, 23);
            modifierDirecteur.TabIndex = 2;
            modifierDirecteur.Text = "Modifier";
            modifierDirecteur.UseVisualStyleBackColor = true;
            modifierDirecteur.Click += modifierDirecteur_Click;
            // 
            // supprimerDirecteur
            // 
            supprimerDirecteur.Location = new Point(627, 218);
            supprimerDirecteur.Name = "supprimerDirecteur";
            supprimerDirecteur.Size = new Size(75, 23);
            supprimerDirecteur.TabIndex = 3;
            supprimerDirecteur.Text = "Supprimer";
            supprimerDirecteur.UseVisualStyleBackColor = true;
            supprimerDirecteur.Click += supprimerDirecteur_Click;
            // 
            // quitterDirecteur
            // 
            quitterDirecteur.Location = new Point(627, 359);
            quitterDirecteur.Name = "quitterDirecteur";
            quitterDirecteur.Size = new Size(75, 23);
            quitterDirecteur.TabIndex = 4;
            quitterDirecteur.Text = "Quitter";
            quitterDirecteur.UseVisualStyleBackColor = true;
            quitterDirecteur.Click += quitterDirecteur_Click;
            // 
            // FormDirecteurs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(quitterDirecteur);
            Controls.Add(supprimerDirecteur);
            Controls.Add(modifierDirecteur);
            Controls.Add(ajouterDirecteur);
            Controls.Add(dataGridView1);
            Name = "FormDirecteurs";
            Text = "FormDirecteurs";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)directorBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn filmdirectorsDataGridViewTextBoxColumn;
        private BindingSource directorBindingSource;
        private Button ajouterDirecteur;
        private Button modifierDirecteur;
        private Button supprimerDirecteur;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private Button quitterDirecteur;
    }
}