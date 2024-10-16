using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application_Cinema.DataModel;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Application_Cinema.DataModel
{
    public partial class FormActeurs : Form
    {
        private DirectorfilmactorContext? dbContext;
        public FormActeurs()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new DirectorfilmactorContext();

            this.dbContext.Database.EnsureCreated();
            this.dbContext.Actors.Load();

            dataGridView1.DataSource = dbContext.Actors.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }
        private void ajouterActeur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            string nom = Microsoft.VisualBasic.Interaction.InputBox("Nom de l'acteur :", "Ajouter un Acteur");
            // Créer une nouvelle instance de directeur
            var nouvelActeur = new Actor()
            {
                Name = nom

            };


            // Ajouter le nouveau directeur au contexte
            this.dbContext.Actors.Add(nouvelActeur);

            // Sauvegarder les changements dans la base de données
            this.dbContext.SaveChanges();

            // Mettre à jour le DataGridView automatiquement
            dataGridView1.DataSource = dbContext.Actors.Local.ToBindingList();
        }

        private void modifierActeur_Click(object sender, EventArgs e)
        {

        }

        private void supprimerActeur_Click(object sender, EventArgs e)
        {

        }

        private void quitterActeur_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
