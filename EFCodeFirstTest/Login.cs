using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFCodeFirstTest
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Person person = new Person();

            Users user = person.User.Where(x => x.Email == txbx_email.Text && x.Password == txbx_password.Text).FirstOrDefault();

            if (user == null)
            {
                MessageBox.Show("Please, Register");
            }
            else
            {
                MessageBox.Show("ela");
            }
             
            
            
            
        }
    }
}
