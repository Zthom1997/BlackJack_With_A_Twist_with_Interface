namespace GamesOfCards
{
    partial class PlaceBetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaceBetForm));
            this.placeBetLabel = new System.Windows.Forms.Panel();
            this.checkBetButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.placeBetButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.totalLeftTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.betTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chipsTextBox = new System.Windows.Forms.TextBox();
            this.playerLabel = new System.Windows.Forms.Label();
            this.placeBetLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // placeBetLabel
            // 
            this.placeBetLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.placeBetLabel.AutoSize = true;
            this.placeBetLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.placeBetLabel.Controls.Add(this.checkBetButton);
            this.placeBetLabel.Controls.Add(this.errorLabel);
            this.placeBetLabel.Controls.Add(this.placeBetButton);
            this.placeBetLabel.Controls.Add(this.label3);
            this.placeBetLabel.Controls.Add(this.totalLeftTextBox);
            this.placeBetLabel.Controls.Add(this.label2);
            this.placeBetLabel.Controls.Add(this.betTextBox);
            this.placeBetLabel.Controls.Add(this.label1);
            this.placeBetLabel.Controls.Add(this.chipsTextBox);
            this.placeBetLabel.Controls.Add(this.playerLabel);
            this.placeBetLabel.Location = new System.Drawing.Point(344, 102);
            this.placeBetLabel.Name = "placeBetLabel";
            this.placeBetLabel.Size = new System.Drawing.Size(549, 395);
            this.placeBetLabel.TabIndex = 2;
            // 
            // checkBetButton
            // 
            this.checkBetButton.BackColor = System.Drawing.Color.Green;
            this.checkBetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBetButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBetButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.checkBetButton.Location = new System.Drawing.Point(206, 289);
            this.checkBetButton.Name = "checkBetButton";
            this.checkBetButton.Size = new System.Drawing.Size(141, 40);
            this.checkBetButton.TabIndex = 13;
            this.checkBetButton.Text = "Check inzet";
            this.checkBetButton.UseVisualStyleBackColor = false;
            this.checkBetButton.Click += new System.EventHandler(this.CheckBetButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.errorLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.errorLabel.Location = new System.Drawing.Point(69, 247);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(422, 23);
            this.errorLabel.TabIndex = 12;
            this.errorLabel.Text = "De inzet is ongeldig! Probeer het nog een keer.";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // placeBetButton
            // 
            this.placeBetButton.BackColor = System.Drawing.Color.Green;
            this.placeBetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.placeBetButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeBetButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.placeBetButton.Location = new System.Drawing.Point(206, 335);
            this.placeBetButton.Name = "placeBetButton";
            this.placeBetButton.Size = new System.Drawing.Size(141, 40);
            this.placeBetButton.TabIndex = 11;
            this.placeBetButton.Text = "Plaats inzet";
            this.placeBetButton.UseVisualStyleBackColor = false;
            this.placeBetButton.Click += new System.EventHandler(this.PlaceBetButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(31, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Aantal chips over:";
            // 
            // totalLeftTextBox
            // 
            this.totalLeftTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.totalLeftTextBox.Location = new System.Drawing.Point(216, 199);
            this.totalLeftTextBox.Name = "totalLeftTextBox";
            this.totalLeftTextBox.Size = new System.Drawing.Size(131, 30);
            this.totalLeftTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(134, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Inzet:";
            // 
            // betTextBox
            // 
            this.betTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.betTextBox.Location = new System.Drawing.Point(216, 156);
            this.betTextBox.Name = "betTextBox";
            this.betTextBox.Size = new System.Drawing.Size(131, 30);
            this.betTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(69, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aantal Chips:";
            // 
            // chipsTextBox
            // 
            this.chipsTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.chipsTextBox.Location = new System.Drawing.Point(216, 113);
            this.chipsTextBox.Name = "chipsTextBox";
            this.chipsTextBox.Size = new System.Drawing.Size(131, 30);
            this.chipsTextBox.TabIndex = 3;
            // 
            // playerLabel
            // 
            this.playerLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.playerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.playerLabel.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.playerLabel.Location = new System.Drawing.Point(-98, 15);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(743, 61);
            this.playerLabel.TabIndex = 2;
            this.playerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PlaceBetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GamesOfCards.Properties.Resources.blackjack_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 733);
            this.Controls.Add(this.placeBetLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PlaceBetForm";
            this.Text = "Blackjack with a Twist";
            this.placeBetLabel.ResumeLayout(false);
            this.placeBetLabel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel placeBetLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.TextBox betTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox chipsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totalLeftTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button placeBetButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button checkBetButton;
    }
}