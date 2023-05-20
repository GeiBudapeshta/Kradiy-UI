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
    public partial class FormUpload : Form
    {
        //todo
        /*
         збереження в налаштуваннях значень tempfolder folders 
          
          
        */
        string TempFolder;
        List<string> Folders = new List<string>();
        public FormUpload()
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

        private void FormUpload_Load(object sender, EventArgs e)
        {
            LoadTheme();
            richTextBoxTemp.Text = "C:/Users/" + Environment.UserName + "/Downloads/";
            TempFolder = richTextBoxTemp.Text;
            ShowListOnRichTextBox(richTextBoxFolders, Folders);

        }

        private void buttonFoldersClear_Click(object sender, EventArgs e)
        {
            Folders.Clear();
            ShowListOnRichTextBox(richTextBoxFolders, Folders);
        }

        private void buttonTemp_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBoxTemp.Text = folderBrowserDialog1.SelectedPath;
                TempFolder = folderBrowserDialog1.SelectedPath;
            }
        }

        private void buttonFoldersAdd_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                //richTextBoxFolders.Text = folderBrowserDialog1.SelectedPath;
                Folders.Add(folderBrowserDialog1.SelectedPath);
                ShowListOnRichTextBox(richTextBoxFolders, Folders);
            }

        }
        private void ShowListOnRichTextBox(RichTextBox richTextBox,List<string> strings)
        {
            richTextBox.Text = "";
            foreach(string s in strings)
            {
                richTextBox.Text += s + "\n";
            }
        }

        private void buttonFoldersDelete_Click(object sender, EventArgs e)
        {
            //отримати шлях папки
            //знайти таку папку в масиві папок
            //видалити
            //показати список
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                //richTextBoxFolders.Text = folderBrowserDialog1.SelectedPath;
                if(Folders.Contains(folderBrowserDialog1.SelectedPath))
                {
                    Folders.Remove(folderBrowserDialog1.SelectedPath);
                }
                ShowListOnRichTextBox(richTextBoxFolders, Folders);
            }
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            //зберегти списки в налаштуваннях та передати їх до крадія
            if(Kradiy.User.client!=null && Kradiy.User.client.IsLoggedIn)
            {
                if(Folders.Count>0 && TempFolder!=null)
                {
                    Kradiy.User.FoldersToUpload = Folders;
                    Kradiy.User.PathToTempFolder = TempFolder;
                    label3.Visible = true;
                    label3.Text = "Збережено, початок завантаження";
                    Kradiy.UploadFolders();

                }
                else
                {
                    label3.Visible = true;
                    label3.Text = "Оберіть папки";

                }
            }
            else
            {
                label3.Visible = true;
                label3.Text = "Спочатку авторизуйтесь";
            }
        }
    }
}
