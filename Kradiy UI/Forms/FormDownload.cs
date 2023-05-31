using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kradiy_UI.Forms
{
    public partial class FormDownload : Form
    {
        int selected_folder_index;
        string DownloadFolder;
        public FormDownload()
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
            //listBoxFolders.SelectedItem. = ThemeColor.SecondaryColor;
            label1.ForeColor = TextColor;
            label2.ForeColor = TextColor;
            label3.ForeColor = TextColor;
        }
        private void FormDownload_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            if (Kradiy.User.client == null)
            {
                button2.Visible= false;
                label1.Visible = true;
            }
            else
            {
                button2.Visible = true;
                label1.Visible=false;
            }

            LoadTheme();

        }
        private void LoadFolders()
        {
            label1.Visible = true;
            label1.Text = "Отримання папок, зачекайте";
            List<string> folders = Kradiy.ListFoldersInRoot();
            label1.Text = "Папки користувача " + Environment.UserName + ":";
            listBoxFolders.Visible = true;
            ShowFolders(folders);
            label3.Visible = true;
            label3.Text = "Використано: " + Kradiy.GetUsedSpaceOnServer() + "/20гб";

        }
        private void ShowFolders(List<string> folders)
        {
            listBoxFolders.Items.Clear();
            foreach (string folder in folders)
            {
                listBoxFolders.Items.Add(folder);
            }
        }

        private void buttonTemp_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBoxTemp.Text = folderBrowserDialog1.SelectedPath;
                DownloadFolder = folderBrowserDialog1.SelectedPath;
                Kradiy.User.PathToDonwloadFolder = DownloadFolder;
            }
        }

        private void listBoxFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Visible=true;
            richTextBoxTemp.Visible=true;
            buttonTemp.Visible=true;
            selected_folder_index = listBoxFolders.SelectedIndex;
        }

        private void richTextBoxTemp_TextChanged(object sender, EventArgs e)
        {
            if(richTextBoxTemp.Text!=null)
            {
                button1.Visible=true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kradiy.DownloadFolder(selected_folder_index);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Kradiy.User.client != null && Kradiy.User.client.IsLoggedIn)
            {
                LoadFolders();

            }
        }
    }
}
