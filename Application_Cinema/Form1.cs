using CinemaLib;
using System;
using System.Windows.Forms;
namespace Application_Cinema

{
    public partial class Form1 : Form

    {
        public FilmAvecSauvegarde gestionnaireFilm;
        public Form1()
        {
            InitializeComponent();
            gestionnaireFilm = new FilmAvecSauvegarde("Server=localhost;Database=bddarticle;Uid=root;Pwd=;");
        }

        private void ouvrirFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 nouvellefenetre = new Form2(gestionnaireFilm);
            nouvellefenetre.Show();
     
        }

        private void creerFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
