namespace mail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lg = "login";
            string ps = "password";
            
            
            login.Text = lg;
            password.Text = ps;


            bool f = true;
            bool ff = true;
            while (f)
            {
                if (Convert.ToString(login.Text) != lg || Convert.ToString(password.Text) != ps)
                { label3.Text = "Неправильные логин или пароль"; ff = false; break; }
                else f = false;
            }
            if (ff == true)
            {

                Form2 form2 = new Form2(login.Text, password.Text);
                this.Hide();
                form2.ShowDialog();
                this.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(login.Text, password.Text);
            this.Hide();
            form3.ShowDialog();
            this.Show();
        }
    }
}