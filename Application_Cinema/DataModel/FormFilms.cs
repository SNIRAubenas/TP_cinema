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
    public partial class FormFilms : Form
    {
        private DirectorfilmactorContext? dbContext;
        public FormFilms()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new DirectorfilmactorContext();

            this.dbContext.Database.EnsureCreated();
            this.dbContext.Films.Load();
            dataGridFilms.DataSource = dbContext.Films.Local.ToBindingList();

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            string titre = Microsoft.VisualBasic.Interaction.InputBox("Titre du film :", "Ajouter un Film");
            string anneeStr = Microsoft.VisualBasic.Interaction.InputBox("Année de sortie :", "Ajouter un Film");
            string longueurStr = Microsoft.VisualBasic.Interaction.InputBox("Durée du film (format hh:mm) :", "Ajouter un Film");
            string resume = Microsoft.VisualBasic.Interaction.InputBox("Résumé du film :", "Ajouter un Film");

            if (string.IsNullOrWhiteSpace(titre) ||!int.TryParse(anneeStr, out int annee) || !TimeSpan.TryParseExact(longueurStr, @"hh\:mm", null, out TimeSpan longueur) ||  string.IsNullOrWhiteSpace(resume))
            {
                MessageBox.Show("Veuillez remplir correctement tous les champs.\nAssurez-vous que l'année est un nombre valide et la durée au format hh:mm.");
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Fichiers d'image|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Veuillez sélectionner une image pour le poster.");
                return;
            }

            byte[] imageBytes;
            using (var stream = new System.IO.MemoryStream())
            {
                Image image = Image.FromFile(openFileDialog.FileName);
                image.Save(stream, image.RawFormat); 
                imageBytes = stream.ToArray(); 
            }

            var nouveauFilm = new Film()
            {
                Title = titre,
                Year = annee,  
                Length = longueur,  
                Summary = resume,
                Poster = imageBytes 
            };

            this.dbContext.Films.Add(nouveauFilm);

            this.dbContext.SaveChanges();

            dataGridFilms.DataSource = dbContext.Films.Local.ToBindingList();
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            if (dataGridFilms.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner un film à modifier.");
                return;
            }

            var filmSelectionne = (Film)dataGridFilms.CurrentRow.DataBoundItem;

            string nouveauTitre = Microsoft.VisualBasic.Interaction.InputBox("Nouveau titre du film :", "Modifier un Film", filmSelectionne.Title);
            string nouvelleAnneeStr = Microsoft.VisualBasic.Interaction.InputBox("Nouvelle année de sortie :", "Modifier un Film", filmSelectionne.Year.ToString());
            string nouvelleLongueurStr = Microsoft.VisualBasic.Interaction.InputBox("Nouvelle durée du film (format hh:mm) :", "Modifier un Film", filmSelectionne.Length.ToString());
            string nouveauResume = Microsoft.VisualBasic.Interaction.InputBox("Nouveau résumé du film :", "Modifier un Film", filmSelectionne.Summary);

            if (string.IsNullOrWhiteSpace(nouveauTitre) ||!int.TryParse(nouvelleAnneeStr, out int nouvelleAnnee) || !TimeSpan.TryParseExact(nouvelleLongueurStr, @"hh\:mm", null, out TimeSpan nouvelleLongueur) ||string.IsNullOrWhiteSpace(nouveauResume))
            {
                MessageBox.Show("Veuillez remplir correctement tous les champs.\nAssurez-vous que l'année est un nombre valide et la durée au format hh:mm.");
                return;
            }

            DialogResult result = MessageBox.Show("Souhaitez-vous changer le poster ?", "Modifier le Poster", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Fichiers d'image|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var stream = new System.IO.MemoryStream())
                    {
                        Image image = Image.FromFile(openFileDialog.FileName);
                        image.Save(stream, image.RawFormat);
                        filmSelectionne.Poster = stream.ToArray(); 
                    }
                }
            }

            filmSelectionne.Title = nouveauTitre;
            filmSelectionne.Year = nouvelleAnnee;
            filmSelectionne.Length = nouvelleLongueur; 
            filmSelectionne.Summary = nouveauResume;

            this.dbContext.SaveChanges();

            dataGridFilms.Refresh();
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if (dataGridFilms.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner un film à supprimer.");
                return;
            }

            var filmSelectionne = (Film)dataGridFilms.CurrentRow.DataBoundItem;

            DialogResult result = MessageBox.Show($"Êtes-vous sûr de vouloir supprimer le film '{filmSelectionne.Title}' ?", "Confirmer la suppression", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.dbContext.Films.Remove(filmSelectionne);

                this.dbContext.SaveChanges();

                dataGridFilms.DataSource = dbContext.Films.Local.ToBindingList();
            }
        }

        private void quitterFilm_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
