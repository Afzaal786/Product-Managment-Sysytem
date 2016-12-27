using System;
using PMSDataAccessLayer;
using System.Linq;
using System.Windows;

namespace Product_Managment
{
    /// <summary>
    /// Interaction logic for loginFoam.xaml
    /// </summary>
    public partial class loginFoam : Window
    {
        USER tobjUser = new USER();
        userFactory objUserFactory = new userFactory();
        public loginFoam()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int resultName;
                if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Password))
                    MessageBox.Show("User name and password are required.", "Error");
                else
                    if (int.TryParse(txtUserName.Text, out resultName))
                    MessageBox.Show("Name cant be number.", "Error");
                else
                {
                    var result = objUserFactory.userLogin(txtUserName.Text, txtPassword.Password);
                    if (result.Count() != 0)
                    {
                        this.Hide();
                        MainWindow mw = new MainWindow();
                        mw.Show();
                    }
                    else
                        MessageBox.Show("Invalid User Name or Password, or\n This user dont exist.", "Login failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
