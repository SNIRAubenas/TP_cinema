﻿namespace Application_Cinema
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            Menu_Film = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            acteurToolStripMenuItem = new ToolStripMenuItem();
            directeurToolStripMenuItem = new ToolStripMenuItem();
            filmToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { Menu_Film });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // Menu_Film
            // 
            Menu_Film.DropDownItems.AddRange(new ToolStripItem[] { acteurToolStripMenuItem, directeurToolStripMenuItem, filmToolStripMenuItem, quitterToolStripMenuItem });
            Menu_Film.Name = "Menu_Film";
            Menu_Film.Size = new Size(76, 20);
            Menu_Film.Text = "Menu Film";
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(180, 22);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // acteurToolStripMenuItem
            // 
            acteurToolStripMenuItem.Name = "acteurToolStripMenuItem";
            acteurToolStripMenuItem.Size = new Size(180, 22);
            acteurToolStripMenuItem.Text = "Acteur";
            acteurToolStripMenuItem.Click += acteurToolStripMenuItem_Click;
            // 
            // directeurToolStripMenuItem
            // 
            directeurToolStripMenuItem.Name = "directeurToolStripMenuItem";
            directeurToolStripMenuItem.Size = new Size(180, 22);
            directeurToolStripMenuItem.Text = "Directeur";
            directeurToolStripMenuItem.Click += directeurToolStripMenuItem_Click;
            // 
            // filmToolStripMenuItem
            // 
            filmToolStripMenuItem.Name = "filmToolStripMenuItem";
            filmToolStripMenuItem.Size = new Size(180, 22);
            filmToolStripMenuItem.Text = "Film";
            filmToolStripMenuItem.Click += filmToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem Menu_Film;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem acteurToolStripMenuItem;
        private ToolStripMenuItem directeurToolStripMenuItem;
        private ToolStripMenuItem filmToolStripMenuItem;
    }
}
