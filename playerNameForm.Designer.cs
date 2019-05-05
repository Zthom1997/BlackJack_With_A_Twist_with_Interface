namespace GamesOfCards
{
    partial class PlayerNameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerNameForm));
            this.gameTitleLabel = new System.Windows.Forms.Label();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.errorLabel2 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.chipsLabel = new System.Windows.Forms.Label();
            this.chipTextBox = new System.Windows.Forms.TextBox();
            this.AddPlayerButton = new System.Windows.Forms.Button();
            this.playerLabel = new System.Windows.Forms.Label();
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
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
            this.gameTitleLabel.TabIndex = 1;
            this.gameTitleLabel.Text = "Blackjack with a Twist";
            this.gameTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gamePanel
            // 
            this.gamePanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gamePanel.AutoSize = true;
            this.gamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gamePanel.Controls.Add(this.errorLabel2);
            this.gamePanel.Controls.Add(this.errorLabel);
            this.gamePanel.Controls.Add(this.chipsLabel);
            this.gamePanel.Controls.Add(this.chipTextBox);
            this.gamePanel.Controls.Add(this.AddPlayerButton);
            this.gamePanel.Controls.Add(this.playerLabel);
            this.gamePanel.Controls.Add(this.playerNameTextBox);
            this.gamePanel.Location = new System.Drawing.Point(267, 152);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(788, 420);
            this.gamePanel.TabIndex = 2;
            // 
            // errorLabel2
            // 
            this.errorLabel2.AutoSize = true;
            this.errorLabel2.Font = new System.Drawing.Font("Arial", 12F);
            this.errorLabel2.ForeColor = System.Drawing.Color.Goldenrod;
            this.errorLabel2.Location = new System.Drawing.Point(198, 108);
            this.errorLabel2.Name = "errorLabel2";
            this.errorLabel2.Size = new System.Drawing.Size(408, 46);
            this.errorLabel2.TabIndex = 7;
            this.errorLabel2.Text = "Er is geen naam ingevoerd.\r\nNaam dient uit tenminste 3 letters te bestaan.";
            this.errorLabel2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.errorLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.errorLabel.Location = new System.Drawing.Point(198, 254);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(383, 23);
            this.errorLabel.TabIndex = 6;
            this.errorLabel.Text = "Aantal chips mag alleen uit cijfers bestaan.";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // chipsLabel
            // 
            this.chipsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chipsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.chipsLabel.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chipsLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.chipsLabel.Location = new System.Drawing.Point(22, 167);
            this.chipsLabel.Name = "chipsLabel";
            this.chipsLabel.Size = new System.Drawing.Size(743, 40);
            this.chipsLabel.TabIndex = 5;
            this.chipsLabel.Text = "Hoeveel chips wilt u kopen?";
            this.chipsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chipTextBox
            // 
            this.chipTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chipTextBox.BackColor = System.Drawing.Color.White;
            this.chipTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chipTextBox.Location = new System.Drawing.Point(281, 210);
            this.chipTextBox.Name = "chipTextBox";
            this.chipTextBox.Size = new System.Drawing.Size(225, 41);
            this.chipTextBox.TabIndex = 4;
            this.chipTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddPlayerButton
            // 
            this.AddPlayerButton.BackColor = System.Drawing.Color.Green;
            this.AddPlayerButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPlayerButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.AddPlayerButton.Location = new System.Drawing.Point(320, 313);
            this.AddPlayerButton.Name = "AddPlayerButton";
            this.AddPlayerButton.Size = new System.Drawing.Size(142, 61);
            this.AddPlayerButton.TabIndex = 3;
            this.AddPlayerButton.Text = "Speler aanmaken";
            this.AddPlayerButton.UseVisualStyleBackColor = false;
            this.AddPlayerButton.Click += new System.EventHandler(this.AddPlayerButton_Click);
            // 
            // playerLabel
            // 
            this.playerLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.playerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.playerLabel.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.playerLabel.Location = new System.Drawing.Point(22, 0);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(743, 61);
            this.playerLabel.TabIndex = 2;
            this.playerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerNameTextBox.BackColor = System.Drawing.Color.White;
            this.playerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameTextBox.Location = new System.Drawing.Point(281, 64);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(225, 41);
            this.playerNameTextBox.TabIndex = 0;
            this.playerNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PlayerNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GamesOfCards.Properties.Resources.blackjack_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 733);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.gameTitleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PlayerNameForm";
            this.Text = "Blackjack with a twist";
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameTitleLabel;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Button AddPlayerButton;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.Label chipsLabel;
        private System.Windows.Forms.TextBox chipTextBox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label errorLabel2;
    }
}