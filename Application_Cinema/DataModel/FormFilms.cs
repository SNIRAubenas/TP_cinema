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
            dataGridView1.DataSource = dbContext.Films.Local.ToBindingList();

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void ajouter_Click(object sender, EventArgs e)
        {

        }

        private void modifier_Click(object sender, EventArgs e)
        {

        }

        private void supprimer_Click(object sender, EventArgs e)
        {

        }
    }
}
