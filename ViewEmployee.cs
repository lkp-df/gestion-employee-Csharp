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
    public partial class ViewEmployee : Form
    {
        public ViewEmployee()
        {
            InitializeComponent();
        }

        //CONNEXION A LA BASE DE DE DONNEES
        SqlConnection Con = new SqlConnection(@"Data Source=desktop-dd2qeru;Initial Catalog=EmployeeDatabase;Integrated Security=True;Pooling=False");

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GetEmployee()
        {
            try
            {

                //VERIFICATION QUE L'ID A BIEN ETE SAISI
                if (string.IsNullOrEmpty(EmpIdTb.Text))
                {
                    MessageBox.Show("You Should Enter a Value", "Field Requiered", MessageBoxButtons.OK);
                }
                else
                {
                    /*************** A retenir    
                        quand on recupere toutes les donnees c'est dataSet qu'on utilise pour alimenter la grille
                        quand on recupere un seul champ de la table en base de de donnees pour afficher, on utilise un dataTable

                        dataSet : Ensemblke de données de la base que l'on va remplir dans une grille
                        dataTable: une donnée de la base que l'on va mettre dans une table
                   */

                    //OUVERTURE DE LA CONNEXION
                    Con.Open();
                    string query = "select * from Employee where EmpID='" + EmpIdTb.Text + "' ";

                    SqlCommand sql = new SqlCommand(query, Con);

                    DataTable dt = new DataTable();

                    SqlDataAdapter sda = new SqlDataAdapter(sql);

                    sda.Fill(dt);

                    //comme la donnee est dans dataTable qui est un tableau, 
                    //on va la parcourir mais juste au premier element qui est la ligne
                    //le tableau est compose des lignes, c'est pour quoi nous allons utiliser les lignes pour recuperer les donnees

                    if (dt.Rows != null) //cela signifie qu'il y a une donnee
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            EmpIDLbl.Text = dr["EmpID"].ToString();
                            EmpNameLbl.Text = dr["EmpName"].ToString();
                            EmpAdresseLbl.Text = dr["EmpAdd"].ToString();
                            EmpPosLbl.Text = dr["EmpPos"].ToString();
                            EmpDOBLbl.Text = dr["EmpDOB"].ToString();
                            EmpPhoneLbl.Text = dr["EmpPhone"].ToString();
                            EmpEduLbl.Text = dr["EmpEdu"].ToString();
                            EmpGenderLbl.Text = dr["EmpGen"].ToString();

                            //comme par defaut on caché les label, on va les afficher
                            EmpIDLbl.Visible = true;
                            EmpNameLbl.Visible = true;
                            EmpAdresseLbl.Visible = true;
                            EmpPosLbl.Visible = true;
                            EmpDOBLbl.Visible = true;
                            EmpPhoneLbl.Visible = true;
                            EmpEduLbl.Visible = true;
                            EmpGenderLbl.Visible = true;
                        }
                    }
                    else
                    {
                        //comme par defaut on caché les label, on va les afficher
                        EmpIDLbl.Visible = false;
                        EmpNameLbl.Visible = false;
                        EmpAdresseLbl.Visible = false;
                        EmpPosLbl.Visible = false;
                        EmpDOBLbl.Visible = false;
                        EmpPhoneLbl.Visible = false;
                        EmpEduLbl.Visible = false;
                        EmpGenderLbl.Visible = false;
                    }


                }
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

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            GetEmployee();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            //teste avant impression, si c'est ok
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //mettons le format du pdf a afficher en specifiant les elements a afficher
            e.Graphics.DrawString("=========EMPLOYEE SUMMARY=========", new Font("Lato", 18, FontStyle.Bold), Brushes.Red, new Point(130, 30));
            e.Graphics.DrawString("Employee ID: " + EmpIDLbl.Text + "\t Employee Name: "+ EmpNameLbl.Text, new Font("Lato", 14, FontStyle.Regular), Brushes.Blue, new Point(80, 100));
            e.Graphics.DrawString("Employee Address: " + EmpAdresseLbl.Text + "\t Employee Gender: "+ EmpGenderLbl.Text, new Font("Lato", 14, FontStyle.Regular), Brushes.Blue, new Point(80, 140));
            e.Graphics.DrawString("Employee Position: " + EmpPosLbl.Text + "\t Employee DOB: "+ EmpDOBLbl.Text, new Font("Lato", 12, FontStyle.Regular), Brushes.Blue, new Point(80, 180));
            e.Graphics.DrawString("Employee Phone: " + EmpPhoneLbl.Text + "\t Employee Edu: "+ EmpEduLbl.Text, new Font("Lato", 14, FontStyle.Regular), Brushes.Blue, new Point(80, 220));

            e.Graphics.DrawString("=========GEST EMP SOFT=========", new Font("Lato", 18, FontStyle.Bold), Brushes.Red, new Point(130, 280));

        }
    }
}
