namespace Cathrine_TheDragonSlayerGame
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelScoreTitikDua = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelLives = new System.Windows.Forms.Label();
            this.labelLiveTitikDua = new System.Windows.Forms.Label();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.timerBirdGenerator = new System.Windows.Forms.Timer(this.components);
            this.timerDragonGenerator = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelScoreTitikDua
            // 
            this.labelScoreTitikDua.AutoSize = true;
            this.labelScoreTitikDua.BackColor = System.Drawing.Color.Transparent;
            this.labelScoreTitikDua.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreTitikDua.ForeColor = System.Drawing.Color.Red;
            this.labelScoreTitikDua.Location = new System.Drawing.Point(345, 534);
            this.labelScoreTitikDua.Name = "labelScoreTitikDua";
            this.labelScoreTitikDua.Size = new System.Drawing.Size(52, 18);
            this.labelScoreTitikDua.TabIndex = 2;
            this.labelScoreTitikDua.Text = "Score: ";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.Red;
            this.labelScore.Location = new System.Drawing.Point(392, 534);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(16, 18);
            this.labelScore.TabIndex = 3;
            this.labelScore.Text = "0";
            // 
            // labelLives
            // 
            this.labelLives.AutoSize = true;
            this.labelLives.BackColor = System.Drawing.Color.Transparent;
            this.labelLives.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLives.ForeColor = System.Drawing.Color.Red;
            this.labelLives.Location = new System.Drawing.Point(636, 534);
            this.labelLives.Name = "labelLives";
            this.labelLives.Size = new System.Drawing.Size(16, 18);
            this.labelLives.TabIndex = 5;
            this.labelLives.Text = "0";
            // 
            // labelLiveTitikDua
            // 
            this.labelLiveTitikDua.AutoSize = true;
            this.labelLiveTitikDua.BackColor = System.Drawing.Color.Transparent;
            this.labelLiveTitikDua.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLiveTitikDua.ForeColor = System.Drawing.Color.Red;
            this.labelLiveTitikDua.Location = new System.Drawing.Point(589, 534);
            this.labelLiveTitikDua.Name = "labelLiveTitikDua";
            this.labelLiveTitikDua.Size = new System.Drawing.Size(50, 18);
            this.labelLiveTitikDua.TabIndex = 4;
            this.labelLiveTitikDua.Text = "Lives:";
            // 
            // timerGame
            // 
            this.timerGame.Enabled = true;
            this.timerGame.Interval = 40;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // timerBirdGenerator
            // 
            this.timerBirdGenerator.Enabled = true;
            this.timerBirdGenerator.Interval = 1000;
            this.timerBirdGenerator.Tick += new System.EventHandler(this.timerBirdGenerator_Tick);
            // 
            // timerDragonGenerator
            // 
            this.timerDragonGenerator.Enabled = true;
            this.timerDragonGenerator.Interval = 1500;
            this.timerDragonGenerator.Tick += new System.EventHandler(this.timerDragonGenerator_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.labelLives);
            this.Controls.Add(this.labelLiveTitikDua);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelScoreTitikDua);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "The Dragon Slayer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.FormDS_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelScoreTitikDua;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelLives;
        private System.Windows.Forms.Label labelLiveTitikDua;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Timer timerBirdGenerator;
        private System.Windows.Forms.Timer timerDragonGenerator;
    }
}

