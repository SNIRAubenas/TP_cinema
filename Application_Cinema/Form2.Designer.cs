namespace Application_Cinema
{
    partial class Form2
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
            menuStrip1 = new MenuStrip();
            acteurToolStripMenuItem = new ToolStripMenuItem();
            acteurToolStripMenuItem1 = new ToolStripMenuItem();
            directeurToolStripMenuItem = new ToolStripMenuItem();
            nouvelleActeurToolStripMenuItem = new ToolStripMenuItem();
            nouveauDirecteurToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            filmToolStripMenuItem = new ToolStripMenuItem();
            nouveauFilmToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { acteurToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // acteurToolStripMenuItem
            // 
            acteurToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { filmToolStripMenuItem, acteurToolStripMenuItem1, directeurToolStripMenuItem, nouveauFilmToolStripMenuItem, nouvelleActeurToolStripMenuItem, nouveauDirecteurToolStripMenuItem, quitterToolStripMenuItem });
            acteurToolStripMenuItem.Name = "acteurToolStripMenuItem";
            acteurToolStripMenuItem.Size = new Size(141, 20);
            acteurToolStripMenuItem.Text = "Menu Acteur/Directeur";
            // 
            // acteurToolStripMenuItem1
            // 
            acteurToolStripMenuItem1.Name = "acteurToolStripMenuItem1";
            acteurToolStripMenuItem1.Size = new Size(180, 22);
            acteurToolStripMenuItem1.Text = "Acteur";
            acteurToolStripMenuItem1.Click += acteurToolStripMenuItem1_Click;
            // 
            // directeurToolStripMenuItem
            // 
            directeurToolStripMenuItem.Name = "directeurToolStripMenuItem";
            directeurToolStripMenuItem.Size = new Size(180, 22);
            directeurToolStripMenuItem.Text = "Directeur";
            directeurToolStripMenuItem.Click += directeurToolStripMenuItem_Click;
            // 
            // nouvelleActeurToolStripMenuItem
            // 
            nouvelleActeurToolStripMenuItem.Name = "nouvelleActeurToolStripMenuItem";
            nouvelleActeurToolStripMenuItem.Size = new Size(180, 22);
            nouvelleActeurToolStripMenuItem.Text = "Nouvelle acteur";
            nouvelleActeurToolStripMenuItem.Click += nouvelleActeurToolStripMenuItem_Click;
            // 
            // nouveauDirecteurToolStripMenuItem
            // 
            nouveauDirecteurToolStripMenuItem.Name = "nouveauDirecteurToolStripMenuItem";
            nouveauDirecteurToolStripMenuItem.Size = new Size(180, 22);
            nouveauDirecteurToolStripMenuItem.Text = "Nouveau directeur";
            nouveauDirecteurToolStripMenuItem.Click += nouveauDirecteurToolStripMenuItem_Click;
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(180, 22);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // filmToolStripMenuItem
            // 
            filmToolStripMenuItem.Name = "filmToolStripMenuItem";
            filmToolStripMenuItem.Size = new Size(180, 22);
            filmToolStripMenuItem.Text = "Film";
            filmToolStripMenuItem.Click += filmToolStripMenuItem_Click;
            // 
            // nouveauFilmToolStripMenuItem
            // 
            nouveauFilmToolStripMenuItem.Name = "nouveauFilmToolStripMenuItem";
            nouveauFilmToolStripMenuItem.Size = new Size(180, 22);
            nouveauFilmToolStripMenuItem.Text = "Nouveau Film";
            nouveauFilmToolStripMenuItem.Click += nouveauFilmToolStripMenuItem_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Form2";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem acteurToolStripMenuItem;
        private ToolStripMenuItem acteurToolStripMenuItem1;
        private ToolStripMenuItem directeurToolStripMenuItem;
        private ToolStripMenuItem nouvelleActeurToolStripMenuItem;
        private ToolStripMenuItem nouveauDirecteurToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem filmToolStripMenuItem;
        private ToolStripMenuItem nouveauFilmToolStripMenuItem;
    }
}