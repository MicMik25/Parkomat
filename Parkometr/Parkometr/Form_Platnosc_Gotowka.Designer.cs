
namespace Parkometr
{
    partial class Form_Platnosc_Gotowka
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
            this.label_timer_gotowka = new System.Windows.Forms.Label();
            this.button_akceptuj = new System.Windows.Forms.Button();
            this.button_anuluj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_5zl = new System.Windows.Forms.Button();
            this.button_2zl = new System.Windows.Forms.Button();
            this.button_1zl = new System.Windows.Forms.Button();
            this.label_oplata = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(49, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(684, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wprowadź numer rejestracyjny";
            // 
            // textBox_numer_rej
            // 
            this.textBox_numer_rej.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_numer_rej.Location = new System.Drawing.Point(235, 99);
            this.textBox_numer_rej.MaxLength = 8;
            this.textBox_numer_rej.Name = "textBox_numer_rej";
            this.textBox_numer_rej.Size = new System.Drawing.Size(238, 62);
            this.textBox_numer_rej.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(52, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(614, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wybierz godzinę zakończenia parkowania";
            // 
            // label_timer_gotowka
            // 
            this.label_timer_gotowka.AutoSize = true;
            this.label_timer_gotowka.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_timer_gotowka.Location = new System.Drawing.Point(241, 245);
            this.label_timer_gotowka.Name = "label_timer_gotowka";
            this.label_timer_gotowka.Size = new System.Drawing.Size(213, 55);
            this.label_timer_gotowka.TabIndex = 5;
            this.label_timer_gotowka.Text = "HH : MM";
            // 
            // button_akceptuj
            // 
            this.button_akceptuj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_akceptuj.Location = new System.Drawing.Point(168, 405);
            this.button_akceptuj.Name = "button_akceptuj";
            this.button_akceptuj.Size = new System.Drawing.Size(168, 63);
            this.button_akceptuj.TabIndex = 10;
            this.button_akceptuj.Text = "AKCEPTUJ";
            this.button_akceptuj.UseVisualStyleBackColor = false;
            this.button_akceptuj.Click += new System.EventHandler(this.button_akceptuj_Click);
            // 
            // button_anuluj
            // 
            this.button_anuluj.BackColor = System.Drawing.Color.Red;
            this.button_anuluj.Location = new System.Drawing.Point(389, 405);
            this.button_anuluj.Name = "button_anuluj";
            this.button_anuluj.Size = new System.Drawing.Size(168, 63);
            this.button_anuluj.TabIndex = 12;
            this.button_anuluj.Text = "ANULUJ";
            this.button_anuluj.UseVisualStyleBackColor = false;
            this.button_anuluj.Click += new System.EventHandler(this.button_anuluj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(795, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Parking płatny w godzinach 8-18";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(795, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Godzina parkowania : 4 PLN";
            // 
            // button_5zl
            // 
            this.button_5zl.BackColor = System.Drawing.Color.Yellow;
            this.button_5zl.Location = new System.Drawing.Point(235, 325);
            this.button_5zl.Name = "button_5zl";
            this.button_5zl.Size = new System.Drawing.Size(75, 60);
            this.button_5zl.TabIndex = 15;
            this.button_5zl.Text = "5PLN";
            this.button_5zl.UseVisualStyleBackColor = false;
            this.button_5zl.Click += new System.EventHandler(this.button_5zl_Click);
            // 
            // button_2zl
            // 
            this.button_2zl.BackColor = System.Drawing.Color.Yellow;
            this.button_2zl.Location = new System.Drawing.Point(331, 325);
            this.button_2zl.Name = "button_2zl";
            this.button_2zl.Size = new System.Drawing.Size(75, 60);
            this.button_2zl.TabIndex = 16;
            this.button_2zl.Text = "2PLN";
            this.button_2zl.UseVisualStyleBackColor = false;
            this.button_2zl.Click += new System.EventHandler(this.button_2zl_Click);
            // 
            // button_1zl
            // 
            this.button_1zl.BackColor = System.Drawing.Color.Yellow;
            this.button_1zl.Location = new System.Drawing.Point(428, 325);
            this.button_1zl.Name = "button_1zl";
            this.button_1zl.Size = new System.Drawing.Size(75, 60);
            this.button_1zl.TabIndex = 17;
            this.button_1zl.Text = "1PLN";
            this.button_1zl.UseVisualStyleBackColor = false;
            this.button_1zl.Click += new System.EventHandler(this.button_1zl_Click);
            // 
            // label_oplata
            // 
            this.label_oplata.AutoSize = true;
            this.label_oplata.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_oplata.Location = new System.Drawing.Point(795, 126);
            this.label_oplata.Name = "label_oplata";
            this.label_oplata.Size = new System.Drawing.Size(70, 25);
            this.label_oplata.TabIndex = 18;
            this.label_oplata.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(795, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(12, 522);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 55);
            this.label6.TabIndex = 20;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // Form_Platnosc_Gotowka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 649);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_oplata);
            this.Controls.Add(this.button_1zl);
            this.Controls.Add(this.button_2zl);
            this.Controls.Add(this.button_5zl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_anuluj);
            this.Controls.Add(this.button_akceptuj);
            this.Controls.Add(this.label_timer_gotowka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_numer_rej);
            this.Controls.Add(this.label1);
            this.Name = "Form_Platnosc_Gotowka";
            this.Load += new System.EventHandler(this.Form_Platnosc_Gotowka_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_numer_rej;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_timer_gotowka;
        private System.Windows.Forms.Button button_akceptuj;
        private System.Windows.Forms.Button button_anuluj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_5zl;
        private System.Windows.Forms.Button button_2zl;
        private System.Windows.Forms.Button button_1zl;
        private System.Windows.Forms.Label label_oplata;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}