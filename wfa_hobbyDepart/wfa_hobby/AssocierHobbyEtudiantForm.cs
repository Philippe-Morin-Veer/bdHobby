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
    public partial class AssocierHobbyEtudiantForm : Form
    {
        public AssocierHobbyEtudiantForm()
        {
            InitializeComponent();
        }

        private void btn_Associer_Click(object sender, EventArgs e)
        {

        }

        private void AssocierHobbyEtudiantForm_Load(object sender, EventArgs e)
        {
            try
            {
                ManagerHobby managerHobby = new ManagerHobby();
                cmbBx_Hobby.DataSource = managerHobby.ListerHobby();
                cmbBx_Hobby.ValueMember = "no_hobby";
                cmbBx_Hobby.DisplayMember = "Lehobby";
              
            }
            catch(Exception ex)
            {

            }
        }
    }
}
