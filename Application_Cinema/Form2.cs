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
using CinemaLib;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Application_Cinema
{
    public partial class Form2 : Form

    {
        private DirectorfilmactorContext? dbContext;

        public Form2(FilmAvecSauvegarde films)
        {
            InitializeComponent();

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new DirectorfilmactorContext();

            // Si on enlève le commentaire ci-dessous, la BDD est supprimée avant le démarrage.
            // this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();
            this.dbContext.Films.Load();

            this.filmBindingSource.DataSource = dbContext.Films.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void acteurToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void directeurToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nouvelleActeurToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nouveauDirecteurToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void filmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nouveauFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Film_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dbContext != null)
            {
                var film = (Film)this.Film.CurrentRow.DataBoundItem;

                if (film != null)
                {
                    this.dbContext.Entry(film).Collection(e => e.Title).Load();
                }
            }
        }

        private void sauvegarderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dbContext!.SaveChanges();

            this.Film.Refresh();
            this.acteur.Refresh();
        }
    }
}
