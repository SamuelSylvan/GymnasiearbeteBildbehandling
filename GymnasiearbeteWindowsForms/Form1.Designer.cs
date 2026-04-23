
namespace GymnasiearbeteWindowsForms
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
            this.lblTextPunkterInnanför = new System.Windows.Forms.Label();
            this.lblIntPunkterInnanför = new System.Windows.Forms.Label();
            this.lblTextAndelinnanför = new System.Windows.Forms.Label();
            this.lblDecimalAndelInnanför = new System.Windows.Forms.Label();
            this.lblTextAntalPunkter = new System.Windows.Forms.Label();
            this.lblIntAntalPunkter = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnBeräkna = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVäljFärg = new System.Windows.Forms.Button();
            this.btnUndersöktFärg = new System.Windows.Forms.Button();
            this.lblUndersöktFärg = new System.Windows.Forms.Label();
            this.pictureBoxGraf = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTextAntalIterationer = new System.Windows.Forms.Label();
            this.lblTextAntalPixlarPerIteration = new System.Windows.Forms.Label();
            this.lblTextStandardavikelse = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraf)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTextPunkterInnanför
            // 
            this.lblTextPunkterInnanför.AutoSize = true;
            this.lblTextPunkterInnanför.Location = new System.Drawing.Point(13, 32);
            this.lblTextPunkterInnanför.Name = "lblTextPunkterInnanför";
            this.lblTextPunkterInnanför.Size = new System.Drawing.Size(205, 20);
            this.lblTextPunkterInnanför.TabIndex = 1;
            this.lblTextPunkterInnanför.Text = "Antal punkter med valv färg:";
            this.lblTextPunkterInnanför.Click += new System.EventHandler(this.lblTextPunkterInnanför_Click);
            // 
            // lblIntPunkterInnanför
            // 
            this.lblIntPunkterInnanför.AutoSize = true;
            this.lblIntPunkterInnanför.Location = new System.Drawing.Point(224, 32);
            this.lblIntPunkterInnanför.Name = "lblIntPunkterInnanför";
            this.lblIntPunkterInnanför.Size = new System.Drawing.Size(14, 20);
            this.lblIntPunkterInnanför.TabIndex = 2;
            this.lblIntPunkterInnanför.Text = "-";
            // 
            // lblTextAndelinnanför
            // 
            this.lblTextAndelinnanför.AutoSize = true;
            this.lblTextAndelinnanför.Location = new System.Drawing.Point(6, 75);
            this.lblTextAndelinnanför.Name = "lblTextAndelinnanför";
            this.lblTextAndelinnanför.Size = new System.Drawing.Size(212, 20);
            this.lblTextAndelinnanför.TabIndex = 3;
            this.lblTextAndelinnanför.Text = "Andel av punkterna innanför:";
            // 
            // lblDecimalAndelInnanför
            // 
            this.lblDecimalAndelInnanför.AutoSize = true;
            this.lblDecimalAndelInnanför.Location = new System.Drawing.Point(224, 75);
            this.lblDecimalAndelInnanför.Name = "lblDecimalAndelInnanför";
            this.lblDecimalAndelInnanför.Size = new System.Drawing.Size(14, 20);
            this.lblDecimalAndelInnanför.TabIndex = 4;
            this.lblDecimalAndelInnanför.Text = "-";
            // 
            // lblTextAntalPunkter
            // 
            this.lblTextAntalPunkter.AutoSize = true;
            this.lblTextAntalPunkter.Location = new System.Drawing.Point(55, 55);
            this.lblTextAntalPunkter.Name = "lblTextAntalPunkter";
            this.lblTextAntalPunkter.Size = new System.Drawing.Size(163, 20);
            this.lblTextAntalPunkter.TabIndex = 5;
            this.lblTextAntalPunkter.Text = "Antal slumpade pixlar:";
            // 
            // lblIntAntalPunkter
            // 
            this.lblIntAntalPunkter.AutoSize = true;
            this.lblIntAntalPunkter.Location = new System.Drawing.Point(224, 52);
            this.lblIntAntalPunkter.Name = "lblIntAntalPunkter";
            this.lblIntAntalPunkter.Size = new System.Drawing.Size(14, 20);
            this.lblIntAntalPunkter.TabIndex = 6;
            this.lblIntAntalPunkter.Text = "-";
            this.lblIntAntalPunkter.Click += new System.EventHandler(this.lblIntAntalPunkter_Click);
            // 
            // btnBeräkna
            // 
            this.btnBeräkna.Location = new System.Drawing.Point(265, 849);
            this.btnBeräkna.Name = "btnBeräkna";
            this.btnBeräkna.Size = new System.Drawing.Size(87, 32);
            this.btnBeräkna.TabIndex = 7;
            this.btnBeräkna.Text = "Beräkna";
            this.btnBeräkna.UseVisualStyleBackColor = true;
            this.btnBeräkna.Click += new System.EventHandler(this.btnBeräkna_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTextPunkterInnanför);
            this.groupBox1.Controls.Add(this.lblTextAntalPunkter);
            this.groupBox1.Controls.Add(this.lblDecimalAndelInnanför);
            this.groupBox1.Controls.Add(this.lblIntAntalPunkter);
            this.groupBox1.Controls.Add(this.lblTextAndelinnanför);
            this.groupBox1.Controls.Add(this.lblIntPunkterInnanför);
            this.groupBox1.Location = new System.Drawing.Point(47, 520);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 146);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultat en iteration (I bild)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVäljFärg);
            this.groupBox2.Controls.Add(this.btnUndersöktFärg);
            this.groupBox2.Controls.Add(this.lblUndersöktFärg);
            this.groupBox2.Location = new System.Drawing.Point(47, 672);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 152);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnVäljFärg
            // 
            this.btnVäljFärg.Location = new System.Drawing.Point(68, 63);
            this.btnVäljFärg.Name = "btnVäljFärg";
            this.btnVäljFärg.Size = new System.Drawing.Size(82, 36);
            this.btnVäljFärg.TabIndex = 11;
            this.btnVäljFärg.Text = "Välj färg";
            this.btnVäljFärg.UseVisualStyleBackColor = true;
            this.btnVäljFärg.Click += new System.EventHandler(this.btnVäljFärg_Click);
            // 
            // btnUndersöktFärg
            // 
            this.btnUndersöktFärg.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnUndersöktFärg.Enabled = false;
            this.btnUndersöktFärg.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnUndersöktFärg.Location = new System.Drawing.Point(176, 27);
            this.btnUndersöktFärg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUndersöktFärg.Name = "btnUndersöktFärg";
            this.btnUndersöktFärg.Size = new System.Drawing.Size(93, 97);
            this.btnUndersöktFärg.TabIndex = 10;
            this.btnUndersöktFärg.UseVisualStyleBackColor = false;
            // 
            // lblUndersöktFärg
            // 
            this.lblUndersöktFärg.AutoSize = true;
            this.lblUndersöktFärg.Location = new System.Drawing.Point(100, 49);
            this.lblUndersöktFärg.Name = "lblUndersöktFärg";
            this.lblUndersöktFärg.Size = new System.Drawing.Size(0, 20);
            this.lblUndersöktFärg.TabIndex = 0;
            // 
            // pictureBoxGraf
            // 
            this.pictureBoxGraf.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBoxGraf.Location = new System.Drawing.Point(7, 38);
            this.pictureBoxGraf.Name = "pictureBoxGraf";
            this.pictureBoxGraf.Size = new System.Drawing.Size(292, 305);
            this.pictureBoxGraf.TabIndex = 10;
            this.pictureBoxGraf.TabStop = false;
            this.pictureBoxGraf.Click += new System.EventHandler(this.pictureBoxGraf_Click);
            this.pictureBoxGraf.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxGraf_Paint);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lblTextStandardavikelse);
            this.groupBox3.Controls.Add(this.lblTextAntalPixlarPerIteration);
            this.groupBox3.Controls.Add(this.lblTextAntalIterationer);
            this.groupBox3.Controls.Add(this.pictureBoxGraf);
            this.groupBox3.Location = new System.Drawing.Point(47, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 467);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fördelning över många iterationer";
            // 
            // lblTextAntalIterationer
            // 
            this.lblTextAntalIterationer.AutoSize = true;
            this.lblTextAntalIterationer.Location = new System.Drawing.Point(86, 370);
            this.lblTextAntalIterationer.Name = "lblTextAntalIterationer";
            this.lblTextAntalIterationer.Size = new System.Drawing.Size(125, 20);
            this.lblTextAntalIterationer.TabIndex = 11;
            this.lblTextAntalIterationer.Text = "Antal iterationer:";
            // 
            // lblTextAntalPixlarPerIteration
            // 
            this.lblTextAntalPixlarPerIteration.AutoSize = true;
            this.lblTextAntalPixlarPerIteration.Location = new System.Drawing.Point(33, 390);
            this.lblTextAntalPixlarPerIteration.Name = "lblTextAntalPixlarPerIteration";
            this.lblTextAntalPixlarPerIteration.Size = new System.Drawing.Size(178, 20);
            this.lblTextAntalPixlarPerIteration.TabIndex = 12;
            this.lblTextAntalPixlarPerIteration.Text = "Antal pixlar per iteration:";
            // 
            // lblTextStandardavikelse
            // 
            this.lblTextStandardavikelse.AutoSize = true;
            this.lblTextStandardavikelse.Location = new System.Drawing.Point(76, 410);
            this.lblTextStandardavikelse.Name = "lblTextStandardavikelse";
            this.lblTextStandardavikelse.Size = new System.Drawing.Size(135, 20);
            this.lblTextStandardavikelse.TabIndex = 13;
            this.lblTextStandardavikelse.Text = "Standardavikelse:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Medelvärde:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1924, 914);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBeräkna);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraf)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTextPunkterInnanför;
        private System.Windows.Forms.Label lblIntPunkterInnanför;
        private System.Windows.Forms.Label lblTextAndelinnanför;
        private System.Windows.Forms.Label lblDecimalAndelInnanför;
        private System.Windows.Forms.Label lblTextAntalPunkter;
        private System.Windows.Forms.Label lblIntAntalPunkter;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnBeräkna;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblUndersöktFärg;
        private System.Windows.Forms.Button btnUndersöktFärg;
        private System.Windows.Forms.Button btnVäljFärg;
        private System.Windows.Forms.PictureBox pictureBoxGraf;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTextAntalPixlarPerIteration;
        private System.Windows.Forms.Label lblTextAntalIterationer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTextStandardavikelse;
    }
}

