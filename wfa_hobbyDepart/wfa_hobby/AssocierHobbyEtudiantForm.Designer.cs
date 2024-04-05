namespace wfa_hobby
{
    partial class AssocierHobbyEtudiantForm
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
            cmbBx_Etudiant = new ComboBox();
            cmbBx_Hobby = new ComboBox();
            btn_Associer = new Button();
            lbl_Etudiant = new Label();
            lbl_Hobby = new Label();
            SuspendLayout();
            // 
            // cmbBx_Etudiant
            // 
            cmbBx_Etudiant.Font = new Font("Segoe UI", 14F);
            cmbBx_Etudiant.FormattingEnabled = true;
            cmbBx_Etudiant.Location = new Point(106, 15);
            cmbBx_Etudiant.Name = "cmbBx_Etudiant";
            cmbBx_Etudiant.Size = new Size(195, 33);
            cmbBx_Etudiant.TabIndex = 0;
            // 
            // cmbBx_Hobby
            // 
            cmbBx_Hobby.Font = new Font("Segoe UI", 14F);
            cmbBx_Hobby.FormattingEnabled = true;
            cmbBx_Hobby.Location = new Point(106, 57);
            cmbBx_Hobby.Name = "cmbBx_Hobby";
            cmbBx_Hobby.Size = new Size(195, 33);
            cmbBx_Hobby.TabIndex = 1;
            // 
            // btn_Associer
            // 
            btn_Associer.Font = new Font("Segoe UI", 14F);
            btn_Associer.Location = new Point(12, 102);
            btn_Associer.Name = "btn_Associer";
            btn_Associer.Size = new Size(301, 42);
            btn_Associer.TabIndex = 2;
            btn_Associer.Text = "Associer l'étudiant à un hobby";
            btn_Associer.UseVisualStyleBackColor = true;
            btn_Associer.Click += btn_Associer_Click;
            // 
            // lbl_Etudiant
            // 
            lbl_Etudiant.AutoSize = true;
            lbl_Etudiant.Font = new Font("Segoe UI", 14F);
            lbl_Etudiant.Location = new Point(12, 18);
            lbl_Etudiant.Name = "lbl_Etudiant";
            lbl_Etudiant.Size = new Size(82, 25);
            lbl_Etudiant.TabIndex = 3;
            lbl_Etudiant.Text = "Étudiant";
            // 
            // lbl_Hobby
            // 
            lbl_Hobby.AutoSize = true;
            lbl_Hobby.Font = new Font("Segoe UI", 14F);
            lbl_Hobby.Location = new Point(12, 57);
            lbl_Hobby.Name = "lbl_Hobby";
            lbl_Hobby.Size = new Size(67, 25);
            lbl_Hobby.TabIndex = 4;
            lbl_Hobby.Text = "Hobby";
            // 
            // AssocierHobbyEtudiantForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_Hobby);
            Controls.Add(lbl_Etudiant);
            Controls.Add(btn_Associer);
            Controls.Add(cmbBx_Hobby);
            Controls.Add(cmbBx_Etudiant);
            Name = "AssocierHobbyEtudiantForm";
            Text = "AssocierHobbyEtudiantForm";
            Load += AssocierHobbyEtudiantForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBx_Etudiant;
        private ComboBox cmbBx_Hobby;
        private Button btn_Associer;
        private Label lbl_Etudiant;
        private Label lbl_Hobby;
    }
}