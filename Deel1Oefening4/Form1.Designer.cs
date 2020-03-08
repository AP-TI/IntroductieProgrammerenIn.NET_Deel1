namespace Deel1Oefening4
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
            this.labelVoornaam = new System.Windows.Forms.Label();
            this.labelNaam = new System.Windows.Forms.Label();
            this.labelResultaat = new System.Windows.Forms.Label();
            this.textBoxVoornaam = new System.Windows.Forms.TextBox();
            this.textBoxNaam = new System.Windows.Forms.TextBox();
            this.textBoxResultaat = new System.Windows.Forms.TextBox();
            this.buttonZoek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelVoornaam
            // 
            this.labelVoornaam.AutoSize = true;
            this.labelVoornaam.Location = new System.Drawing.Point(58, 108);
            this.labelVoornaam.Name = "labelVoornaam";
            this.labelVoornaam.Size = new System.Drawing.Size(73, 17);
            this.labelVoornaam.TabIndex = 0;
            this.labelVoornaam.Text = "Voornaam";
            // 
            // labelNaam
            // 
            this.labelNaam.AutoSize = true;
            this.labelNaam.Location = new System.Drawing.Point(323, 108);
            this.labelNaam.Name = "labelNaam";
            this.labelNaam.Size = new System.Drawing.Size(45, 17);
            this.labelNaam.TabIndex = 1;
            this.labelNaam.Text = "Naam";
            // 
            // labelResultaat
            // 
            this.labelResultaat.AutoSize = true;
            this.labelResultaat.Location = new System.Drawing.Point(12, 628);
            this.labelResultaat.Name = "labelResultaat";
            this.labelResultaat.Size = new System.Drawing.Size(68, 17);
            this.labelResultaat.TabIndex = 2;
            this.labelResultaat.Text = "Resultaat";
            // 
            // textBoxVoornaam
            // 
            this.textBoxVoornaam.Location = new System.Drawing.Point(61, 125);
            this.textBoxVoornaam.Name = "textBoxVoornaam";
            this.textBoxVoornaam.Size = new System.Drawing.Size(256, 22);
            this.textBoxVoornaam.TabIndex = 3;
            // 
            // textBoxNaam
            // 
            this.textBoxNaam.Location = new System.Drawing.Point(323, 125);
            this.textBoxNaam.Name = "textBoxNaam";
            this.textBoxNaam.Size = new System.Drawing.Size(256, 22);
            this.textBoxNaam.TabIndex = 4;
            // 
            // textBoxResultaat
            // 
            this.textBoxResultaat.Location = new System.Drawing.Point(12, 645);
            this.textBoxResultaat.Multiline = true;
            this.textBoxResultaat.Name = "textBoxResultaat";
            this.textBoxResultaat.Size = new System.Drawing.Size(1730, 312);
            this.textBoxResultaat.TabIndex = 5;
            // 
            // buttonZoek
            // 
            this.buttonZoek.Location = new System.Drawing.Point(77, 153);
            this.buttonZoek.Name = "buttonZoek";
            this.buttonZoek.Size = new System.Drawing.Size(476, 112);
            this.buttonZoek.TabIndex = 6;
            this.buttonZoek.Text = "Zoek";
            this.buttonZoek.UseVisualStyleBackColor = true;
            this.buttonZoek.Click += new System.EventHandler(this.buttonZoek_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1754, 969);
            this.Controls.Add(this.buttonZoek);
            this.Controls.Add(this.textBoxResultaat);
            this.Controls.Add(this.textBoxNaam);
            this.Controls.Add(this.textBoxVoornaam);
            this.Controls.Add(this.labelResultaat);
            this.Controls.Add(this.labelNaam);
            this.Controls.Add(this.labelVoornaam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVoornaam;
        private System.Windows.Forms.Label labelNaam;
        private System.Windows.Forms.Label labelResultaat;
        private System.Windows.Forms.TextBox textBoxVoornaam;
        private System.Windows.Forms.TextBox textBoxNaam;
        private System.Windows.Forms.TextBox textBoxResultaat;
        private System.Windows.Forms.Button buttonZoek;
    }
}

