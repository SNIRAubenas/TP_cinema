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
    public partial class Form1 : Form

    {
        private DirectorfilmactorContext? dbContext;
        public Form1()
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

            //this.filmBindingSource.DataSource = dbContext.Films.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void acteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormActeurs formActeurs = new FormActeurs();
            formActeurs.Show();
        }

        private void directeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDirecteurs formDirecteurs = new FormDirecteurs();
            formDirecteurs.Show();
        }

        private void filmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFilms formFilms = new FormFilms();
            formFilms.Show();
        }
        //private void sauvegarderToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    this.dbContext!.SaveChanges();

        //    this.Film.Refresh();
        //    this.acteur.Refresh();
        //}
    }
}
