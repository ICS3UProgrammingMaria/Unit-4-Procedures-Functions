namespace SwitchMaria
{
    partial class frmSwitch
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
            this.lblGradeLevel = new System.Windows.Forms.Label();
            this.txtuserGrade = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGradeLevel
            // 
            this.lblGradeLevel.AutoSize = true;
            this.lblGradeLevel.Font = new System.Drawing.Font("Prestige Elite Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradeLevel.Location = new System.Drawing.Point(12, 143);
            this.lblGradeLevel.Name = "lblGradeLevel";
            this.lblGradeLevel.Size = new System.Drawing.Size(270, 24);
            this.lblGradeLevel.TabIndex = 0;
            this.lblGradeLevel.Text = "Enter a grade level:";
            // 
            // txtuserGrade
            // 
            this.txtuserGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuserGrade.Location = new System.Drawing.Point(325, 142);
            this.txtuserGrade.Name = "txtuserGrade";
            this.txtuserGrade.Size = new System.Drawing.Size(100, 26);
            this.txtuserGrade.TabIndex = 1;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(182, 235);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(112, 43);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click_1);
            // 
            // frmSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 372);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtuserGrade);
            this.Controls.Add(this.lblGradeLevel);
            this.Name = "frmSwitch";
            this.Text = "Percentage Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGradeLevel;
        private System.Windows.Forms.TextBox txtuserGrade;
        private System.Windows.Forms.Button btnEnter;
    }
}

