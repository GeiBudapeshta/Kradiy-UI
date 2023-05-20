namespace Kradiy_UI
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.ButtonPanelDownload = new System.Windows.Forms.Button();
            this.ButtonPanelUpload = new System.Windows.Forms.Button();
            this.ButtonPanelLogIn = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelKRADIY = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.ButtonPanelDownload);
            this.panelMenu.Controls.Add(this.ButtonPanelUpload);
            this.panelMenu.Controls.Add(this.ButtonPanelLogIn);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(280, 664);
            this.panelMenu.TabIndex = 4;
            // 
            // ButtonPanelDownload
            // 
            this.ButtonPanelDownload.BackgroundImage = global::Kradiy_UI.Properties.Resources.DownloadLarge;
            this.ButtonPanelDownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonPanelDownload.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonPanelDownload.FlatAppearance.BorderSize = 0;
            this.ButtonPanelDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPanelDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPanelDownload.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonPanelDownload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonPanelDownload.Location = new System.Drawing.Point(0, 300);
            this.ButtonPanelDownload.Name = "ButtonPanelDownload";
            this.ButtonPanelDownload.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.ButtonPanelDownload.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonPanelDownload.Size = new System.Drawing.Size(280, 100);
            this.ButtonPanelDownload.TabIndex = 3;
            this.ButtonPanelDownload.Text = "Скачати";
            this.ButtonPanelDownload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonPanelDownload.UseVisualStyleBackColor = true;
            this.ButtonPanelDownload.Click += new System.EventHandler(this.ButtonPanelDownload_Click);
            // 
            // ButtonPanelUpload
            // 
            this.ButtonPanelUpload.BackgroundImage = global::Kradiy_UI.Properties.Resources.UploadLarge;
            this.ButtonPanelUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonPanelUpload.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonPanelUpload.FlatAppearance.BorderSize = 0;
            this.ButtonPanelUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPanelUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPanelUpload.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonPanelUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonPanelUpload.Location = new System.Drawing.Point(0, 200);
            this.ButtonPanelUpload.Name = "ButtonPanelUpload";
            this.ButtonPanelUpload.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.ButtonPanelUpload.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonPanelUpload.Size = new System.Drawing.Size(280, 100);
            this.ButtonPanelUpload.TabIndex = 2;
            this.ButtonPanelUpload.Text = "Зберегти";
            this.ButtonPanelUpload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonPanelUpload.UseVisualStyleBackColor = true;
            this.ButtonPanelUpload.Click += new System.EventHandler(this.ButtonPanelUpload_Click);
            // 
            // ButtonPanelLogIn
            // 
            this.ButtonPanelLogIn.BackgroundImage = global::Kradiy_UI.Properties.Resources.LoginLarge;
            this.ButtonPanelLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonPanelLogIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonPanelLogIn.FlatAppearance.BorderSize = 0;
            this.ButtonPanelLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPanelLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPanelLogIn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonPanelLogIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonPanelLogIn.Location = new System.Drawing.Point(0, 100);
            this.ButtonPanelLogIn.Name = "ButtonPanelLogIn";
            this.ButtonPanelLogIn.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.ButtonPanelLogIn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonPanelLogIn.Size = new System.Drawing.Size(280, 100);
            this.ButtonPanelLogIn.TabIndex = 1;
            this.ButtonPanelLogIn.Text = "Увійти";
            this.ButtonPanelLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonPanelLogIn.UseVisualStyleBackColor = true;
            this.ButtonPanelLogIn.Click += new System.EventHandler(this.ButtonPanelLogIn_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.labelKRADIY);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(280, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // labelKRADIY
            // 
            this.labelKRADIY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelKRADIY.AutoSize = true;
            this.labelKRADIY.Font = new System.Drawing.Font("Unispace", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKRADIY.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelKRADIY.Location = new System.Drawing.Point(24, 15);
            this.labelKRADIY.Name = "labelKRADIY";
            this.labelKRADIY.Size = new System.Drawing.Size(233, 68);
            this.labelKRADIY.TabIndex = 1;
            this.labelKRADIY.Text = "KRADIY";
            this.labelKRADIY.Click += new System.EventHandler(this.labelKRADIY_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(280, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(898, 100);
            this.panelTitleBar.TabIndex = 5;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitle.Location = new System.Drawing.Point(23, 25);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(100, 0, 3, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(218, 55);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Головна";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(280, 100);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(898, 564);
            this.panelDesktopPanel.TabIndex = 6;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 664);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(810, 460);
            this.Name = "FormMain";
            this.Text = "Kradiy";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button ButtonPanelLogIn;
        private System.Windows.Forms.Button ButtonPanelDownload;
        private System.Windows.Forms.Button ButtonPanelUpload;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelKRADIY;
        private System.Windows.Forms.Panel panelDesktopPanel;
    }
}

