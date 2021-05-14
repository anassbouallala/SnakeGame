
namespace SnakeGame
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblScore = new System.Windows.Forms.Label();
            this.lblFood = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblScore
            // 
            this.LblScore.AutoSize = true;
            this.LblScore.Location = new System.Drawing.Point(35, 26);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(98, 18);
            this.LblScore.TabIndex = 0;
            this.LblScore.Text = "Score : 0";
            // 
            // lblFood
            // 
            this.lblFood.BackColor = System.Drawing.Color.Red;
            this.lblFood.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFood.Location = new System.Drawing.Point(488, 119);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(21, 21);
            this.lblFood.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.lblFood);
            this.Controls.Add(this.LblScore);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblScore;
        private System.Windows.Forms.Label lblFood;
    }
}

