
namespace Parkometr
{
    partial class Form_Rodzaj_Platnosci
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
            this.button_platnosc_karta = new System.Windows.Forms.Button();
            this.button_platnosc_gotówką = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_platnosc_karta
            // 
            this.button_platnosc_karta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_platnosc_karta.Location = new System.Drawing.Point(77, 119);
            this.button_platnosc_karta.Name = "button_platnosc_karta";
            this.button_platnosc_karta.Size = new System.Drawing.Size(279, 172);
            this.button_platnosc_karta.TabIndex = 0;
            this.button_platnosc_karta.Text = "Płatność kartą";
            this.button_platnosc_karta.UseVisualStyleBackColor = true;
            this.button_platnosc_karta.Click += new System.EventHandler(this.button_platnosc_karta_Click);
            // 
            // button_platnosc_gotówką
            // 
            this.button_platnosc_gotówką.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_platnosc_gotówką.Location = new System.Drawing.Point(455, 119);
            this.button_platnosc_gotówką.Name = "button_platnosc_gotówką";
            this.button_platnosc_gotówką.Size = new System.Drawing.Size(279, 172);
            this.button_platnosc_gotówką.TabIndex = 1;
            this.button_platnosc_gotówką.Text = "Płatność gotówką";
            this.button_platnosc_gotówką.UseVisualStyleBackColor = true;
            this.button_platnosc_gotówką.Click += new System.EventHandler(this.button_platnosc_gotówką_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(726, 73);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wybierz rodzaj płatności";
            // 
            // Form_Rodzaj_Platnosci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_platnosc_gotówką);
            this.Controls.Add(this.button_platnosc_karta);
            this.Name = "Form_Rodzaj_Platnosci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_platnosc_karta;
        private System.Windows.Forms.Button button_platnosc_gotówką;
        private System.Windows.Forms.Label label1;
    }
}