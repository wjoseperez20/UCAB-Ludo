namespace LudoClient.View
{
    partial class Board
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Board));
            this.throwDiceButton = new System.Windows.Forms.Button();
            this.monitorLogs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MonitorBoardPlayer = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.blueChipLabel = new System.Windows.Forms.Label();
            this.boardLabel = new System.Windows.Forms.Label();
            this.powerOffButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.selloUcabLabel = new System.Windows.Forms.Label();
            this.eyesLabel = new System.Windows.Forms.Label();
            this.titleServer = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // throwDiceButton
            // 
            this.throwDiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.throwDiceButton.Image = global::LudoClient.Properties.Resources.dice;
            this.throwDiceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.throwDiceButton.Location = new System.Drawing.Point(841, 19);
            this.throwDiceButton.Name = "throwDiceButton";
            this.throwDiceButton.Size = new System.Drawing.Size(210, 79);
            this.throwDiceButton.TabIndex = 3;
            this.throwDiceButton.Text = "Lanzar Dado";
            this.throwDiceButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.throwDiceButton.UseVisualStyleBackColor = true;
            this.throwDiceButton.Click += new System.EventHandler(this.throwDiceButton_Click);
            // 
            // monitorLogs
            // 
            this.monitorLogs.BackColor = System.Drawing.Color.White;
            this.monitorLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monitorLogs.Location = new System.Drawing.Point(841, 141);
            this.monitorLogs.Margin = new System.Windows.Forms.Padding(4);
            this.monitorLogs.Multiline = true;
            this.monitorLogs.Name = "monitorLogs";
            this.monitorLogs.ReadOnly = true;
            this.monitorLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.monitorLogs.Size = new System.Drawing.Size(428, 253);
            this.monitorLogs.TabIndex = 21;
            this.monitorLogs.Text = "monitorLogsGame";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(837, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Monitor del Juego:";
            // 
            // MonitorBoardPlayer
            // 
            this.MonitorBoardPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonitorBoardPlayer.FormattingEnabled = true;
            this.MonitorBoardPlayer.ItemHeight = 18;
            this.MonitorBoardPlayer.Location = new System.Drawing.Point(841, 439);
            this.MonitorBoardPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.MonitorBoardPlayer.Name = "MonitorBoardPlayer";
            this.MonitorBoardPlayer.Size = new System.Drawing.Size(428, 256);
            this.MonitorBoardPlayer.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(837, 416);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Jugadores:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.blueChipLabel);
            this.panel3.Controls.Add(this.boardLabel);
            this.panel3.Location = new System.Drawing.Point(13, 13);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(793, 694);
            this.panel3.TabIndex = 25;
            // 
            // blueChipLabel
            // 
            this.blueChipLabel.BackColor = System.Drawing.Color.Transparent;
            this.blueChipLabel.ForeColor = System.Drawing.Color.Transparent;
            this.blueChipLabel.Image = global::LudoClient.Properties.Resources.BlueChip;
            this.blueChipLabel.Location = new System.Drawing.Point(184, 519);
            this.blueChipLabel.Name = "blueChipLabel";
            this.blueChipLabel.Size = new System.Drawing.Size(37, 36);
            this.blueChipLabel.TabIndex = 26;
            // 
            // boardLabel
            // 
            this.boardLabel.Image = global::LudoClient.Properties.Resources.board;
            this.boardLabel.Location = new System.Drawing.Point(24, 18);
            this.boardLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.boardLabel.MaximumSize = new System.Drawing.Size(737, 656);
            this.boardLabel.MinimumSize = new System.Drawing.Size(737, 656);
            this.boardLabel.Name = "boardLabel";
            this.boardLabel.Size = new System.Drawing.Size(737, 656);
            this.boardLabel.TabIndex = 0;
            this.boardLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // powerOffButton
            // 
            this.powerOffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerOffButton.Image = global::LudoClient.Properties.Resources.power_off;
            this.powerOffButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.powerOffButton.Location = new System.Drawing.Point(1030, 723);
            this.powerOffButton.Name = "powerOffButton";
            this.powerOffButton.Size = new System.Drawing.Size(239, 67);
            this.powerOffButton.TabIndex = 26;
            this.powerOffButton.Text = "Apagar Server     ";
            this.powerOffButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.powerOffButton.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.selloUcabLabel);
            this.panel6.Controls.Add(this.eyesLabel);
            this.panel6.Controls.Add(this.titleServer);
            this.panel6.Location = new System.Drawing.Point(13, 715);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(360, 75);
            this.panel6.TabIndex = 27;
            // 
            // selloUcabLabel
            // 
            this.selloUcabLabel.AllowDrop = true;
            this.selloUcabLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selloUcabLabel.Image = global::LudoClient.Properties.Resources.sello_de_calidad_ucabista;
            this.selloUcabLabel.Location = new System.Drawing.Point(274, 7);
            this.selloUcabLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selloUcabLabel.Name = "selloUcabLabel";
            this.selloUcabLabel.Size = new System.Drawing.Size(78, 62);
            this.selloUcabLabel.TabIndex = 27;
            // 
            // eyesLabel
            // 
            this.eyesLabel.AllowDrop = true;
            this.eyesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eyesLabel.Image = global::LudoClient.Properties.Resources.emoticon_face_with_the_mouth_at_one_side_like_a_small_smile_in_a_rounded_square;
            this.eyesLabel.Location = new System.Drawing.Point(68, 14);
            this.eyesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eyesLabel.Name = "eyesLabel";
            this.eyesLabel.Size = new System.Drawing.Size(41, 39);
            this.eyesLabel.TabIndex = 26;
            // 
            // titleServer
            // 
            this.titleServer.AutoSize = true;
            this.titleServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleServer.Location = new System.Drawing.Point(121, 12);
            this.titleServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleServer.Name = "titleServer";
            this.titleServer.Size = new System.Drawing.Size(149, 44);
            this.titleServer.TabIndex = 25;
            this.titleServer.Text = "Tablero";
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 803);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.powerOffButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.MonitorBoardPlayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monitorLogs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.throwDiceButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Board";
            this.Text = "Ludo UCAB";
            this.Load += new System.EventHandler(this.Board_Load);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button throwDiceButton;
        private System.Windows.Forms.TextBox monitorLogs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox MonitorBoardPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button powerOffButton;
        private System.Windows.Forms.Label boardLabel;
        private System.Windows.Forms.Label blueChipLabel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label selloUcabLabel;
        private System.Windows.Forms.Label eyesLabel;
        private System.Windows.Forms.Label titleServer;
    }
}