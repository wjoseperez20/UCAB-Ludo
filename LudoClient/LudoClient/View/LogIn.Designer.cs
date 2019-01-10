namespace LudoClient.View
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bLoginUser = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userNameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.noteLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bLoginUser
            // 
            this.bLoginUser.Location = new System.Drawing.Point(399, 327);
            this.bLoginUser.Name = "bLoginUser";
            this.bLoginUser.Size = new System.Drawing.Size(163, 48);
            this.bLoginUser.TabIndex = 0;
            this.bLoginUser.Text = "INICIAR";
            this.bLoginUser.UseVisualStyleBackColor = true;
            this.bLoginUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(155, 21);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(241, 42);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Iniciar Sesión";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(30, 109);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(186, 25);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "Nombre de Usuario:";
            this.userNameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(112, 187);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(104, 25);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password:";
            // 
            // label4
            // 
            this.label4.Image = global::LudoClient.Properties.Resources.LogoUCAB;
            this.label4.Location = new System.Drawing.Point(12, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(381, 85);
            this.label4.TabIndex = 4;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // userNameText
            // 
            this.userNameText.Location = new System.Drawing.Point(223, 111);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(306, 22);
            this.userNameText.TabIndex = 5;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(223, 189);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(306, 22);
            this.passwordText.TabIndex = 6;
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Location = new System.Drawing.Point(12, 268);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(369, 17);
            this.noteLabel.TabIndex = 5;
            this.noteLabel.Text = "Nota: Si no se encuentra registrado pida al administrador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "del juego que le cree un usuario.";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 402);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.userNameText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.bLoginUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Ludo UCAB - Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bLoginUser;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userNameText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.Label label1;
    }
}