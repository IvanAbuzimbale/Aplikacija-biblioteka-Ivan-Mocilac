
namespace PosudbaKnjigaIvanMočilac20122012
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
            this.btnNoviKorisnik = new System.Windows.Forms.Button();
            this.btnNovaKnjiga = new System.Windows.Forms.Button();
            this.btnNovaPosudba = new System.Windows.Forms.Button();
            this.btnPregledKorisnika = new System.Windows.Forms.Button();
            this.btnStanjePosudbe = new System.Windows.Forms.Button();
            this.btnStanjeKnjiga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNoviKorisnik
            // 
            this.btnNoviKorisnik.Location = new System.Drawing.Point(33, 43);
            this.btnNoviKorisnik.Name = "btnNoviKorisnik";
            this.btnNoviKorisnik.Size = new System.Drawing.Size(141, 23);
            this.btnNoviKorisnik.TabIndex = 0;
            this.btnNoviKorisnik.Text = "Upis novog korisnika";
            this.btnNoviKorisnik.UseVisualStyleBackColor = true;
            this.btnNoviKorisnik.Click += new System.EventHandler(this.btnNoviKorisnik_Click);
            // 
            // btnNovaKnjiga
            // 
            this.btnNovaKnjiga.Location = new System.Drawing.Point(33, 120);
            this.btnNovaKnjiga.Name = "btnNovaKnjiga";
            this.btnNovaKnjiga.Size = new System.Drawing.Size(141, 23);
            this.btnNovaKnjiga.TabIndex = 1;
            this.btnNovaKnjiga.Text = "Upis nove knjige";
            this.btnNovaKnjiga.UseVisualStyleBackColor = true;
            this.btnNovaKnjiga.Click += new System.EventHandler(this.btnNovaKnjiga_Click);
            // 
            // btnNovaPosudba
            // 
            this.btnNovaPosudba.Location = new System.Drawing.Point(33, 184);
            this.btnNovaPosudba.Name = "btnNovaPosudba";
            this.btnNovaPosudba.Size = new System.Drawing.Size(141, 23);
            this.btnNovaPosudba.TabIndex = 2;
            this.btnNovaPosudba.Text = "Nova posudba";
            this.btnNovaPosudba.UseVisualStyleBackColor = true;
            this.btnNovaPosudba.Click += new System.EventHandler(this.btnNovaPosudba_Click);
            // 
            // btnPregledKorisnika
            // 
            this.btnPregledKorisnika.Location = new System.Drawing.Point(230, 43);
            this.btnPregledKorisnika.Name = "btnPregledKorisnika";
            this.btnPregledKorisnika.Size = new System.Drawing.Size(141, 23);
            this.btnPregledKorisnika.TabIndex = 3;
            this.btnPregledKorisnika.Text = "Pregled korisnika";
            this.btnPregledKorisnika.UseVisualStyleBackColor = true;
            this.btnPregledKorisnika.Click += new System.EventHandler(this.btnPregledKorisnika_Click);
            // 
            // btnStanjePosudbe
            // 
            this.btnStanjePosudbe.Location = new System.Drawing.Point(230, 120);
            this.btnStanjePosudbe.Name = "btnStanjePosudbe";
            this.btnStanjePosudbe.Size = new System.Drawing.Size(141, 23);
            this.btnStanjePosudbe.TabIndex = 4;
            this.btnStanjePosudbe.Text = "Stanje posudbe";
            this.btnStanjePosudbe.UseVisualStyleBackColor = true;
            this.btnStanjePosudbe.Click += new System.EventHandler(this.btnStanjePosudbe_Click);
            // 
            // btnStanjeKnjiga
            // 
            this.btnStanjeKnjiga.Location = new System.Drawing.Point(230, 183);
            this.btnStanjeKnjiga.Name = "btnStanjeKnjiga";
            this.btnStanjeKnjiga.Size = new System.Drawing.Size(141, 23);
            this.btnStanjeKnjiga.TabIndex = 5;
            this.btnStanjeKnjiga.Text = "Stanje knjiga";
            this.btnStanjeKnjiga.UseVisualStyleBackColor = true;
            this.btnStanjeKnjiga.Click += new System.EventHandler(this.btnStanjeKnjiga_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 262);
            this.Controls.Add(this.btnStanjeKnjiga);
            this.Controls.Add(this.btnStanjePosudbe);
            this.Controls.Add(this.btnPregledKorisnika);
            this.Controls.Add(this.btnNovaPosudba);
            this.Controls.Add(this.btnNovaKnjiga);
            this.Controls.Add(this.btnNoviKorisnik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNoviKorisnik;
        private System.Windows.Forms.Button btnNovaKnjiga;
        private System.Windows.Forms.Button btnNovaPosudba;
        private System.Windows.Forms.Button btnPregledKorisnika;
        private System.Windows.Forms.Button btnStanjePosudbe;
        private System.Windows.Forms.Button btnStanjeKnjiga;
    }
}

