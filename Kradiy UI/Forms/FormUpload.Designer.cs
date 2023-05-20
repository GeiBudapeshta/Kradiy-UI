namespace Kradiy_UI.Forms
{
    partial class FormUpload
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
            this.richTextBoxFolders = new System.Windows.Forms.RichTextBox();
            this.richTextBoxTemp = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTemp = new System.Windows.Forms.Button();
            this.buttonFoldersAdd = new System.Windows.Forms.Button();
            this.buttonFoldersDelete = new System.Windows.Forms.Button();
            this.buttonFoldersClear = new System.Windows.Forms.Button();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxFolders
            // 
            this.richTextBoxFolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxFolders.Location = new System.Drawing.Point(5, 128);
            this.richTextBoxFolders.Name = "richTextBoxFolders";
            this.richTextBoxFolders.Size = new System.Drawing.Size(652, 338);
            this.richTextBoxFolders.TabIndex = 0;
            this.richTextBoxFolders.Text = "";
            // 
            // richTextBoxTemp
            // 
            this.richTextBoxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxTemp.Location = new System.Drawing.Point(5, 49);
            this.richTextBoxTemp.Name = "richTextBoxTemp";
            this.richTextBoxTemp.Size = new System.Drawing.Size(645, 36);
            this.richTextBoxTemp.TabIndex = 1;
            this.richTextBoxTemp.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Папки для завантаження";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(5, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(439, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Папка для тимчасових файлів";
            // 
            // buttonTemp
            // 
            this.buttonTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTemp.Location = new System.Drawing.Point(663, 49);
            this.buttonTemp.Name = "buttonTemp";
            this.buttonTemp.Size = new System.Drawing.Size(160, 55);
            this.buttonTemp.TabIndex = 4;
            this.buttonTemp.Text = "Обрати";
            this.buttonTemp.UseVisualStyleBackColor = true;
            this.buttonTemp.Click += new System.EventHandler(this.buttonTemp_Click);
            // 
            // buttonFoldersAdd
            // 
            this.buttonFoldersAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFoldersAdd.Location = new System.Drawing.Point(663, 128);
            this.buttonFoldersAdd.Name = "buttonFoldersAdd";
            this.buttonFoldersAdd.Size = new System.Drawing.Size(160, 55);
            this.buttonFoldersAdd.TabIndex = 5;
            this.buttonFoldersAdd.Text = "Додати";
            this.buttonFoldersAdd.UseVisualStyleBackColor = true;
            this.buttonFoldersAdd.Click += new System.EventHandler(this.buttonFoldersAdd_Click);
            // 
            // buttonFoldersDelete
            // 
            this.buttonFoldersDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFoldersDelete.Location = new System.Drawing.Point(663, 198);
            this.buttonFoldersDelete.Name = "buttonFoldersDelete";
            this.buttonFoldersDelete.Size = new System.Drawing.Size(160, 55);
            this.buttonFoldersDelete.TabIndex = 6;
            this.buttonFoldersDelete.Text = "Прибрати";
            this.buttonFoldersDelete.UseVisualStyleBackColor = true;
            this.buttonFoldersDelete.Click += new System.EventHandler(this.buttonFoldersDelete_Click);
            // 
            // buttonFoldersClear
            // 
            this.buttonFoldersClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFoldersClear.Location = new System.Drawing.Point(663, 316);
            this.buttonFoldersClear.Name = "buttonFoldersClear";
            this.buttonFoldersClear.Size = new System.Drawing.Size(160, 55);
            this.buttonFoldersClear.TabIndex = 7;
            this.buttonFoldersClear.Text = "Очистити";
            this.buttonFoldersClear.UseVisualStyleBackColor = true;
            this.buttonFoldersClear.Click += new System.EventHandler(this.buttonFoldersClear_Click);
            // 
            // buttonUpload
            // 
            this.buttonUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpload.Location = new System.Drawing.Point(566, 472);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(257, 72);
            this.buttonUpload.TabIndex = 8;
            this.buttonUpload.Text = "Завантажити";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 493);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Лог";
            this.label3.Visible = false;
            // 
            // FormUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 556);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.buttonFoldersClear);
            this.Controls.Add(this.buttonFoldersDelete);
            this.Controls.Add(this.buttonFoldersAdd);
            this.Controls.Add(this.buttonTemp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxTemp);
            this.Controls.Add(this.richTextBoxFolders);
            this.Name = "FormUpload";
            this.Text = "Завантажити файли на сервер";
            this.Load += new System.EventHandler(this.FormUpload_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxFolders;
        private System.Windows.Forms.RichTextBox richTextBoxTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTemp;
        private System.Windows.Forms.Button buttonFoldersAdd;
        private System.Windows.Forms.Button buttonFoldersDelete;
        private System.Windows.Forms.Button buttonFoldersClear;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label3;
    }
}