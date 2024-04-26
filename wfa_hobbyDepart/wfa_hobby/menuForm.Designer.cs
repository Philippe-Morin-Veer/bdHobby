namespace wfa_hobby
{
    partial class menuForm
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
            étudiantToolStripMenuItem = new ToolStripMenuItem();
            ajoutToolStripMenuItem = new ToolStripMenuItem();
            modifierToolStripMenuItem = new ToolStripMenuItem();
            associerHobbyÀUnÉtudiantToolStripMenuItem = new ToolStripMenuItem();
            compterLesHobbyToolStripMenuItem = new ToolStripMenuItem();
            regexFormToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { étudiantToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1100, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // étudiantToolStripMenuItem
            // 
            étudiantToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ajoutToolStripMenuItem, modifierToolStripMenuItem, associerHobbyÀUnÉtudiantToolStripMenuItem, compterLesHobbyToolStripMenuItem, regexFormToolStripMenuItem });
            étudiantToolStripMenuItem.Name = "étudiantToolStripMenuItem";
            étudiantToolStripMenuItem.Size = new Size(79, 25);
            étudiantToolStripMenuItem.Text = "Étudiant";
            // 
            // ajoutToolStripMenuItem
            // 
            ajoutToolStripMenuItem.Name = "ajoutToolStripMenuItem";
            ajoutToolStripMenuItem.Size = new Size(281, 26);
            ajoutToolStripMenuItem.Text = "Ajouter";
            ajoutToolStripMenuItem.Click += ajoutToolStripMenuItem_Click;
            // 
            // modifierToolStripMenuItem
            // 
            modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            modifierToolStripMenuItem.Size = new Size(281, 26);
            modifierToolStripMenuItem.Text = "Modifier/détruire";
            modifierToolStripMenuItem.Click += modifierToolStripMenuItem_Click;
            // 
            // associerHobbyÀUnÉtudiantToolStripMenuItem
            // 
            associerHobbyÀUnÉtudiantToolStripMenuItem.Name = "associerHobbyÀUnÉtudiantToolStripMenuItem";
            associerHobbyÀUnÉtudiantToolStripMenuItem.Size = new Size(281, 26);
            associerHobbyÀUnÉtudiantToolStripMenuItem.Text = "Associer hobby à un étudiant";
            associerHobbyÀUnÉtudiantToolStripMenuItem.Click += associerHobbyÀUnÉtudiantToolStripMenuItem_Click;
            // 
            // compterLesHobbyToolStripMenuItem
            // 
            compterLesHobbyToolStripMenuItem.Name = "compterLesHobbyToolStripMenuItem";
            compterLesHobbyToolStripMenuItem.Size = new Size(281, 26);
            compterLesHobbyToolStripMenuItem.Text = "Compter les hobby";
            compterLesHobbyToolStripMenuItem.Click += compterLesHobbyToolStripMenuItem_Click;
            // 
            // regexFormToolStripMenuItem
            // 
            regexFormToolStripMenuItem.Name = "regexFormToolStripMenuItem";
            regexFormToolStripMenuItem.Size = new Size(281, 26);
            regexFormToolStripMenuItem.Text = "Regex Form";
            regexFormToolStripMenuItem.Click += regexFormToolStripMenuItem_Click;
            // 
            // menuForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "menuForm";
            Text = "Menu";
            Load += menuForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem étudiantToolStripMenuItem;
        private ToolStripMenuItem ajoutToolStripMenuItem;
        private ToolStripMenuItem modifierToolStripMenuItem;
        private ToolStripMenuItem associerHobbyÀUnÉtudiantToolStripMenuItem;
        private ToolStripMenuItem compterLesHobbyToolStripMenuItem;
        private ToolStripMenuItem regexFormToolStripMenuItem;
    }
}