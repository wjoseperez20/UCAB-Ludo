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
            this.blueChipLabel1 = new System.Windows.Forms.Label();
            this.boardLabel = new System.Windows.Forms.Label();
            this.powerOffButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.selloUcabLabel = new System.Windows.Forms.Label();
            this.eyesLabel = new System.Windows.Forms.Label();
            this.titleServer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.noteLabel = new System.Windows.Forms.Label();
            this.buttonChip1 = new System.Windows.Forms.Button();
            this.buttonChip2 = new System.Windows.Forms.Button();
            this.buttonChip3 = new System.Windows.Forms.Button();
            this.buttonChip4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.blueChipLabel3 = new System.Windows.Forms.Label();
            this.blueChipLabel4 = new System.Windows.Forms.Label();
            this.blueChipLabel2 = new System.Windows.Forms.Label();
            this.redChipLabel1 = new System.Windows.Forms.Label();
            this.redChipLabel3 = new System.Windows.Forms.Label();
            this.redChipLabel4 = new System.Windows.Forms.Label();
            this.redChipLabel2 = new System.Windows.Forms.Label();
            this.greenChipLabel1 = new System.Windows.Forms.Label();
            this.greenChipLabel4 = new System.Windows.Forms.Label();
            this.greenChipLabel2 = new System.Windows.Forms.Label();
            this.greenChipLabel3 = new System.Windows.Forms.Label();
            this.yellowChipLabel1 = new System.Windows.Forms.Label();
            this.yellowChipLabel3 = new System.Windows.Forms.Label();
            this.yellowChipLabel4 = new System.Windows.Forms.Label();
            this.yellowChipLabel2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // throwDiceButton
            // 
            this.throwDiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.throwDiceButton.Image = global::LudoClient.Properties.Resources.dice;
            this.throwDiceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.throwDiceButton.Location = new System.Drawing.Point(631, 15);
            this.throwDiceButton.Margin = new System.Windows.Forms.Padding(2);
            this.throwDiceButton.Name = "throwDiceButton";
            this.throwDiceButton.Size = new System.Drawing.Size(158, 64);
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
            this.monitorLogs.Location = new System.Drawing.Point(631, 242);
            this.monitorLogs.Multiline = true;
            this.monitorLogs.Name = "monitorLogs";
            this.monitorLogs.ReadOnly = true;
            this.monitorLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.monitorLogs.Size = new System.Drawing.Size(322, 206);
            this.monitorLogs.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(628, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Monitor del Juego:";
            // 
            // MonitorBoardPlayer
            // 
            this.MonitorBoardPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonitorBoardPlayer.FormattingEnabled = true;
            this.MonitorBoardPlayer.ItemHeight = 15;
            this.MonitorBoardPlayer.Location = new System.Drawing.Point(631, 484);
            this.MonitorBoardPlayer.Name = "MonitorBoardPlayer";
            this.MonitorBoardPlayer.Size = new System.Drawing.Size(322, 199);
            this.MonitorBoardPlayer.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(628, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Jugadores:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.yellowChipLabel2);
            this.panel3.Controls.Add(this.yellowChipLabel4);
            this.panel3.Controls.Add(this.yellowChipLabel3);
            this.panel3.Controls.Add(this.yellowChipLabel1);
            this.panel3.Controls.Add(this.greenChipLabel3);
            this.panel3.Controls.Add(this.greenChipLabel2);
            this.panel3.Controls.Add(this.greenChipLabel4);
            this.panel3.Controls.Add(this.greenChipLabel1);
            this.panel3.Controls.Add(this.redChipLabel2);
            this.panel3.Controls.Add(this.redChipLabel4);
            this.panel3.Controls.Add(this.redChipLabel3);
            this.panel3.Controls.Add(this.redChipLabel1);
            this.panel3.Controls.Add(this.blueChipLabel2);
            this.panel3.Controls.Add(this.blueChipLabel4);
            this.panel3.Controls.Add(this.blueChipLabel3);
            this.panel3.Controls.Add(this.blueChipLabel1);
            this.panel3.Controls.Add(this.boardLabel);
            this.panel3.Location = new System.Drawing.Point(10, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(595, 564);
            this.panel3.TabIndex = 25;
            // 
            // blueChipLabel1
            // 
            this.blueChipLabel1.BackColor = System.Drawing.Color.Transparent;
            this.blueChipLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.blueChipLabel1.Image = ((System.Drawing.Image)(resources.GetObject("blueChipLabel1.Image")));
            this.blueChipLabel1.Location = new System.Drawing.Point(96, 391);
            this.blueChipLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.blueChipLabel1.Name = "blueChipLabel1";
            this.blueChipLabel1.Size = new System.Drawing.Size(28, 29);
            this.blueChipLabel1.TabIndex = 26;
            this.blueChipLabel1.Click += new System.EventHandler(this.blueChipLabel_Click);
            // 
            // boardLabel
            // 
            this.boardLabel.Image = global::LudoClient.Properties.Resources.board;
            this.boardLabel.Location = new System.Drawing.Point(18, 15);
            this.boardLabel.MaximumSize = new System.Drawing.Size(553, 533);
            this.boardLabel.MinimumSize = new System.Drawing.Size(553, 533);
            this.boardLabel.Name = "boardLabel";
            this.boardLabel.Size = new System.Drawing.Size(553, 533);
            this.boardLabel.TabIndex = 0;
            this.boardLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // powerOffButton
            // 
            this.powerOffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerOffButton.Image = global::LudoClient.Properties.Resources.power_off;
            this.powerOffButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.powerOffButton.Location = new System.Drawing.Point(336, 629);
            this.powerOffButton.Margin = new System.Windows.Forms.Padding(2);
            this.powerOffButton.Name = "powerOffButton";
            this.powerOffButton.Size = new System.Drawing.Size(269, 54);
            this.powerOffButton.TabIndex = 26;
            this.powerOffButton.Text = "Desconectarse del Juego   ";
            this.powerOffButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.powerOffButton.UseVisualStyleBackColor = true;
            this.powerOffButton.Click += new System.EventHandler(this.powerOffButton_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.selloUcabLabel);
            this.panel6.Controls.Add(this.eyesLabel);
            this.panel6.Controls.Add(this.titleServer);
            this.panel6.Location = new System.Drawing.Point(12, 626);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(270, 61);
            this.panel6.TabIndex = 27;
            // 
            // selloUcabLabel
            // 
            this.selloUcabLabel.AllowDrop = true;
            this.selloUcabLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selloUcabLabel.Image = global::LudoClient.Properties.Resources.sello_de_calidad_ucabista;
            this.selloUcabLabel.Location = new System.Drawing.Point(206, 6);
            this.selloUcabLabel.Name = "selloUcabLabel";
            this.selloUcabLabel.Size = new System.Drawing.Size(58, 50);
            this.selloUcabLabel.TabIndex = 27;
            // 
            // eyesLabel
            // 
            this.eyesLabel.AllowDrop = true;
            this.eyesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eyesLabel.Image = global::LudoClient.Properties.Resources.emoticon_face_with_the_mouth_at_one_side_like_a_small_smile_in_a_rounded_square;
            this.eyesLabel.Location = new System.Drawing.Point(51, 11);
            this.eyesLabel.Name = "eyesLabel";
            this.eyesLabel.Size = new System.Drawing.Size(31, 32);
            this.eyesLabel.TabIndex = 26;
            // 
            // titleServer
            // 
            this.titleServer.AutoSize = true;
            this.titleServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleServer.Location = new System.Drawing.Point(91, 10);
            this.titleServer.Name = "titleServer";
            this.titleServer.Size = new System.Drawing.Size(116, 36);
            this.titleServer.TabIndex = 25;
            this.titleServer.Text = "Tablero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 598);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Recuerde: El 1 y el 6 permiten desbloquear una ficha o volver a tirar";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Location = new System.Drawing.Point(11, 584);
            this.noteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(365, 13);
            this.noteLabel.TabIndex = 28;
            this.noteLabel.Text = "Nota: Debe seleccionar la ficha que quiere que se mueva, al lanzar el dado.";
            this.noteLabel.Click += new System.EventHandler(this.noteLabel_Click);
            // 
            // buttonChip1
            // 
            this.buttonChip1.Location = new System.Drawing.Point(685, 93);
            this.buttonChip1.Name = "buttonChip1";
            this.buttonChip1.Size = new System.Drawing.Size(92, 52);
            this.buttonChip1.TabIndex = 30;
            this.buttonChip1.Text = "Ficha 1 ";
            this.buttonChip1.UseVisualStyleBackColor = true;
            // 
            // buttonChip2
            // 
            this.buttonChip2.Location = new System.Drawing.Point(807, 93);
            this.buttonChip2.Name = "buttonChip2";
            this.buttonChip2.Size = new System.Drawing.Size(92, 52);
            this.buttonChip2.TabIndex = 31;
            this.buttonChip2.Text = "Ficha 2";
            this.buttonChip2.UseVisualStyleBackColor = true;
            // 
            // buttonChip3
            // 
            this.buttonChip3.Location = new System.Drawing.Point(685, 158);
            this.buttonChip3.Name = "buttonChip3";
            this.buttonChip3.Size = new System.Drawing.Size(92, 52);
            this.buttonChip3.TabIndex = 32;
            this.buttonChip3.Text = "Ficha 3";
            this.buttonChip3.UseVisualStyleBackColor = true;
            // 
            // buttonChip4
            // 
            this.buttonChip4.Location = new System.Drawing.Point(807, 158);
            this.buttonChip4.Name = "buttonChip4";
            this.buttonChip4.Size = new System.Drawing.Size(92, 52);
            this.buttonChip4.TabIndex = 33;
            this.buttonChip4.Text = "Ficha 4";
            this.buttonChip4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(841, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Resultado:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // blueChipLabel3
            // 
            this.blueChipLabel3.BackColor = System.Drawing.Color.Transparent;
            this.blueChipLabel3.ForeColor = System.Drawing.Color.Transparent;
            this.blueChipLabel3.Image = ((System.Drawing.Image)(resources.GetObject("blueChipLabel3.Image")));
            this.blueChipLabel3.Location = new System.Drawing.Point(158, 457);
            this.blueChipLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.blueChipLabel3.Name = "blueChipLabel3";
            this.blueChipLabel3.Size = new System.Drawing.Size(28, 29);
            this.blueChipLabel3.TabIndex = 27;
            // 
            // blueChipLabel4
            // 
            this.blueChipLabel4.BackColor = System.Drawing.Color.Transparent;
            this.blueChipLabel4.ForeColor = System.Drawing.Color.Transparent;
            this.blueChipLabel4.Image = ((System.Drawing.Image)(resources.GetObject("blueChipLabel4.Image")));
            this.blueChipLabel4.Location = new System.Drawing.Point(158, 391);
            this.blueChipLabel4.Margin = new System.Windows.Forms.Padding(0);
            this.blueChipLabel4.Name = "blueChipLabel4";
            this.blueChipLabel4.Size = new System.Drawing.Size(28, 29);
            this.blueChipLabel4.TabIndex = 28;
            // 
            // blueChipLabel2
            // 
            this.blueChipLabel2.BackColor = System.Drawing.Color.Transparent;
            this.blueChipLabel2.ForeColor = System.Drawing.Color.Transparent;
            this.blueChipLabel2.Image = ((System.Drawing.Image)(resources.GetObject("blueChipLabel2.Image")));
            this.blueChipLabel2.Location = new System.Drawing.Point(96, 457);
            this.blueChipLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.blueChipLabel2.Name = "blueChipLabel2";
            this.blueChipLabel2.Size = new System.Drawing.Size(28, 29);
            this.blueChipLabel2.TabIndex = 29;
            // 
            // redChipLabel1
            // 
            this.redChipLabel1.BackColor = System.Drawing.Color.Transparent;
            this.redChipLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.redChipLabel1.Image = global::LudoClient.Properties.Resources.RedChip;
            this.redChipLabel1.Location = new System.Drawing.Point(96, 82);
            this.redChipLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.redChipLabel1.Name = "redChipLabel1";
            this.redChipLabel1.Size = new System.Drawing.Size(28, 29);
            this.redChipLabel1.TabIndex = 30;
            // 
            // redChipLabel3
            // 
            this.redChipLabel3.BackColor = System.Drawing.Color.Transparent;
            this.redChipLabel3.ForeColor = System.Drawing.Color.Transparent;
            this.redChipLabel3.Image = global::LudoClient.Properties.Resources.RedChip;
            this.redChipLabel3.Location = new System.Drawing.Point(158, 147);
            this.redChipLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.redChipLabel3.Name = "redChipLabel3";
            this.redChipLabel3.Size = new System.Drawing.Size(28, 29);
            this.redChipLabel3.TabIndex = 31;
            // 
            // redChipLabel4
            // 
            this.redChipLabel4.BackColor = System.Drawing.Color.Transparent;
            this.redChipLabel4.ForeColor = System.Drawing.Color.Transparent;
            this.redChipLabel4.Image = global::LudoClient.Properties.Resources.RedChip;
            this.redChipLabel4.Location = new System.Drawing.Point(158, 82);
            this.redChipLabel4.Margin = new System.Windows.Forms.Padding(0);
            this.redChipLabel4.Name = "redChipLabel4";
            this.redChipLabel4.Size = new System.Drawing.Size(28, 29);
            this.redChipLabel4.TabIndex = 32;
            // 
            // redChipLabel2
            // 
            this.redChipLabel2.BackColor = System.Drawing.Color.Transparent;
            this.redChipLabel2.ForeColor = System.Drawing.Color.Transparent;
            this.redChipLabel2.Image = global::LudoClient.Properties.Resources.RedChip;
            this.redChipLabel2.Location = new System.Drawing.Point(96, 147);
            this.redChipLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.redChipLabel2.Name = "redChipLabel2";
            this.redChipLabel2.Size = new System.Drawing.Size(28, 29);
            this.redChipLabel2.TabIndex = 33;
            // 
            // greenChipLabel1
            // 
            this.greenChipLabel1.BackColor = System.Drawing.Color.Transparent;
            this.greenChipLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.greenChipLabel1.Image = global::LudoClient.Properties.Resources.GreenChip;
            this.greenChipLabel1.Location = new System.Drawing.Point(398, 82);
            this.greenChipLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.greenChipLabel1.Name = "greenChipLabel1";
            this.greenChipLabel1.Size = new System.Drawing.Size(28, 29);
            this.greenChipLabel1.TabIndex = 34;
            // 
            // greenChipLabel4
            // 
            this.greenChipLabel4.BackColor = System.Drawing.Color.Transparent;
            this.greenChipLabel4.ForeColor = System.Drawing.Color.Transparent;
            this.greenChipLabel4.Image = global::LudoClient.Properties.Resources.GreenChip;
            this.greenChipLabel4.Location = new System.Drawing.Point(464, 82);
            this.greenChipLabel4.Margin = new System.Windows.Forms.Padding(0);
            this.greenChipLabel4.Name = "greenChipLabel4";
            this.greenChipLabel4.Size = new System.Drawing.Size(28, 29);
            this.greenChipLabel4.TabIndex = 35;
            // 
            // greenChipLabel2
            // 
            this.greenChipLabel2.BackColor = System.Drawing.Color.Transparent;
            this.greenChipLabel2.ForeColor = System.Drawing.Color.Transparent;
            this.greenChipLabel2.Image = global::LudoClient.Properties.Resources.GreenChip;
            this.greenChipLabel2.Location = new System.Drawing.Point(398, 147);
            this.greenChipLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.greenChipLabel2.Name = "greenChipLabel2";
            this.greenChipLabel2.Size = new System.Drawing.Size(28, 29);
            this.greenChipLabel2.TabIndex = 36;
            // 
            // greenChipLabel3
            // 
            this.greenChipLabel3.BackColor = System.Drawing.Color.Transparent;
            this.greenChipLabel3.ForeColor = System.Drawing.Color.Transparent;
            this.greenChipLabel3.Image = global::LudoClient.Properties.Resources.GreenChip;
            this.greenChipLabel3.Location = new System.Drawing.Point(464, 147);
            this.greenChipLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.greenChipLabel3.Name = "greenChipLabel3";
            this.greenChipLabel3.Size = new System.Drawing.Size(28, 29);
            this.greenChipLabel3.TabIndex = 37;
            // 
            // yellowChipLabel1
            // 
            this.yellowChipLabel1.BackColor = System.Drawing.Color.Transparent;
            this.yellowChipLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.yellowChipLabel1.Image = global::LudoClient.Properties.Resources.YellowChip;
            this.yellowChipLabel1.Location = new System.Drawing.Point(398, 391);
            this.yellowChipLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.yellowChipLabel1.Name = "yellowChipLabel1";
            this.yellowChipLabel1.Size = new System.Drawing.Size(28, 29);
            this.yellowChipLabel1.TabIndex = 38;
            // 
            // yellowChipLabel3
            // 
            this.yellowChipLabel3.BackColor = System.Drawing.Color.Transparent;
            this.yellowChipLabel3.ForeColor = System.Drawing.Color.Transparent;
            this.yellowChipLabel3.Image = global::LudoClient.Properties.Resources.YellowChip;
            this.yellowChipLabel3.Location = new System.Drawing.Point(464, 457);
            this.yellowChipLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.yellowChipLabel3.Name = "yellowChipLabel3";
            this.yellowChipLabel3.Size = new System.Drawing.Size(28, 29);
            this.yellowChipLabel3.TabIndex = 39;
            // 
            // yellowChipLabel4
            // 
            this.yellowChipLabel4.BackColor = System.Drawing.Color.Transparent;
            this.yellowChipLabel4.ForeColor = System.Drawing.Color.Transparent;
            this.yellowChipLabel4.Image = global::LudoClient.Properties.Resources.YellowChip;
            this.yellowChipLabel4.Location = new System.Drawing.Point(464, 391);
            this.yellowChipLabel4.Margin = new System.Windows.Forms.Padding(0);
            this.yellowChipLabel4.Name = "yellowChipLabel4";
            this.yellowChipLabel4.Size = new System.Drawing.Size(28, 29);
            this.yellowChipLabel4.TabIndex = 40;
            // 
            // yellowChipLabel2
            // 
            this.yellowChipLabel2.BackColor = System.Drawing.Color.Transparent;
            this.yellowChipLabel2.ForeColor = System.Drawing.Color.Transparent;
            this.yellowChipLabel2.Image = global::LudoClient.Properties.Resources.YellowChip;
            this.yellowChipLabel2.Location = new System.Drawing.Point(398, 457);
            this.yellowChipLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.yellowChipLabel2.Name = "yellowChipLabel2";
            this.yellowChipLabel2.Size = new System.Drawing.Size(28, 29);
            this.yellowChipLabel2.TabIndex = 41;
            // 
            // Board
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(977, 703);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonChip4);
            this.Controls.Add(this.buttonChip3);
            this.Controls.Add(this.buttonChip2);
            this.Controls.Add(this.buttonChip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.powerOffButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.MonitorBoardPlayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monitorLogs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.throwDiceButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label blueChipLabel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label selloUcabLabel;
        private System.Windows.Forms.Label eyesLabel;
        private System.Windows.Forms.Label titleServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.Button buttonChip1;
        private System.Windows.Forms.Button buttonChip2;
        private System.Windows.Forms.Button buttonChip3;
        private System.Windows.Forms.Button buttonChip4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label blueChipLabel2;
        private System.Windows.Forms.Label blueChipLabel4;
        private System.Windows.Forms.Label blueChipLabel3;
        private System.Windows.Forms.Label redChipLabel1;
        private System.Windows.Forms.Label greenChipLabel3;
        private System.Windows.Forms.Label greenChipLabel2;
        private System.Windows.Forms.Label greenChipLabel4;
        private System.Windows.Forms.Label greenChipLabel1;
        private System.Windows.Forms.Label redChipLabel2;
        private System.Windows.Forms.Label redChipLabel4;
        private System.Windows.Forms.Label redChipLabel3;
        private System.Windows.Forms.Label yellowChipLabel2;
        private System.Windows.Forms.Label yellowChipLabel4;
        private System.Windows.Forms.Label yellowChipLabel3;
        private System.Windows.Forms.Label yellowChipLabel1;
    }
}