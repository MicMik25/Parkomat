
namespace Parkometr
{
    partial class Form_Platnosc_Karta
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_numer_rej = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_timer_karta = new System.Windows.Forms.Label();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_akceptuj = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_anuluj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_oplata = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(49, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(684, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wprowadź numer rejestracyjny";
            // 
            // textBox_numer_rej
            // 
            this.textBox_numer_rej.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_numer_rej.Location = new System.Drawing.Point(262, 95);
            this.textBox_numer_rej.MaxLength = 8;
            this.textBox_numer_rej.Name = "textBox_numer_rej";
            this.textBox_numer_rej.Size = new System.Drawing.Size(238, 62);
            this.textBox_numer_rej.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(34, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(614, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wybierz godzinę zakończenia parkowania";
            // 
            // label_timer_karta
            // 
            this.label_timer_karta.AutoSize = true;
            this.label_timer_karta.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_timer_karta.Location = new System.Drawing.Point(252, 256);
            this.label_timer_karta.Name = "label_timer_karta";
            this.label_timer_karta.Size = new System.Drawing.Size(213, 55);
            this.label_timer_karta.TabIndex = 4;
            this.label_timer_karta.Text = "HH : MM";
            // 
            // button_plus
            // 
            this.button_plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_plus.Location = new System.Drawing.Point(143, 331);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(168, 63);
            this.button_plus.TabIndex = 5;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = false;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_akceptuj
            // 
            this.button_akceptuj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_akceptuj.Location = new System.Drawing.Point(143, 412);
            this.button_akceptuj.Name = "button_akceptuj";
            this.button_akceptuj.Size = new System.Drawing.Size(168, 63);
            this.button_akceptuj.TabIndex = 9;
            this.button_akceptuj.Text = "ZBLIŻ KARTĘ";
            this.button_akceptuj.UseVisualStyleBackColor = false;
            this.button_akceptuj.Click += new System.EventHandler(this.button_akceptuj_Click);
            // 
            // button_minus
            // 
            this.button_minus.BackColor = System.Drawing.Color.Red;
            this.button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_minus.Location = new System.Drawing.Point(407, 331);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(168, 63);
            this.button_minus.TabIndex = 10;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = false;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_anuluj
            // 
            this.button_anuluj.BackColor = System.Drawing.Color.Red;
            this.button_anuluj.Location = new System.Drawing.Point(407, 412);
            this.button_anuluj.Name = "button_anuluj";
            this.button_anuluj.Size = new System.Drawing.Size(168, 63);
            this.button_anuluj.TabIndex = 11;
            this.button_anuluj.Text = "ANULUJ";
            this.button_anuluj.UseVisualStyleBackColor = false;
            this.button_anuluj.Click += new System.EventHandler(this.button_anuluj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(803, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Parking płatny w godzinach 8-18";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(803, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Godzina parkowania : 4 PLN";
            // 
            // label_oplata
            // 
            this.label_oplata.AutoSize = true;
            this.label_oplata.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_oplata.Location = new System.Drawing.Point(803, 122);
            this.label_oplata.Name = "label_oplata";
            this.label_oplata.Size = new System.Drawing.Size(70, 25);
            this.label_oplata.TabIndex = 14;
            this.label_oplata.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(803, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(12, 513);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 55);
            this.label6.TabIndex = 16;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // Form_Platnosc_Karta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 639);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_oplata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_anuluj);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_akceptuj);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.label_timer_karta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_numer_rej);
            this.Controls.Add(this.label1);
            this.Name = "Form_Platnosc_Karta";
            this.Load += new System.EventHandler(this.Form_Platnosc_Karta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_numer_rej;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_timer_karta;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_akceptuj;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_anuluj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_oplata;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}