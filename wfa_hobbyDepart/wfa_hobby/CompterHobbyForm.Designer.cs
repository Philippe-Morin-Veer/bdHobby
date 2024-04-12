namespace wfa_hobby
{
    partial class CompterHobbyForm
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
            lbl_Etudiant = new Label();
            btn_Compter = new Button();
            cmbBx_Etudiant = new ComboBox();
            SuspendLayout();
            // 
            // lbl_Etudiant
            // 
            lbl_Etudiant.AutoSize = true;
            lbl_Etudiant.Font = new Font("Segoe UI", 14F);
            lbl_Etudiant.Location = new Point(32, 34);
            lbl_Etudiant.Name = "lbl_Etudiant";
            lbl_Etudiant.Size = new Size(82, 25);
            lbl_Etudiant.TabIndex = 8;
            lbl_Etudiant.Text = "Étudiant";
            // 
            // btn_Compter
            // 
            btn_Compter.Font = new Font("Segoe UI", 14F);
            btn_Compter.Location = new Point(32, 96);
            btn_Compter.Name = "btn_Compter";
            btn_Compter.Size = new Size(589, 188);
            btn_Compter.TabIndex = 7;
            btn_Compter.Text = "Compter le nombre d'hobby de l'étudiant";
            btn_Compter.UseVisualStyleBackColor = true;
            btn_Compter.Click += btn_Compter_Click;
            // 
            // cmbBx_Etudiant
            // 
            cmbBx_Etudiant.Font = new Font("Segoe UI", 14F);
            cmbBx_Etudiant.FormattingEnabled = true;
            cmbBx_Etudiant.Location = new Point(126, 31);
            cmbBx_Etudiant.Name = "cmbBx_Etudiant";
            cmbBx_Etudiant.Size = new Size(495, 33);
            cmbBx_Etudiant.TabIndex = 5;
            // 
            // CompterHobbyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_Etudiant);
            Controls.Add(btn_Compter);
            Controls.Add(cmbBx_Etudiant);
            Name = "CompterHobbyForm";
            Text = "CompterHobbyForm";
            Load += CompterHobbyForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Etudiant;
        private Button btn_Compter;
        private ComboBox cmbBx_Etudiant;
    }
}