namespace wfa_hobby
{
    partial class RegexForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            ISBN = new Label();
            txtBx_codePostal = new TextBox();
            txtBx_Isbn = new TextBox();
            btn_Activer = new Button();
            errPro = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errPro).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(336, 183);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Code postal";
            // 
            // ISBN
            // 
            ISBN.AutoSize = true;
            ISBN.Location = new Point(336, 228);
            ISBN.Name = "ISBN";
            ISBN.Size = new Size(32, 15);
            ISBN.TabIndex = 1;
            ISBN.Text = "ISBN";
            // 
            // txtBx_codePostal
            // 
            txtBx_codePostal.Location = new Point(429, 181);
            txtBx_codePostal.Name = "txtBx_codePostal";
            txtBx_codePostal.Size = new Size(113, 23);
            txtBx_codePostal.TabIndex = 2;
            txtBx_codePostal.Validating += txtBx_codePostal_Validating;
            // 
            // txtBx_Isbn
            // 
            txtBx_Isbn.Location = new Point(429, 238);
            txtBx_Isbn.Name = "txtBx_Isbn";
            txtBx_Isbn.Size = new Size(113, 23);
            txtBx_Isbn.TabIndex = 3;
            // 
            // btn_Activer
            // 
            btn_Activer.Location = new Point(314, 306);
            btn_Activer.Name = "btn_Activer";
            btn_Activer.Size = new Size(228, 29);
            btn_Activer.TabIndex = 4;
            btn_Activer.Text = "Activer le programme";
            btn_Activer.UseVisualStyleBackColor = true;
            btn_Activer.Click += btn_Activer_Click;
            // 
            // errPro
            // 
            errPro.ContainerControl = this;
            // 
            // RegexForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Activer);
            Controls.Add(txtBx_Isbn);
            Controls.Add(txtBx_codePostal);
            Controls.Add(ISBN);
            Controls.Add(label1);
            Name = "RegexForm";
            Text = "RegexForm";
            ((System.ComponentModel.ISupportInitialize)errPro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label ISBN;
        private TextBox txtBx_codePostal;
        private TextBox txtBx_Isbn;
        private Button btn_Activer;
        private ErrorProvider errPro;
    }
}