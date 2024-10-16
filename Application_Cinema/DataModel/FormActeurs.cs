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
            var nouvelActeur = new Actor()
            {
                Name = nom

            };


            this.dbContext.Actors.Add(nouvelActeur);
            this.dbContext.SaveChanges();
            dataGridView1.DataSource = dbContext.Actors.Local.ToBindingList();
        }

        private void modifierActeur_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var acteurSelectionne = dataGridView1.SelectedRows[0].DataBoundItem as Actor;

                if (acteurSelectionne != null)
                {
                    string nouveauNom = Microsoft.VisualBasic.Interaction.InputBox("Modifier le nom de l'acteur :", "Modifier Acteur", acteurSelectionne.Name);

                    if (!string.IsNullOrWhiteSpace(nouveauNom))
                    {
                        acteurSelectionne.Name = nouveauNom;

                        this.dbContext.SaveChanges();
                        dataGridView1.DataSource = dbContext.Actors.Local.ToBindingList();
                    }
                    else
                    {
                        MessageBox.Show("Le nom de l'acteur ne peut pas être vide.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un acteur à modifier.");
            }
        }

        private void supprimerActeur_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var acteurSelectionne = dataGridView1.SelectedRows[0].DataBoundItem as Actor;

                if (acteurSelectionne != null)
                {
                    DialogResult resultat = MessageBox.Show($"Voulez-vous vraiment supprimer l'acteur {acteurSelectionne.Name} ?","Confirmation de suppression",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                    if (resultat == DialogResult.Yes)
                    {
                        this.dbContext.Actors.Remove(acteurSelectionne);
                        this.dbContext.SaveChanges();
                        dataGridView1.DataSource = dbContext.Actors.Local.ToBindingList();
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un acteur à supprimer.");
            }
        }

        private void quitterActeur_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
