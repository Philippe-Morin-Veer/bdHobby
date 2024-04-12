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
    public partial class CompterHobbyForm : Form
    {
        public CompterHobbyForm()
        {
            InitializeComponent();
        }

        private void btn_Compter_Click(object sender, EventArgs e)
        {
            int no_etudiant = (int)cmbBx_Etudiant.SelectedValue;
            ManagerEtudiantHobby managerEtudiantHobby = new ManagerEtudiantHobby();
            int nombreHobby = managerEtudiantHobby.CompterNombreDeHobby(no_etudiant);
            MessageBox.Show("Cet étudiant à "+nombreHobby.ToString() + " hobby");
        }

        private void CompterHobbyForm_Load(object sender, EventArgs e)
        {
            try
            {
                ListerLesEtudiants();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void ListerLesEtudiants()
        {
            try
            {
                ManagerEtudiants managerEtudiants = new ManagerEtudiants();
                cmbBx_Etudiant.ValueMember = "No_etudiants";
                cmbBx_Etudiant.DisplayMember = "NomComplet";
                cmbBx_Etudiant.DataSource = managerEtudiants.ListerEtudiants();
            }
            catch (Exception ex)
            {

                throw new Exception("Impossible de récupérer les valeurs des étudiants");
            }
        }
    }
}
