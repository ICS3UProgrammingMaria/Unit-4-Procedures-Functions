namespace ConvertToFareMaria
{
    partial class frmConvertToFahre
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblEnterTemp = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.picBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(151, 197);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(171, 56);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert to Fahrenheit";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblEnterTemp
            // 
            this.lblEnterTemp.AutoSize = true;
            this.lblEnterTemp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEnterTemp.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterTemp.Location = new System.Drawing.Point(33, 93);
            this.lblEnterTemp.Name = "lblEnterTemp";
            this.lblEnterTemp.Size = new System.Drawing.Size(231, 52);
            this.lblEnterTemp.TabIndex = 1;
            this.lblEnterTemp.Text = "Enter the temperature \r\nin degrees Celsius:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(299, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 29);
            this.textBox1.TabIndex = 2;
            // 
            // picBackground
            // 
            this.picBackground.Image = global::ConvertToFareMaria.Properties.Resources.Winter_of_Solitude_1;
            this.picBackground.Location = new System.Drawing.Point(-6, -5);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(489, 308);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackground.TabIndex = 3;
            this.picBackground.TabStop = false;
            // 
            // frmConvertToFahre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 300);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblEnterTemp);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.picBackground);
            this.Name = "frmConvertToFahre";
            this.Text = "Convert to Fahrenheit";
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblEnterTemp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox picBackground;
    }
}

