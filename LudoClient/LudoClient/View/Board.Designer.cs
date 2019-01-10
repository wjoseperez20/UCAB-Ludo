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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tableroLabel
            // 
            this.tableroLabel.Image = ((System.Drawing.Image)(resources.GetObject("tableroLabel.Image")));
            this.tableroLabel.Location = new System.Drawing.Point(48, 119);
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
            this.logoUcabLabel.Location = new System.Drawing.Point(12, 751);
            this.logoUcabLabel.Name = "logoUcabLabel";
            this.logoUcabLabel.Size = new System.Drawing.Size(383, 118);
            this.logoUcabLabel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(730, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 870);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}