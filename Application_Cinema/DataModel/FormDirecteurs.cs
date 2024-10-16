using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application_Cinema.DataModel;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Application_Cinema.DataModel
{
    public partial class FormDirecteurs : Form
    {
        private DirectorfilmactorContext? dbContext;


        public FormDirecteurs()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new DirectorfilmactorContext();


            this.dbContext.Database.EnsureCreated();
            this.dbContext.Directors.Load();
            dataGridView1.DataSource = dbContext.Directors.Local.ToBindingList();

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void ajouterDirecteur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            string nom = Microsoft.VisualBasic.Interaction.InputBox("Nom du directeur :", "Ajouter un Directeur");
            // Créer une nouvelle instance de directeur
            var nouveauDirecteur = new Director()
            {
                Name = nom

            };


            // Ajouter le nouveau directeur au contexte
            this.dbContext.Directors.Add(nouveauDirecteur);

            // Sauvegarder les changements dans la base de données
            this.dbContext.SaveChanges();

            // Mettre à jour le DataGridView automatiquement
            dataGridView1.DataSource = dbContext.Directors.Local.ToBindingList();
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Sauvegarder les changements dans la base de données après l'édition d'une cellule
            this.dbContext.SaveChanges();
        }

        private void modifierDirecteur_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var directeurSelectionne = dataGridView1.SelectedRows[0].DataBoundItem as Director;

                if (directeurSelectionne != null)
                {
                    string nouveauNom = Microsoft.VisualBasic.Interaction.InputBox("Modifier le nom du directeur :", "Modifier Directeur", directeurSelectionne.Name);

                    if (!string.IsNullOrWhiteSpace(nouveauNom))
                    {
                        directeurSelectionne.Name = nouveauNom;

                        this.dbContext.SaveChanges();
                        dataGridView1.DataSource = dbContext.Actors.Local.ToBindingList();
                    }
                    else
                    {
                        MessageBox.Show("Le nom du directeur ne peut pas être vide.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un directeur à modifier.");
            }
        }

        private void supprimerDirecteur_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var directeurSelectionne = dataGridView1.SelectedRows[0].DataBoundItem as Director;

                if (directeurSelectionne != null)
                {
                    DialogResult resultat = MessageBox.Show($"Voulez-vous vraiment supprimer l'acteur {directeurSelectionne.Name} ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultat == DialogResult.Yes)
                    {
                        this.dbContext.Directors.Remove(directeurSelectionne);
                        this.dbContext.SaveChanges();
                        dataGridView1.DataSource = dbContext.Actors.Local.ToBindingList();
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un directeur à supprimer.");
            }
        }

        private void quitterDirecteur_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
