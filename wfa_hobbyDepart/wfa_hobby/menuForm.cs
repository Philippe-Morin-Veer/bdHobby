namespace wfa_hobby
{
    public partial class menuForm : Form
    {
        public menuForm()
        {
            InitializeComponent();
        }

        private void menuForm_Load(object sender, EventArgs e)
        {

        }
        private void ajoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajouterEtudiantForm maForme = new ajouterEtudiantForm();
            maForme.ShowDialog();
        }
        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifierDetruireEtudiantForm maForme = new modifierDetruireEtudiantForm();
            maForme.ShowDialog();
        }

        private void associerHobby�Un�tudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssocierHobbyEtudiantForm associerHobbyEtudiantForm = new AssocierHobbyEtudiantForm();
            associerHobbyEtudiantForm.ShowDialog();
        }

        private void compterLesHobbyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompterHobbyForm compterHobbyForm = new CompterHobbyForm();
            compterHobbyForm.ShowDialog();
        }

        private void regexFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegexForm regexForm = new RegexForm();
            regexForm.ShowDialog();
        }
    }
}