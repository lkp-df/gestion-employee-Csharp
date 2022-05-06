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
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }
        //CONNEXION A LA BASE DE DONNEES
        SqlConnection Con = new SqlConnection(@"Data Source=desktop-dd2qeru;Initial Catalog=EmployeeDatabase;Integrated Security=True;Pooling=False");

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


                    foreach (DataRow dr in dt.Rows)
                    {
                        // EmpIdTb.Text = dr["EmpID"].ToString();

                        EmpNameTb.Text = dr["EmpName"].ToString();

                        //EmpWorkDayTb.Text = dr["EmpAdd"].ToString();

                        EmpPosTb.Text = dr["EmpPos"].ToString();
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

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }


        private void Salary_Load(object sender, EventArgs e)
        {

        }

        private void FetchBtn_Click(object sender, EventArgs e)
        {
            GetEmployee();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int DailyBase, total;

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(EmpWorkDayTb.Text) || Convert.ToInt32(EmpWorkDayTb.Text) <= 0 
                || Convert.ToInt32(EmpWorkDayTb.Text) > 28 )
            {
                MessageBox.Show("You Should Enter a correct Number of works", "Field Requiered", MessageBoxButtons.OK);
            }
            else if (String.IsNullOrWhiteSpace(EmpPosTb.Text))
            {
                MessageBox.Show("You Should Enter a Employee ID", "Field Requiered", MessageBoxButtons.OK);
            }
            else
            {
                //teste avant impression, si c'est ok
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //mettons le format du pdf a afficher en specifiant les elements a afficher
            e.Graphics.DrawString("=========SALARY DOCUMENT=========", new Font("Lato", 18, FontStyle.Bold), Brushes.Red, new Point(130, 30));
            e.Graphics.DrawString("Employee ID: " + EmpIdTb.Text + "\t Employee Name: " + EmpNameTb.Text, new Font("Lato", 14, FontStyle.Regular), Brushes.Blue, new Point(80, 100));
            e.Graphics.DrawString("Employee Position: " + EmpPosTb.Text + "\t Employee Day Worked: " + EmpWorkDayTb.Text, new Font("Lato", 12, FontStyle.Regular), Brushes.Blue, new Point(80, 180));
            e.Graphics.DrawString("Employee Daily Salary: " + DailyBase, new Font("Lato", 14, FontStyle.Regular), Brushes.Blue, new Point(80, 220));
            e.Graphics.DrawString("Employee Total Amount: " + total, new Font("Lato", 14, FontStyle.Regular), Brushes.Blue, new Point(80, 260));

            e.Graphics.DrawString("=========GEST EMP SOFT=========", new Font("Lato", 18, FontStyle.Bold), Brushes.Red, new Point(130, 300));

        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            //en fonction de la position, nous allons appliquer un salaire cela n'est pas en base de données, nous le ferons manuellement à titre educatif
            if (String.IsNullOrWhiteSpace(EmpPosTb.Text))
            {
                MessageBox.Show("You Should Enter a Employeed ID", "Field Requiered", MessageBoxButtons.OK);
            }
            else if (String.IsNullOrWhiteSpace(EmpWorkDayTb.Text) || Convert.ToInt32(EmpWorkDayTb.Text) <= 0 || Convert.ToInt32(EmpWorkDayTb.Text) > 28)
            {
                MessageBox.Show("You Should Enter a correct Number of works", "Field Requiered", MessageBoxButtons.OK);
            }
            else
            {
                if (EmpWorkDayTb.Text == "Manager")
                {
                    DailyBase = 1200;
                }
                else if (EmpWorkDayTb.Text == "Senior Developper")
                {
                    DailyBase = 1000;
                }
                else if (EmpWorkDayTb.Text == "Junior Developper")
                {
                    DailyBase = 950;
                }
                else
                {
                    DailyBase = 850;
                }

                //cacul du salaire sur la base de la position de l'employé
                total = DailyBase * Convert.ToInt32(EmpWorkDayTb.Text);

                SalarySlip.Text = "Employee ID"+ EmpIdTb.Text + "\n" + "Employee Name: " + EmpNameTb.Text + "\n" + "Employee Position: " + EmpPosTb.Text +"\n"+ "Employee  Days Worked: " + EmpWorkDayTb.Text+"\n"+ "Employee Daily Salary: " + DailyBase +"\n"+ "Total Amount Salary: " + total;
            }
        }
    }
}
