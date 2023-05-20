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
    public partial class FormDownload : Form
    {
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
            label1.ForeColor = TextColor;
            //label2.ForeColor = TextColor;
            //label3.ForeColor = TextColor;
        }
        private void FormDownload_Load(object sender, EventArgs e)
        {
            LoadTheme();

        }
    }
}
