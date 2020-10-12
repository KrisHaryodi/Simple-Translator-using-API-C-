using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace LoginTA
{
    public partial class Form1 : Form
    {
        Thread th;
        string x;
        string y;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var db = new Model1())
            {
                var query = from table  in db.Tables where table.Username == tbUsername.Text select table;
                foreach(var item in query)
                {
                    x = item.Username;
                    y = item.Password;
                }
            }
                if (tbUsername.Text == x && tbPassword.Text == y)
                {
                    this.Close();
                    th = new Thread(openHome);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                    MessageBox.Show("Please enter correct username and password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void openHome()
        {
            Application.Run(new Home());
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openSignUp);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openSignUp()
        {
            Application.Run(new SignUp());
        }
    }
}
