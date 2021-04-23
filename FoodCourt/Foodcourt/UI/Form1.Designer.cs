namespace Foodcourt
{
    partial class FormMain
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
            this.btnKFC = new System.Windows.Forms.Button();
            this.btnAsen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRumahMakanUdaSayang = new System.Windows.Forms.Button();
            this.btnSatePadangPariaman = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Foodcourt";
            // 
            // btnKFC
            // 
            this.btnKFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKFC.Location = new System.Drawing.Point(70, 252);
            this.btnKFC.Name = "btnKFC";
            this.btnKFC.Size = new System.Drawing.Size(127, 63);
            this.btnKFC.TabIndex = 1;
            this.btnKFC.Text = "KFC";
            this.btnKFC.UseVisualStyleBackColor = true;
            this.btnKFC.Click += new System.EventHandler(this.btnKFC_Click);
            // 
            // btnAsen
            // 
            this.btnAsen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsen.Location = new System.Drawing.Point(250, 252);
            this.btnAsen.Name = "btnAsen";
            this.btnAsen.Size = new System.Drawing.Size(129, 63);
            this.btnAsen.TabIndex = 3;
            this.btnAsen.Text = "Nasi Ayam Asen";
            this.btnAsen.UseVisualStyleBackColor = true;
            this.btnAsen.Click += new System.EventHandler(this.btnAsen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pilih Toko Makanan :";
            // 
            // btnRumahMakanUdaSayang
            // 
            this.btnRumahMakanUdaSayang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRumahMakanUdaSayang.Location = new System.Drawing.Point(429, 252);
            this.btnRumahMakanUdaSayang.Name = "btnRumahMakanUdaSayang";
            this.btnRumahMakanUdaSayang.Size = new System.Drawing.Size(129, 63);
            this.btnRumahMakanUdaSayang.TabIndex = 5;
            this.btnRumahMakanUdaSayang.Text = "Rumah Makan Uda Sayang";
            this.btnRumahMakanUdaSayang.UseVisualStyleBackColor = true;
            this.btnRumahMakanUdaSayang.Click += new System.EventHandler(this.btnRumahMakanUdaSayang_Click);
            // 
            // btnSatePadangPariaman
            // 
            this.btnSatePadangPariaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSatePadangPariaman.Location = new System.Drawing.Point(602, 252);
            this.btnSatePadangPariaman.Name = "btnSatePadangPariaman";
            this.btnSatePadangPariaman.Size = new System.Drawing.Size(129, 63);
            this.btnSatePadangPariaman.TabIndex = 6;
            this.btnSatePadangPariaman.Text = "Sate Padang Pariaman";
            this.btnSatePadangPariaman.UseVisualStyleBackColor = true;
            this.btnSatePadangPariaman.Click += new System.EventHandler(this.btnSatePadangPariaman_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSatePadangPariaman);
            this.Controls.Add(this.btnRumahMakanUdaSayang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAsen);
            this.Controls.Add(this.btnKFC);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.Text = "Form Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKFC;
        private System.Windows.Forms.Button btnAsen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRumahMakanUdaSayang;
        private System.Windows.Forms.Button btnSatePadangPariaman;
    }
}

