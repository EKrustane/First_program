namespace First_program
{
    partial class Form
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
            this.nosaukums = new System.Windows.Forms.Label();
            this.kvadrats = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kvadrats)).BeginInit();
            this.SuspendLayout();
            // 
            // nosaukums
            // 
            this.nosaukums.AutoSize = true;
            this.nosaukums.Font = new System.Drawing.Font("Haettenschweiler", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nosaukums.Location = new System.Drawing.Point(29, 48);
            this.nosaukums.Name = "nosaukums";
            this.nosaukums.Size = new System.Drawing.Size(424, 67);
            this.nosaukums.TabIndex = 0;
            this.nosaukums.Text = "Sarkanais kvadrats";
            // 
            // kvadrats
            // 
            this.kvadrats.Location = new System.Drawing.Point(160, 166);
            this.kvadrats.Name = "kvadrats";
            this.kvadrats.Size = new System.Drawing.Size(150, 150);
            this.kvadrats.TabIndex = 1;
            this.kvadrats.TabStop = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.kvadrats);
            this.Controls.Add(this.nosaukums);
            this.Name = "Form";
            this.Text = "Sarkanais kvadrats";
            ((System.ComponentModel.ISupportInitialize)(this.kvadrats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nosaukums;
        private System.Windows.Forms.PictureBox kvadrats;
    }
}

