namespace ADOUygulaması
{
    partial class BasarılıOdeme
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
            this.button5 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(83, 388);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(260, 43);
            this.button5.TabIndex = 193;
            this.button5.Text = "SAYFAYI KAPAT";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Black;
            this.label15.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Maroon;
            this.label15.Location = new System.Drawing.Point(57, 448);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(309, 15);
            this.label15.TabIndex = 197;
            this.label15.Text = "ADO\'yu Tercih Ettiğiniz İçin Teşekkür Ederiz";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Black;
            this.label20.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Lime;
            this.label20.Location = new System.Drawing.Point(19, 286);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(405, 66);
            this.label20.TabIndex = 198;
            this.label20.Text = "       ÖDEME BAŞARILI\r\nBİR ŞEKİLDE GERÇEKLEŞTİ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ADOUygulaması.Properties.Resources.Tick_Green_Check_Mark_PNG_Image1;
            this.pictureBox1.Location = new System.Drawing.Point(66, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 199;
            this.pictureBox1.TabStop = false;
            // 
            // BasarılıOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(437, 478);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button5);
            this.Name = "BasarılıOdeme";
            this.Text = "Başarılı Ödeme";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}