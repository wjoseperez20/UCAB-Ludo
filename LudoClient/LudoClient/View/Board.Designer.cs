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
            this.tableroLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.logoUcabLabel = new System.Windows.Forms.Label();
            this.throwDiceButton = new System.Windows.Forms.Button();
            this.monitorLogs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MonitorBoardPlayer = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tableroLabel
            // 
            this.tableroLabel.Image = ((System.Drawing.Image)(resources.GetObject("tableroLabel.Image")));
            this.tableroLabel.Location = new System.Drawing.Point(35, 110);
            this.tableroLabel.Name = "tableroLabel";
            this.tableroLabel.Size = new System.Drawing.Size(633, 641);
            this.tableroLabel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(479, 39);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(145, 42);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Tablero";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // logoUcabLabel
            // 
            this.logoUcabLabel.Image = global::LudoClient.Properties.Resources.LogoUCAB;
            this.logoUcabLabel.Location = new System.Drawing.Point(12, 743);
            this.logoUcabLabel.Name = "logoUcabLabel";
            this.logoUcabLabel.Size = new System.Drawing.Size(383, 118);
            this.logoUcabLabel.TabIndex = 2;
            // 
            // throwDiceButton
            // 
            this.throwDiceButton.Image = global::LudoClient.Properties.Resources.dice;
            this.throwDiceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.throwDiceButton.Location = new System.Drawing.Point(675, 126);
            this.throwDiceButton.Name = "throwDiceButton";
            this.throwDiceButton.Size = new System.Drawing.Size(231, 56);
            this.throwDiceButton.TabIndex = 3;
            this.throwDiceButton.Text = "Lanzar Dado";
            this.throwDiceButton.UseVisualStyleBackColor = true;
            // 
            // monitorLogs
            // 
            this.monitorLogs.BackColor = System.Drawing.Color.White;
            this.monitorLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monitorLogs.Location = new System.Drawing.Point(675, 254);
            this.monitorLogs.Margin = new System.Windows.Forms.Padding(4);
            this.monitorLogs.Multiline = true;
            this.monitorLogs.Name = "monitorLogs";
            this.monitorLogs.ReadOnly = true;
            this.monitorLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.monitorLogs.Size = new System.Drawing.Size(335, 253);
            this.monitorLogs.TabIndex = 21;
            this.monitorLogs.Text = "monitorLogsGame";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(671, 230);
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
            this.MonitorBoardPlayer.Location = new System.Drawing.Point(675, 567);
            this.MonitorBoardPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.MonitorBoardPlayer.Name = "MonitorBoardPlayer";
            this.MonitorBoardPlayer.Size = new System.Drawing.Size(335, 274);
            this.MonitorBoardPlayer.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(671, 544);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Jugadores:";
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 870);
            this.Controls.Add(this.MonitorBoardPlayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monitorLogs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.throwDiceButton);
            this.Controls.Add(this.logoUcabLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.tableroLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Board";
            this.Text = "Ludo UCAB";
            this.Load += new System.EventHandler(this.Board_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tableroLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label logoUcabLabel;
        private System.Windows.Forms.Button throwDiceButton;
        private System.Windows.Forms.TextBox monitorLogs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox MonitorBoardPlayer;
        private System.Windows.Forms.Label label1;
    }
}