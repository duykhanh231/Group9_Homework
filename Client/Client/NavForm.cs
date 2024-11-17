namespace Client
{
    public partial class NavForm : Form
    {
        public NavForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            loginform.Show();
            this.Hide();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            SignupForm signupform = new SignupForm();
            signupform.Show();
            this.Hide();
        }
    }
}
