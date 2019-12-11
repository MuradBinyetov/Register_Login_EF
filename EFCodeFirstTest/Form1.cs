using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFCodeFirstTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            lbl_error.Text = null;
            Users users = new Users
            {
                Name = txbx_name.Text,
                Surname = txbx_surname.Text,
                Email = txbx_email.Text, 
                Password = txbx_password.Text
            };

            ValidationContext c = new ValidationContext(users);
            List<ValidationResult> errorResults = new List<ValidationResult>();
            if (!Validator.TryValidateObject(users, c,errorResults,true))
            {
                foreach (var item in errorResults)
                {
                    lbl_error.Text += item.ErrorMessage + "\n";
                }
            }
            else
            {
                using (Person person=new Person())
                {
                    var mail = person.User.FirstOrDefault(x => x.Email == txbx_email.Text);
                    if (mail!=null)
                    {
                        MessageBox.Show("This email is used");
                    }
                    else
                    {
                        person.User.Add(users);
                        person.SaveChanges();
                        MessageBox.Show("User is added");
                    }
                   

                   
                   
                }
            }
            

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
