
namespace rectangleAreaAndPerimeterCalculation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cevre = new System.Windows.Forms.Label();
            this.alan = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.uzunKenar = new System.Windows.Forms.TextBox();
            this.kısaKenar = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(186, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lütfen Uzun Kenarı Giriniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(256, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dikdörtgenin Çevresi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(285, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dikdörtgenin Alanı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(198, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(328, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lütfen Kısa Kenarı Giriniz:";
            // 
            // cevre
            // 
            this.cevre.AutoSize = true;
            this.cevre.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cevre.ForeColor = System.Drawing.Color.ForestGreen;
            this.cevre.Location = new System.Drawing.Point(618, 360);
            this.cevre.Name = "cevre";
            this.cevre.Size = new System.Drawing.Size(107, 41);
            this.cevre.TabIndex = 4;
            this.cevre.Text = "label5";
            this.cevre.Visible = false;
            // 
            // alan
            // 
            this.alan.AutoSize = true;
            this.alan.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alan.ForeColor = System.Drawing.Color.ForestGreen;
            this.alan.Location = new System.Drawing.Point(616, 458);
            this.alan.Name = "alan";
            this.alan.Size = new System.Drawing.Size(109, 41);
            this.alan.TabIndex = 5;
            this.alan.Text = "label6";
            this.alan.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Location = new System.Drawing.Point(399, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(370, 81);
            this.button1.TabIndex = 6;
            this.button1.Text = "Dikdörtgenin Değerlerini Hesapla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uzunKenar
            // 
            this.uzunKenar.BackColor = System.Drawing.Color.Khaki;
            this.uzunKenar.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uzunKenar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.uzunKenar.Location = new System.Drawing.Point(552, 68);
            this.uzunKenar.Name = "uzunKenar";
            this.uzunKenar.Size = new System.Drawing.Size(100, 36);
            this.uzunKenar.TabIndex = 7;
            // 
            // kısaKenar
            // 
            this.kısaKenar.BackColor = System.Drawing.Color.Khaki;
            this.kısaKenar.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kısaKenar.Location = new System.Drawing.Point(552, 142);
            this.kısaKenar.Name = "kısaKenar";
            this.kısaKenar.Size = new System.Drawing.Size(100, 36);
            this.kısaKenar.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.Location = new System.Drawing.Point(793, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 51);
            this.button2.TabIndex = 9;
            this.button2.Text = "Yeni Hesaplama";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button3.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button3.Location = new System.Drawing.Point(870, 515);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 62);
            this.button3.TabIndex = 10;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1114, 599);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.kısaKenar);
            this.Controls.Add(this.uzunKenar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.alan);
            this.Controls.Add(this.cevre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "rectangleAreaAndPerimeter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label cevre;
        private System.Windows.Forms.Label alan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox uzunKenar;
        private System.Windows.Forms.TextBox kısaKenar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

