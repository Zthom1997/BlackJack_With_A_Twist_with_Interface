namespace GamesOfCards
{
    partial class Blackjack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Blackjack));
            this.panel1 = new System.Windows.Forms.Panel();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.numberOfPlayerslabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.playerNameLabel);
            this.panel1.Controls.Add(this.numberOfPlayerslabel);
            this.panel1.Location = new System.Drawing.Point(135, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 417);
            this.panel1.TabIndex = 0;
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.playerNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.playerNameLabel.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 26F, System.Drawing.FontStyle.Bold);
            this.playerNameLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.playerNameLabel.Location = new System.Drawing.Point(-148, 0);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(743, 63);
            this.playerNameLabel.TabIndex = 4;
            this.playerNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numberOfPlayerslabel
            // 
            this.numberOfPlayerslabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numberOfPlayerslabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.numberOfPlayerslabel.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 18F, System.Drawing.FontStyle.Bold);
            this.numberOfPlayerslabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.numberOfPlayerslabel.Location = new System.Drawing.Point(-123, 321);
            this.numberOfPlayerslabel.Name = "numberOfPlayerslabel";
            this.numberOfPlayerslabel.Size = new System.Drawing.Size(743, 96);
            this.numberOfPlayerslabel.TabIndex = 3;
            this.numberOfPlayerslabel.Text = "Gefeliciteerd!\r\nU heeft een Blackjack!\r\n";
            this.numberOfPlayerslabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.Green;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.okButton.Location = new System.Drawing.Point(295, 438);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(141, 40);
            this.okButton.TabIndex = 14;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // Blackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GamesOfCards.Properties.Resources.blackjack_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 490);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Blackjack";
            this.Text = "Blackjack with a Twist";
            this.Load += new System.EventHandler(this.Blackjack_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Label numberOfPlayerslabel;
        private System.Windows.Forms.Button okButton;
    }
}