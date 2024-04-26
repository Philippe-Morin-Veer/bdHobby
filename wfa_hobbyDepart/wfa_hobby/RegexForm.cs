using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;// à jouter pour utiliser les regex

namespace wfa_hobby
{
    public partial class RegexForm : Form
    {
        public RegexForm()
        {
            InitializeComponent();
        }

        private void btn_Activer_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                MessageBox.Show("Le programme  fonctionnerait");
            }
        }

        private void txtBx_codePostal_Validating(object sender, CancelEventArgs e)
        {
            bool valide = Regex.IsMatch(txtBx_codePostal.Text, "^([a-zA-Z][0-9]){3}$");
            if(valide == true)
            {
                errPro.Clear();
            }
            else
            {
                e.Cancel = true;//bloque dans le contrôle
                errPro.SetError(txtBx_codePostal, "Entrez un code postal valide exemple: a1a1a1");
            }
        }
    }
}
