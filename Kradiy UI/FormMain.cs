using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CG.Web.MegaApiClient;
using Kradiy_UI.Forms;

namespace Kradiy_UI
{
    public partial class FormMain : Form
    {
        private Button currentButton;
        private Random random = new Random();
        private int tempIndex;
        private Form activeForm;

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //btnCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void InitializeHomePage(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void OpenChildForm(Form childForm,object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock= DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
            activeForm = childForm;

        }
        private string GetWellcomeMessage()
        {
            int now = Convert.ToInt16(DateTime.Now.ToString("HH"));
            string time;
            if(now < 4 || now > 21)
            {
                time = "Доброї ночі, ";
            }
            else if (now < 10)
            {
                time = "Доброго ранку, ";
            }
            else if (now < 18)
            {
                time = "Добрий день, ";
            }
            else
            {
                time = "Доброго вечора, ";
            }
            string output = time+Environment.UserName;
            //в залежності від часу написати добрий день вечір юзернейм
            return output;
        }
        public FormMain()
        {
            InitializeComponent();
            labelTitle.Text = GetWellcomeMessage();
            InitializeHomePage(new FormHome());
        }

        private void ButtonPanelLogIn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormLogin(), sender);
        }

        private void ButtonPanelUpload_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormUpload(), sender);

        }

        private void ButtonPanelDownload_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDownload(), sender);

        }

        private void Reset()
        {
            DisableButton();
            labelTitle.Text = GetWellcomeMessage();
            var childForm = new FormHome();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            panelTitleBar.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;

        }

        private void labelKRADIY_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();

            }
            Reset();

        }
    }

}
