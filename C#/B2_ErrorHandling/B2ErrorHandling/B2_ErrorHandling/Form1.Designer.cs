namespace B2_ErrorHandling
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.cmdDivide1 = new System.Windows.Forms.Button();
            this.cmdDivide2 = new System.Windows.Forms.Button();
            this.cmdDivide3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumber1
            // 
            this.txtNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber1.Location = new System.Drawing.Point(144, 62);
            this.txtNumber1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(199, 26);
            this.txtNumber1.TabIndex = 0;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber2.Location = new System.Drawing.Point(144, 146);
            this.txtNumber2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(199, 26);
            this.txtNumber2.TabIndex = 1;
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber1.Location = new System.Drawing.Point(43, 62);
            this.lblNumber1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(53, 20);
            this.lblNumber1.TabIndex = 2;
            this.lblNumber1.Text = "Zahl 1";
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber2.Location = new System.Drawing.Point(43, 153);
            this.lblNumber2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(53, 20);
            this.lblNumber2.TabIndex = 3;
            this.lblNumber2.Text = "Zahl 2";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(43, 246);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(72, 20);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Ergebnis";
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(144, 239);
            this.txtResult.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(199, 26);
            this.txtResult.TabIndex = 5;
            // 
            // cmdDivide1
            // 
            this.cmdDivide1.Location = new System.Drawing.Point(430, 53);
            this.cmdDivide1.Name = "cmdDivide1";
            this.cmdDivide1.Size = new System.Drawing.Size(124, 44);
            this.cmdDivide1.TabIndex = 6;
            this.cmdDivide1.Text = "/";
            this.cmdDivide1.UseVisualStyleBackColor = true;
            this.cmdDivide1.Click += new System.EventHandler(this.cmdDivide1_Click);
            // 
            // cmdDivide2
            // 
            this.cmdDivide2.Location = new System.Drawing.Point(430, 141);
            this.cmdDivide2.Name = "cmdDivide2";
            this.cmdDivide2.Size = new System.Drawing.Size(124, 44);
            this.cmdDivide2.TabIndex = 7;
            this.cmdDivide2.Text = "Save /";
            this.cmdDivide2.UseVisualStyleBackColor = true;
            this.cmdDivide2.Click += new System.EventHandler(this.cmdDivide2_Click);
            // 
            // cmdDivide3
            // 
            this.cmdDivide3.Location = new System.Drawing.Point(430, 234);
            this.cmdDivide3.Name = "cmdDivide3";
            this.cmdDivide3.Size = new System.Drawing.Size(124, 44);
            this.cmdDivide3.TabIndex = 8;
            this.cmdDivide3.Text = "Try - Catch";
            this.cmdDivide3.UseVisualStyleBackColor = true;
            this.cmdDivide3.Click += new System.EventHandler(this.cmdDivide3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 328);
            this.Controls.Add(this.cmdDivide3);
            this.Controls.Add(this.cmdDivide2);
            this.Controls.Add(this.cmdDivide1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.lblNumber1);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Fehlerbehandlung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button cmdDivide1;
        private System.Windows.Forms.Button cmdDivide2;
        private System.Windows.Forms.Button cmdDivide3;
    }
}

