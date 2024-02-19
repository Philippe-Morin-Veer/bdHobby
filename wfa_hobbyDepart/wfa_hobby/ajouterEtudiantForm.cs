using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa_hobby
{
    public partial class ajouterEtudiantForm : Form
    {
        public ajouterEtudiantForm()
        {
            InitializeComponent();
        }
       
        private void ajouterEtudiantForm_Load(object sender, EventArgs e)
        {
           
        }
        private bool TextBoxSontRemplis()
        {
            return (prenomTextBox.Text != "" && nomTextBox.Text !="" && cellulaireTextBox.Text !="" );
        }
        private Etudiants PrendreLesValeursDesTextBox()
        {
            Etudiants etudiants = new Etudiants();
            etudiants.Nom = nomTextBox.Text;
            etudiants.Prenom = prenomTextBox.Text;
            etudiants.Cellulaire = cellulaireTextBox.Text;
            etudiants.Humour = (int)humourNumericUpDown.Value;
            etudiants.No_provenance = 1;//remplacer plus tard
            return etudiants;
        }

        private void ajouterButton_Click(object sender, EventArgs e)
        { 
            Etudiants etudiant = new Etudiants();
            ManagerEtudiants managerEtudiants = new ManagerEtudiants();
            int nombreDeLigneAffecter = 0;
            try
            {
                if (TextBoxSontRemplis())
                {
                    //prendre les valeurs 
                    etudiant = PrendreLesValeursDesTextBox();
                    //appeler fonction d'ajout
                   nombreDeLigneAffecter = managerEtudiants.AjouterEtudiants(etudiant);
                    if (nombreDeLigneAffecter > 0)
                    {
                        MessageBox.Show("Ajout avec succès");

                    }
                }
                else
                {
                    MessageBox.Show("Remplisser toutes les valeurs");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message,"Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
             
            }

        }
    }
}
