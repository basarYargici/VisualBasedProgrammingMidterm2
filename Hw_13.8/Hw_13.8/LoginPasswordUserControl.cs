using System;
using System.Windows.Forms;

namespace Hw_13._8
{
    public partial class LoginPasswordUserControl : UserControl
    {
        public String Login = "";
        public String Password = "";
        public LoginPasswordUserControl()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // taking the input of TextBoxes and assiging them in a variable
            Login = loginTextBox.Text.ToString();
            Password = passwordTextBox.Text.ToString();

            // to show user inputs in DataGridView we are adding those datas
            LoginApplication.dataGridViw.Rows.Add(Login, Password);
        }
    }
}
