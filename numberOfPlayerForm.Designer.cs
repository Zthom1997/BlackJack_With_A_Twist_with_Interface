namespace GamesOfCards
{
    partial class NumberOfPlayerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumberOfPlayerForm));
            this.gameTitleLabel = new System.Windows.Forms.Label();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.AddPlayerButton = new System.Windows.Forms.Button();
            this.numberOfPlayerslabel = new System.Windows.Forms.Label();
            this.numberOfPlayersTextBox = new System.Windows.Forms.TextBox();
            this.gamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameTitleLabel
            // 
            this.gameTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gameTitleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gameTitleLabel.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitleLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.gameTitleLabel.Location = new System.Drawing.Point(266, 9);
            this.gameTitleLabel.Name = "gameTitleLabel";
            this.gameTitleLabel.Size = new System.Drawing.Size(743, 99);
            this.gameTitleLabel.TabIndex = 0;
            this.gameTitleLabel.Text = "Blackjack with a Twist";
            this.gameTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gamePanel
            // 
            this.gamePanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gamePanel.AutoSize = true;
            this.gamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gamePanel.Controls.Add(this.errorLabel);
            this.gamePanel.Controls.Add(this.AddPlayerButton);
            this.gamePanel.Controls.Add(this.numberOfPlayerslabel);
            this.gamePanel.Controls.Add(this.numberOfPlayersTextBox);
            this.gamePanel.Location = new System.Drawing.Point(267, 152);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(742, 420);
            this.gamePanel.TabIndex = 1;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Arial", 14F);
            this.errorLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.errorLabel.Location = new System.Drawing.Point(170, 158);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(406, 54);
            this.errorLabel.TabIndex = 4;
            this.errorLabel.Text = "Ongeldige invoer!\r\nInvoer mag alleen uit cijfers bestaan.";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // AddPlayerButton
            // 
            this.AddPlayerButton.BackColor = System.Drawing.Color.Green;
            this.AddPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPlayerButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPlayerButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.AddPlayerButton.Location = new System.Drawing.Point(299, 241);
            this.AddPlayerButton.Name = "AddPlayerButton";
            this.AddPlayerButton.Size = new System.Drawing.Size(142, 61);
            this.AddPlayerButton.TabIndex = 3;
            this.AddPlayerButton.Text = "Spelers toevoegen";
            this.AddPlayerButton.UseVisualStyleBackColor = false;
            this.AddPlayerButton.Click += new System.EventHandler(this.AddPlayerButton_Click);
            // 
            // numberOfPlayerslabel
            // 
            this.numberOfPlayerslabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numberOfPlayerslabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.numberOfPlayerslabel.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfPlayerslabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.numberOfPlayerslabel.Location = new System.Drawing.Point(0, 0);
            this.numberOfPlayerslabel.Name = "numberOfPlayerslabel";
            this.numberOfPlayerslabel.Size = new System.Drawing.Size(743, 61);
            this.numberOfPlayerslabel.TabIndex = 2;
            this.numberOfPlayerslabel.Text = "Aantal spelers:";
            this.numberOfPlayerslabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numberOfPlayersTextBox
            // 
            this.numberOfPlayersTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numberOfPlayersTextBox.BackColor = System.Drawing.Color.White;
            this.numberOfPlayersTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfPlayersTextBox.Location = new System.Drawing.Point(281, 103);
            this.numberOfPlayersTextBox.Name = "numberOfPlayersTextBox";
            this.numberOfPlayersTextBox.Size = new System.Drawing.Size(179, 41);
            this.numberOfPlayersTextBox.TabIndex = 0;
            this.numberOfPlayersTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumberOfPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::GamesOfCards.Properties.Resources.blackjack_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 733);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.gameTitleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NumberOfPlayerForm";
            this.Text = "Blackjack with a Twist";
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameTitleLabel;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.TextBox numberOfPlayersTextBox;
        private System.Windows.Forms.Label numberOfPlayerslabel;
        private System.Windows.Forms.Button AddPlayerButton;
        private System.Windows.Forms.Label errorLabel;
    }
}

