namespace Kradiy_UI.Forms
{
    partial class FormLogin
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
            this.InputLogIn = new System.Windows.Forms.TextBox();
            this.ButtonLogIn = new System.Windows.Forms.Button();
            this.InputPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputLogIn
            // 
            this.InputLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputLogIn.Location = new System.Drawing.Point(18, 62);
            this.InputLogIn.Name = "InputLogIn";
            this.InputLogIn.Size = new System.Drawing.Size(512, 39);
            this.InputLogIn.TabIndex = 0;
            this.InputLogIn.Text = "biba0012023@gmail.com";
            // 
            // ButtonLogIn
            // 
            this.ButtonLogIn.FlatAppearance.BorderSize = 0;
            this.ButtonLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonLogIn.Location = new System.Drawing.Point(18, 224);
            this.ButtonLogIn.Name = "ButtonLogIn";
            this.ButtonLogIn.Size = new System.Drawing.Size(157, 71);
            this.ButtonLogIn.TabIndex = 2;
            this.ButtonLogIn.Text = "Увійти";
            this.ButtonLogIn.UseVisualStyleBackColor = true;
            this.ButtonLogIn.Click += new System.EventHandler(this.ButtonLogIn_Click);
            // 
            // InputPassword
            // 
            this.InputPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputPassword.Location = new System.Drawing.Point(18, 155);
            this.InputPassword.Name = "InputPassword";
            this.InputPassword.PasswordChar = '*';
            this.InputPassword.Size = new System.Drawing.Size(512, 39);
            this.InputPassword.TabIndex = 1;
            this.InputPassword.Text = "Parol123";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Пошта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(596, 59);
            this.label3.TabIndex = 5;
            this.label3.Text = "Успішно авторизовано";
            this.label3.Visible = false;
            // 
            // ButtonLogOut
            // 
            this.ButtonLogOut.FlatAppearance.BorderSize = 0;
            this.ButtonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonLogOut.Location = new System.Drawing.Point(18, 224);
            this.ButtonLogOut.Name = "ButtonLogOut";
            this.ButtonLogOut.Size = new System.Drawing.Size(157, 71);
            this.ButtonLogOut.TabIndex = 6;
            this.ButtonLogOut.Text = "Вийти";
            this.ButtonLogOut.UseVisualStyleBackColor = true;
            this.ButtonLogOut.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputLogIn);
            this.Controls.Add(this.InputPassword);
            this.Controls.Add(this.ButtonLogOut);
            this.Controls.Add(this.ButtonLogIn);
            this.Name = "FormLogin";
            this.Text = "Авторизація в акаунт Mega";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox InputLogIn;
        private System.Windows.Forms.Button ButtonLogIn;
        private System.Windows.Forms.TextBox InputPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonLogOut;
    }
}