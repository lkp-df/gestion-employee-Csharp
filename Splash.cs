using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployesManagement
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        int StartValue = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            StartValue += 1;
            //initialisation du progresse bar
            MyProgressBar.Value = StartValue;

            if (MyProgressBar.Value == 100)
            {
                MyProgressBar.Value = 0;
                //on arrete le timer
                timer1.Stop();
                this.Hide();

                //on affiche le formulaire de login
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            //lancement du timer au demarrage de l'application
            timer1.Start();
        }
    }
}
