namespace PassByRefMaria
{
    partial class frmPassByRef
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
            this.lblEnterNumber = new System.Windows.Forms.Label();
            this.btnRound = new System.Windows.Forms.Button();
            this.lblInputRound = new System.Windows.Forms.Label();
            this.nudRound = new System.Windows.Forms.NumericUpDown();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudRound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnterNumber
            // 
            this.lblEnterNumber.AutoSize = true;
            this.lblEnterNumber.BackColor = System.Drawing.Color.Teal;
            this.lblEnterNumber.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterNumber.Location = new System.Drawing.Point(13, 86);
            this.lblEnterNumber.Name = "lblEnterNumber";
            this.lblEnterNumber.Size = new System.Drawing.Size(324, 25);
            this.lblEnterNumber.TabIndex = 0;
            this.lblEnterNumber.Text = "Enter a decimal number: ";
            // 
            // btnRound
            // 
            this.btnRound.BackColor = System.Drawing.Color.LightGray;
            this.btnRound.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRound.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRound.Location = new System.Drawing.Point(213, 251);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(102, 39);
            this.btnRound.TabIndex = 1;
            this.btnRound.Text = "Round";
            this.btnRound.UseVisualStyleBackColor = false;
            this.btnRound.Click += new System.EventHandler(this.btnRound_Click);
            // 
            // lblInputRound
            // 
            this.lblInputRound.AutoSize = true;
            this.lblInputRound.BackColor = System.Drawing.Color.Teal;
            this.lblInputRound.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputRound.Location = new System.Drawing.Point(41, 164);
            this.lblInputRound.Name = "lblInputRound";
            this.lblInputRound.Size = new System.Drawing.Size(274, 66);
            this.lblInputRound.TabIndex = 2;
            this.lblInputRound.Text = "How many decimal places \r\ndo you want to round to?\r\n\r\n";
            // 
            // nudRound
            // 
            this.nudRound.BackColor = System.Drawing.Color.Teal;
            this.nudRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRound.Location = new System.Drawing.Point(354, 190);
            this.nudRound.Name = "nudRound";
            this.nudRound.Size = new System.Drawing.Size(87, 26);
            this.nudRound.TabIndex = 3;
            // 
            // txtnumber
            // 
            this.txtnumber.BackColor = System.Drawing.Color.Teal;
            this.txtnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumber.Location = new System.Drawing.Point(340, 103);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(129, 26);
            this.txtnumber.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PassByRefMaria.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(536, 479);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmPassByRef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 320);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.nudRound);
            this.Controls.Add(this.lblInputRound);
            this.Controls.Add(this.btnRound);
            this.Controls.Add(this.lblEnterNumber);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmPassByRef";
            this.Text = "Pass By Reference";
            ((System.ComponentModel.ISupportInitialize)(this.nudRound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterNumber;
        private System.Windows.Forms.Button btnRound;
        private System.Windows.Forms.Label lblInputRound;
        private System.Windows.Forms.NumericUpDown nudRound;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

