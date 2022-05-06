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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //CONNEXION A LA BASE DE DONNEES
        SqlConnection Con = new SqlConnection(@"Data Source=desktop-dd2qeru;Initial Catalog=EmployeeDatabase;Integrated Security=True;Pooling=False");

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            UidTb.Text = "";
            UNameTb.Text = "";
        }

        string userId, userName;

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(UidTb.Text) || String.IsNullOrEmpty(UNameTb.Text))
                {
                    MessageBox.Show("All Field Are required", "Missiong Information", MessageBoxButtons.OK);
                }
                else if (UidTb.Text == "Admin" && UNameTb.Text == "password")//je met aussi le moyen de se connecter en tant qu'admin, une porte derobée dont l'admin seul connait les infos de connexion
                {
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    //OUVERTURE DE CONNEXION
                    Con.Open();
                    SqlCommand sql = new SqlCommand("select * from Employee where EmpID='" + UidTb.Text + "' AND EmpName='" + UNameTb.Text + "' ", Con);

                    SqlDataAdapter sda = new SqlDataAdapter(sql);

                    DataTable dt = new DataTable();

                    sda.Fill(dt);


                    foreach (DataRow dr in dt.Rows)
                    {
                        userId = dr["EmpID"].ToString();
                        userName = dr["EmpName"].ToString();
                        // MessageBox.Show(UNameTb.Text +" celui de la bd "+userName);
                        //MessageBox.Show(UNameTb.Text.Length +" celui de la bd "+userName.Length);


                        //FERMETURE D ELA CONNEXION
                        Con.Close();

                        //pour eviter la casse on pouvait tout convertir en miniuscule et comparer acr il y a des donnees saisies en maujuscule
                        //mais on le fera plus tard
                        if (UidTb.Text.Equals(userId) && UNameTb.Text.Equals(userName))
                        {
                            Home home = new Home();
                            home.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or user ID", "Wrong Information", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //FERMETURE D ELA CONNEXION
                Con.Close();
            }
        }
    }
}
