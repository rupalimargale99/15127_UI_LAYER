using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFAssignment.Models;

namespace EFAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {

            TrainingContext db = new TrainingContext();
            string username = txtUserName.Text;
            string pwd = txtPassword.Text;
            Userdatum user = db.Userdata.SingleOrDefault(u => u.Username == username && u.Password == pwd);

           //var q = from p in db.Userdata  where p.Username == txtUserName.Text  && p.Password == txtPassword.Text select p;


            if (user!=null)
             {
                Console.WriteLine(lblMsg.Text = "Valid User");
            }

            else
            {

                Console.WriteLine(lblMsg.Text = "InValid UserName or Password");
            }
        }
    }
}
