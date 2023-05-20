using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kradiy_UI.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void LoadTheme()
        {
            Color TextColor = ThemeColor.SecondaryColor;
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                }
            }
            label1.ForeColor = TextColor;
            label2.ForeColor = TextColor;
            label3.ForeColor = TextColor;
        }
        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            Kradiy.User.login = InputLogIn.Text;
            Kradiy.User.password = InputPassword.Text;
            Kradiy.User.Login();
            label3.Visible = (Kradiy.User.client != null);
            ButtonLogIn.Visible = (Kradiy.User.client == null);
            button1.Visible = (Kradiy.User.client != null);

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            LoadTheme();
            if(Kradiy.User.client != null)
            {
                button1.Visible = Kradiy.User.client.IsLoggedIn;
                label3.Visible = Kradiy.User.client.IsLoggedIn;
                ButtonLogIn.Visible = !Kradiy.User.client.IsLoggedIn;
            }
            else
            {
                label3.Visible=false;
                ButtonLogIn.Visible = true;
                button1.Visible = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kradiy.User.client.Logout();
            button1.Visible = Kradiy.User.client.IsLoggedIn;
            label3.Visible = Kradiy.User.client.IsLoggedIn;
            ButtonLogIn.Visible = !Kradiy.User.client.IsLoggedIn;


        }
    }
}
