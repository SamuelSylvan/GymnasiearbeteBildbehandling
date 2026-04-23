
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
            this.btnVit = new System.Windows.Forms.Button();
            this.btnSvart = new System.Windows.Forms.Button();
            this.btnVäljFärg = new System.Windows.Forms.Button();
            this.btnUndersöktFärg = new System.Windows.Forms.Button();
            this.lblUndersöktFärg = new System.Windows.Forms.Label();
            this.pictureBoxGraf = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraf)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTextPunkterInnanför
            // 
            this.lblTextPunkterInnanför.AutoSize = true;
            this.lblTextPunkterInnanför.Location = new System.Drawing.Point(6, 32);
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
            this.lblTextAntalPunkter.Location = new System.Drawing.Point(110, 55);
            this.lblTextAntalPunkter.Name = "lblTextAntalPunkter";
            this.lblTextAntalPunkter.Size = new System.Drawing.Size(105, 20);
            this.lblTextAntalPunkter.TabIndex = 5;
            this.lblTextAntalPunkter.Text = "AntalPunkter:";
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
            this.btnBeräkna.Location = new System.Drawing.Point(265, 662);
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
            this.groupBox1.Location = new System.Drawing.Point(54, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 146);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVit);
            this.groupBox2.Controls.Add(this.btnSvart);
            this.groupBox2.Controls.Add(this.btnVäljFärg);
            this.groupBox2.Controls.Add(this.btnUndersöktFärg);
            this.groupBox2.Controls.Add(this.lblUndersöktFärg);
            this.groupBox2.Location = new System.Drawing.Point(54, 504);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 152);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnVit
            // 
            this.btnVit.Location = new System.Drawing.Point(94, 101);
            this.btnVit.Name = "btnVit";
            this.btnVit.Size = new System.Drawing.Size(82, 37);
            this.btnVit.TabIndex = 13;
            this.btnVit.Text = "Vit";
            this.btnVit.UseVisualStyleBackColor = true;
            this.btnVit.Click += new System.EventHandler(this.btnVit_Click);
            // 
            // btnSvart
            // 
            this.btnSvart.Location = new System.Drawing.Point(94, 60);
            this.btnSvart.Name = "btnSvart";
            this.btnSvart.Size = new System.Drawing.Size(82, 35);
            this.btnSvart.TabIndex = 12;
            this.btnSvart.Text = "Svart";
            this.btnSvart.UseVisualStyleBackColor = true;
            this.btnSvart.Click += new System.EventHandler(this.btnSvart_Click);
            // 
            // btnVäljFärg
            // 
            this.btnVäljFärg.Location = new System.Drawing.Point(94, 23);
            this.btnVäljFärg.Name = "btnVäljFärg";
            this.btnVäljFärg.Size = new System.Drawing.Size(82, 35);
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
            this.btnUndersöktFärg.Location = new System.Drawing.Point(183, 29);
            this.btnUndersöktFärg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUndersöktFärg.Name = "btnUndersöktFärg";
            this.btnUndersöktFärg.Size = new System.Drawing.Size(86, 97);
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
            this.pictureBoxGraf.Location = new System.Drawing.Point(39, 12);
            this.pictureBoxGraf.Name = "pictureBoxGraf";
            this.pictureBoxGraf.Size = new System.Drawing.Size(313, 322);
            this.pictureBoxGraf.TabIndex = 10;
            this.pictureBoxGraf.TabStop = false;
            this.pictureBoxGraf.Click += new System.EventHandler(this.pictureBoxGraf_Click);
            this.pictureBoxGraf.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxGraf_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1924, 732);
            this.Controls.Add(this.pictureBoxGraf);
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
        private System.Windows.Forms.Button btnVit;
        private System.Windows.Forms.Button btnSvart;
        private System.Windows.Forms.PictureBox pictureBoxGraf;
    }
}

