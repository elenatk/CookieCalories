
namespace CookieCalories
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCookieNumber = new System.Windows.Forms.Label();
            this.txtCookieNumber = new System.Windows.Forms.TextBox();
            this.btnTotalCalories = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCookieNumber
            // 
            this.lblCookieNumber.AutoSize = true;
            this.lblCookieNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCookieNumber.Location = new System.Drawing.Point(23, 53);
            this.lblCookieNumber.Name = "lblCookieNumber";
            this.lblCookieNumber.Size = new System.Drawing.Size(487, 46);
            this.lblCookieNumber.TabIndex = 0;
            this.lblCookieNumber.Text = "Enter a number of cookies";
            // 
            // txtCookieNumber
            // 
            this.txtCookieNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCookieNumber.Location = new System.Drawing.Point(539, 52);
            this.txtCookieNumber.Name = "txtCookieNumber";
            this.txtCookieNumber.Size = new System.Drawing.Size(203, 53);
            this.txtCookieNumber.TabIndex = 1;
            // 
            // btnTotalCalories
            // 
            this.btnTotalCalories.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTotalCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTotalCalories.Location = new System.Drawing.Point(152, 142);
            this.btnTotalCalories.Name = "btnTotalCalories";
            this.btnTotalCalories.Size = new System.Drawing.Size(387, 111);
            this.btnTotalCalories.TabIndex = 2;
            this.btnTotalCalories.Text = "Calculate the calories";
            this.btnTotalCalories.UseVisualStyleBackColor = false;
            this.btnTotalCalories.Click += new System.EventHandler(this.btnTotalCalories_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(37, 323);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(2, 48);
            this.lblTotal.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnTotalCalories);
            this.Controls.Add(this.txtCookieNumber);
            this.Controls.Add(this.lblCookieNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCookieNumber;
        private System.Windows.Forms.TextBox txtCookieNumber;
        private System.Windows.Forms.Button btnTotalCalories;
        private System.Windows.Forms.Label lblTotal;
    }
}

