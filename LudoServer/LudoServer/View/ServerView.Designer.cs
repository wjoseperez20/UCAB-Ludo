namespace LudoServer.View
{
    partial class ServerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerView));
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bRegistarJugador = new System.Windows.Forms.Button();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.userNameText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lastnameText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.recordPlayerLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listRecordPlayers = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listConnectedPlayers = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboCountPlayer = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.monitorLogs = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.selloUcabLabel = new System.Windows.Forms.Label();
            this.eyesLabel = new System.Windows.Forms.Label();
            this.titleServer = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::LudoServer.Properties.Resources.power_button;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(295, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Encender Server";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bRegistarJugador);
            this.panel2.Controls.Add(this.passwordText);
            this.panel2.Controls.Add(this.userNameText);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.lastnameText);
            this.panel2.Controls.Add(this.nameText);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.recordPlayerLabel);
            this.panel2.Location = new System.Drawing.Point(13, 31);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 302);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // bRegistarJugador
            // 
            this.bRegistarJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRegistarJugador.Location = new System.Drawing.Point(289, 244);
            this.bRegistarJugador.Margin = new System.Windows.Forms.Padding(4);
            this.bRegistarJugador.Name = "bRegistarJugador";
            this.bRegistarJugador.Size = new System.Drawing.Size(100, 39);
            this.bRegistarJugador.TabIndex = 22;
            this.bRegistarJugador.Text = "Registrar";
            this.bRegistarJugador.UseVisualStyleBackColor = true;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(137, 196);
            this.passwordText.Margin = new System.Windows.Forms.Padding(4);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(252, 22);
            this.passwordText.TabIndex = 21;
            // 
            // userNameText
            // 
            this.userNameText.Location = new System.Drawing.Point(136, 153);
            this.userNameText.Margin = new System.Windows.Forms.Padding(4);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(252, 22);
            this.userNameText.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 196);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Contraseña:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(51, 154);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Usuario:";
            // 
            // lastnameText
            // 
            this.lastnameText.Location = new System.Drawing.Point(137, 107);
            this.lastnameText.Margin = new System.Windows.Forms.Padding(4);
            this.lastnameText.Name = "lastnameText";
            this.lastnameText.Size = new System.Drawing.Size(252, 22);
            this.lastnameText.TabIndex = 17;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(136, 64);
            this.nameText.Margin = new System.Windows.Forms.Padding(4);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(252, 22);
            this.nameText.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(51, 107);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "Apellido:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(51, 65);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 20);
            this.label14.TabIndex = 14;
            this.label14.Text = "Nombre:";
            // 
            // recordPlayerLabel
            // 
            this.recordPlayerLabel.AutoSize = true;
            this.recordPlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordPlayerLabel.Location = new System.Drawing.Point(23, 21);
            this.recordPlayerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.recordPlayerLabel.Name = "recordPlayerLabel";
            this.recordPlayerLabel.Size = new System.Drawing.Size(166, 25);
            this.recordPlayerLabel.TabIndex = 12;
            this.recordPlayerLabel.Text = "Registrar Jugador";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listRecordPlayers);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(498, 31);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(441, 384);
            this.panel3.TabIndex = 15;
            // 
            // listRecordPlayers
            // 
            this.listRecordPlayers.FormattingEnabled = true;
            this.listRecordPlayers.ItemHeight = 16;
            this.listRecordPlayers.Location = new System.Drawing.Point(28, 65);
            this.listRecordPlayers.Margin = new System.Windows.Forms.Padding(4);
            this.listRecordPlayers.Name = "listRecordPlayers";
            this.listRecordPlayers.Size = new System.Drawing.Size(377, 292);
            this.listRecordPlayers.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 21);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(213, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Jugadores Registrados";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listConnectedPlayers);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(978, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 384);
            this.panel1.TabIndex = 16;
            // 
            // listConnectedPlayers
            // 
            this.listConnectedPlayers.FormattingEnabled = true;
            this.listConnectedPlayers.ItemHeight = 16;
            this.listConnectedPlayers.Location = new System.Drawing.Point(28, 65);
            this.listConnectedPlayers.Margin = new System.Windows.Forms.Padding(4);
            this.listConnectedPlayers.Name = "listConnectedPlayers";
            this.listConnectedPlayers.Size = new System.Drawing.Size(377, 292);
            this.listConnectedPlayers.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Jugadores Conectados";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::LudoServer.Properties.Resources.multiple_users_silhouette;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(42, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 66);
            this.button2.TabIndex = 17;
            this.button2.Text = "Iniciar Partida   ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Configuración";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Max. Jugadores:";
            // 
            // comboCountPlayer
            // 
            this.comboCountPlayer.FormattingEnabled = true;
            this.comboCountPlayer.Location = new System.Drawing.Point(162, 76);
            this.comboCountPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.comboCountPlayer.Name = "comboCountPlayer";
            this.comboCountPlayer.Size = new System.Drawing.Size(84, 24);
            this.comboCountPlayer.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.comboCountPlayer);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(845, 496);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(574, 242);
            this.panel4.TabIndex = 21;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::LudoServer.Properties.Resources.power_off;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(295, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 66);
            this.button3.TabIndex = 21;
            this.button3.Text = "Apagar Server     ";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.monitorLogs);
            this.panel5.Location = new System.Drawing.Point(13, 434);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(808, 340);
            this.panel5.TabIndex = 22;
            // 
            // monitorLogs
            // 
            this.monitorLogs.BackColor = System.Drawing.Color.White;
            this.monitorLogs.Location = new System.Drawing.Point(15, 16);
            this.monitorLogs.Margin = new System.Windows.Forms.Padding(4);
            this.monitorLogs.Multiline = true;
            this.monitorLogs.Name = "monitorLogs";
            this.monitorLogs.ReadOnly = true;
            this.monitorLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.monitorLogs.Size = new System.Drawing.Size(775, 304);
            this.monitorLogs.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.selloUcabLabel);
            this.panel6.Controls.Add(this.eyesLabel);
            this.panel6.Controls.Add(this.titleServer);
            this.panel6.Location = new System.Drawing.Point(41, 341);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(336, 85);
            this.panel6.TabIndex = 22;
            // 
            // selloUcabLabel
            // 
            this.selloUcabLabel.AllowDrop = true;
            this.selloUcabLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selloUcabLabel.Image = global::LudoServer.Properties.Resources.sello_de_calidad_ucabista;
            this.selloUcabLabel.Location = new System.Drawing.Point(256, 12);
            this.selloUcabLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selloUcabLabel.Name = "selloUcabLabel";
            this.selloUcabLabel.Size = new System.Drawing.Size(54, 60);
            this.selloUcabLabel.TabIndex = 27;
            // 
            // eyesLabel
            // 
            this.eyesLabel.AllowDrop = true;
            this.eyesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eyesLabel.Image = global::LudoServer.Properties.Resources.emoticon_face_with_the_mouth_at_one_side_like_a_small_smile_in_a_rounded_square;
            this.eyesLabel.Location = new System.Drawing.Point(20, 12);
            this.eyesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eyesLabel.Name = "eyesLabel";
            this.eyesLabel.Size = new System.Drawing.Size(54, 60);
            this.eyesLabel.TabIndex = 26;
            // 
            // titleServer
            // 
            this.titleServer.AutoSize = true;
            this.titleServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleServer.Location = new System.Drawing.Point(66, 21);
            this.titleServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleServer.Name = "titleServer";
            this.titleServer.Size = new System.Drawing.Size(148, 44);
            this.titleServer.TabIndex = 25;
            this.titleServer.Text = "Monitor";
            // 
            // ServerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 787);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServerView";
            this.Text = "Server Ludo UCAB";
            this.Load += new System.EventHandler(this.ServerView_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bRegistarJugador;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox userNameText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox lastnameText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label recordPlayerLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listRecordPlayers;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listConnectedPlayers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboCountPlayer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox monitorLogs;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label eyesLabel;
        private System.Windows.Forms.Label titleServer;
        private System.Windows.Forms.Label selloUcabLabel;
        private System.Windows.Forms.Button button3;
    }
}

