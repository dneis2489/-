using pharmacy.data;
using System;
using System.Windows.Forms;

namespace pharmacy
{
    public partial class AuthorizationController : Form
    {
        private AuthorizationService AuthorizationService;
        private User authorizedUser;
        private UserController userForm;
        private AdminController adminForm;
        private RootController rootForm;

        public AuthorizationController()
        {
            InitializeComponent();
            AuthorizationService = AuthorizationService.Instance;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DBConnection.ConnectionDB();
            showHideBtn.Image = Properties.Resources.close_eye;
        }

        private void authorizeBtn_Click(object sender, EventArgs e) //Кнопка авторизоваться
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            if (login != null && password != null)
            {
                authorizedUser = AuthorizationService.AuthorizationUser(login, password);
                if (authorizedUser != null)
                {
                    OpenForm();
                }
            }
            else
            {
                label3.Text = "Заполните все обязательные поля!";
            }           
        }

        public void OpenForm()
        {
            switch (authorizedUser.Role)
            {
                case ("Пользователь"):
                    userForm = new UserController(authorizedUser, this);
                    userForm.Show();
                    this.Hide();
                    break;
                case ("Администратор"): 
                    
                    adminForm = new AdminController(authorizedUser, this);
                    adminForm.Show();
                    this.Hide();
                    break;
                case ("Супер администратор"):
                    
                    rootForm = new RootController(this);
                    rootForm.Show();
                    this.Hide();
                    break;
            }
        }

        private void showHideBtn_Click(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar == false)
            {
                textBox2.UseSystemPasswordChar = true;
                showHideBtn.Image = Properties.Resources.close_eye;
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
                showHideBtn.Image = Properties.Resources.open_eye;
            }

        }

        private void AuthorizationController_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (userForm != null) 
            {
                userForm.Close();
            }

            if (adminForm != null)
            {
                adminForm.Close();
            }

            if (rootForm != null)
            {
                rootForm.Close();
            }
        }
    }
}
