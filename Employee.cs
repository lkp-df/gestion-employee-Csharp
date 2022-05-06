using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmployesManagement
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        //CONNEXION A LA BASE DE DONNEES
        SqlConnection Con = new SqlConnection(@"Data Source=desktop-dd2qeru;Initial Catalog=EmployeeDatabase;Integrated Security=True;Pooling=False");

        private void InsertEmployee()
        {
            try
            {
                //TEST QUE LES CHAMPS NE SONT PAS SOUMIS VIES
                if (String.IsNullOrEmpty(EmpIdTb.Text) || String.IsNullOrEmpty(EmpNameTb.Text)
                    || String.IsNullOrEmpty(EmpAdresseTb.Text) || EmpGenderCb.SelectedIndex == -1
                    || EmpPositionCb.SelectedIndex == -1 || EmpDoB.Value.Date == null
                    || String.IsNullOrEmpty(EmpPhoneTb.Text) || EmpEduCb.SelectedIndex == -1)
                {
                    MessageBox.Show("All Field Are required", "Missiong Information", MessageBoxButtons.OK);
                }
                else
                {
                    //OUVERTURE DE LA CONNEXION
                    Con.Open();

                    //REQUETE PARAMETREE POUR EVITER L'INJECTION SQL
                    SqlCommand sql = new SqlCommand("insert into Employee(EmpID,EmpName,EmpAdd,EmpPos,EmpDOB,EmpPhone,EmpEdu,EmpGen) values(@EID,@ENAME,@EADD,@EPOS,@EDOB,@EPHO,@EEDU,@EGEN)", Con);

                    //ON FAIT LE BINDING
                    sql.Parameters.AddWithValue("@EID", EmpIdTb.Text);
                    sql.Parameters.AddWithValue("@ENAME", EmpNameTb.Text);
                    sql.Parameters.AddWithValue("@EADD", EmpAdresseTb.Text);
                    sql.Parameters.AddWithValue("@EPOS", EmpPositionCb.SelectedItem.ToString());
                    sql.Parameters.AddWithValue("@EDOB", EmpDoB.Value.Date);
                    sql.Parameters.AddWithValue("@EPHO", EmpPhoneTb.Text);
                    sql.Parameters.AddWithValue("@EEDU", EmpEduCb.SelectedItem.ToString());
                    sql.Parameters.AddWithValue("@EGEN", EmpGenderCb.SelectedItem.ToString());

                    //EXECUTION DE LA REQUETE
                    int nbreLigne = sql.ExecuteNonQuery();

                    //FERMETURE DE LA CONNEXION
                    Con.Close();

                    if (nbreLigne > 0)
                    {
                        MessageBox.Show("Employee Added Successfully", "Operation Success", MessageBoxButtons.OK);
                        populate();
                    }
                    else
                    {
                        MessageBox.Show("Impossible To Add this Employee, try agian", "Operation Failed", MessageBoxButtons.OK);
                    }

                }
            }
            catch (Exception e)
            {
                //throw e;
                MessageBox.Show(e.Message);
                //FERMETURE DE LA CONNEXION
                Con.Close();
            }
        }

        private void EditEmployee()
        {
            try
            {
                //TEST QUE LES CHAMPS NE SONT PAS SOUMIS VIES
                if (String.IsNullOrEmpty(EmpIdTb.Text) || String.IsNullOrEmpty(EmpNameTb.Text)
                    || String.IsNullOrEmpty(EmpAdresseTb.Text) || EmpGenderCb.SelectedIndex == -1
                    || EmpPositionCb.SelectedIndex == -1 || EmpDoB.Value.Date == null
                    || String.IsNullOrEmpty(EmpPhoneTb.Text) || EmpEduCb.SelectedIndex == -1)
                {
                    MessageBox.Show("All Field Are required", "Missiong Information", MessageBoxButtons.OK);
                }
                else
                {
                    //OUVERTURE DE LA CONNEXION
                    Con.Open();

                    //REQUETE PARAMETREE POUR EVITER L'INJECTION SQL
                    SqlCommand sql = new SqlCommand("update Employee set EmpName=@ENAME,EmpAdd=@EADD,EmpPos=@EPOS,EmpDOB=@EDOB,EmpPhone=@EPHO,EmpEdu=@EEDU,EmpGen=@EGEN where EmpID=@EID", Con);

                    //ON FAIT LE BINDING
                    sql.Parameters.AddWithValue("@EID", EmpIdTb.Text);
                    sql.Parameters.AddWithValue("@ENAME", EmpNameTb.Text);
                    sql.Parameters.AddWithValue("@EADD", EmpAdresseTb.Text);
                    sql.Parameters.AddWithValue("@EPOS", EmpPositionCb.SelectedItem.ToString());
                    sql.Parameters.AddWithValue("@EDOB", EmpDoB.Value.Date);
                    sql.Parameters.AddWithValue("@EPHO", EmpPhoneTb.Text);
                    sql.Parameters.AddWithValue("@EEDU", EmpEduCb.SelectedItem.ToString());
                    sql.Parameters.AddWithValue("@EGEN", EmpGenderCb.SelectedItem.ToString());

                    //EXECUTION DE LA REQUETE
                    int nbreLigne = sql.ExecuteNonQuery();

                    //FERMETURE DE LA CONNEXION
                    Con.Close();

                    if (nbreLigne > 0)
                    {
                        MessageBox.Show("Employee Updated Successfully", "Operation Success", MessageBoxButtons.OK);
                        populate();
                    }
                    else
                    {
                        MessageBox.Show("Impossible To Updated this Employee, try agian", "Operation Failed", MessageBoxButtons.OK);
                    }

                }
            }
            catch (Exception e)
            {
                //throw e;
                MessageBox.Show(e.Message);
                //FERMETURE DE LA CONNEXION
                Con.Close();
            }
        }

        private void DeleteEmployee()
        {
            try
            {
                //TEST QUE LES CHAMPS NE SONT PAS SOUMIS VIES
                if (String.IsNullOrEmpty(EmpIdTb.Text))
                {
                    MessageBox.Show("You should Enter a Employee Id", "Missiong Information", MessageBoxButtons.OK);
                }
                else
                {
                    //AVERTISSEMENT AVANT SUPPRESSION
                    DialogResult dr = MessageBox.Show("are You Sure to Delete this Employee", "Delete Employee", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (dr == DialogResult.OK)
                    {
                        //OUVERTURE DE LA CONNEXION
                        Con.Open();

                        //REQUETE PARAMETREE POUR EVITER L'INJECTION SQL
                        string query = "delete from Employee where EmpID = '" + EmpIdTb.Text + "' ";
                        SqlCommand sql = new SqlCommand(query, Con);

                        //EXECUTION DE LA REQUETE
                        int nbreLigne = sql.ExecuteNonQuery();

                        //FERMETURE DE LA CONNEXION
                        Con.Close();

                        if (nbreLigne > 0)
                        {
                            MessageBox.Show("Employee Delete Successfully", "Operation Success", MessageBoxButtons.OK);
                            populate();
                        }
                        else
                        {
                            MessageBox.Show("Impossible To Delete this Employee, try agian", "Operation Failed", MessageBoxButtons.OK);
                        }

                    }

                }
            }
            catch (Exception e)
            {
                //throw e;
                MessageBox.Show(e.Message);
                //FERMETURE DE LA CONNEXION
                Con.Close();
            }
        }

        //AFFICHER LES EMPLOYES
        private void populate()
        {
            try
            {
                //OUVERTURE DE LA CONNEXION
                Con.Open();

                string query = "select * from Employee";

                //adapter les donnees provenant de la bd
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);

                //Génère automatiquement des commandes de tableau unique utilisées pour rapprocher les modifications apportées
                //à un DataSet avec la base de données SQL Server associée.
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);

                //on cree un ensemble de donnees
                var ds = new DataSet();

                //on remplit les donnees avec le dataset
                sda.Fill(ds);

                //alimentation de notre grille, remplit avec les noms des colonnes et les valeurs provenants de la bd
                EmpDGView.DataSource = ds.Tables[0];

                //FERMETURE DE LA CONNEXION
                Con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                //FERMETURE DE LA CONNEXION
                Con.Close();
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            InsertEmployee();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            //on affiche les employees
            populate();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteEmployee();
        }

        private void EmpDGView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //REMPLISSAGE DU FORMULAIRE employe qui est à droit EN FONCTION DE L'EMPLOYE SELECTIONNE dans la grille
            //les champs du formulaire se remplirons automatiquement, on pourra faire la suppression sirectement
            EmpIdTb.Text = EmpDGView.SelectedRows[0].Cells[0].Value.ToString();
            EmpNameTb.Text = EmpDGView.SelectedRows[0].Cells[1].Value.ToString();
            EmpAdresseTb.Text = EmpDGView.SelectedRows[0].Cells[2].Value.ToString();
            EmpPositionCb.Text = EmpDGView.SelectedRows[0].Cells[3].Value.ToString();
            EmpDoB.Text = EmpDGView.SelectedRows[0].Cells[4].Value.ToString();
            EmpPhoneTb.Text = EmpDGView.SelectedRows[0].Cells[5].Value.ToString();
            EmpEduCb.Text = EmpDGView.SelectedRows[0].Cells[6].Value.ToString();
            EmpGenderCb.Text = EmpDGView.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            EditEmployee();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
