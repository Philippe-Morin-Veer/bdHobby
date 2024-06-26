﻿using System;
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
            try
            {
                int no_etudiant = (int)cmbBx_Etudiant.SelectedValue;
                int no_hobby = (int)cmbBx_Hobby.SelectedValue;
                ManagerHobby managerHobby = new ManagerHobby();
                int nombreDeLigneAffectee = 0;
                nombreDeLigneAffectee = managerHobby.AjouterEtudiantHobby(no_etudiant, no_hobby);
                if (nombreDeLigneAffectee > 0)
                {
                    MessageBox.Show("Ajout avec succès");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void AssocierHobbyEtudiantForm_Load(object sender, EventArgs e)
        {
            try
            {
                ManagerHobby managerHobby = new ManagerHobby();
                cmbBx_Hobby.DataSource = managerHobby.ListerHobby();
                cmbBx_Hobby.ValueMember = "no_hobby";
                cmbBx_Hobby.DisplayMember = "Lehobby";
                ManagerEtudiants managerEtudiants = new ManagerEtudiants();
                cmbBx_Etudiant.ValueMember = "No_etudiants";
                cmbBx_Etudiant.DisplayMember = "NomComplet";
                cmbBx_Etudiant.DataSource = managerEtudiants.ListerEtudiants();
                cmbBx_Etudiant.SelectedValue = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbBx_Etudiant_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                
                ManagerEtudiantHobby managerEtudiantHobby = new ManagerEtudiantHobby();
                dataGridView_HobbyEtudiant.DataSource = managerEtudiantHobby.ListerHobbyEtudiant((int)cmbBx_Etudiant.SelectedValue);
                dataGridView_HobbyEtudiant.Columns["no_hobby"].Visible = false;
                dataGridView_HobbyEtudiant.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_HobbyEtudiant.RowHeadersVisible = false;
                dataGridView_HobbyEtudiant.Columns["Lehobby"].HeaderText = "Les Hobby de l'étudiant";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
