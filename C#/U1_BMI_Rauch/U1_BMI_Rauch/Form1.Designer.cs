
namespace U1_BMI_Rauch
{
    partial class BMICalc
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
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblKg = new System.Windows.Forms.Label();
            this.lblCm = new System.Windows.Forms.Label();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.cmdCalcBMI = new System.Windows.Forms.Button();
            this.cmdResetInput = new System.Windows.Forms.Button();
            this.cmdEndProgram = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.grpGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(35, 37);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(67, 25);
            this.lblHeight.TabIndex = 0;
            this.lblHeight.Text = "Größe";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(35, 73);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(82, 25);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "Gewicht";
            // 
            // txtHeight
            // 
            this.txtHeight.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(208, 37);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(119, 30);
            this.txtHeight.TabIndex = 2;
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(208, 73);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(119, 30);
            this.txtWeight.TabIndex = 3;
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.BackColor = System.Drawing.Color.Transparent;
            this.lblKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKg.Location = new System.Drawing.Point(323, 73);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(33, 25);
            this.lblKg.TabIndex = 4;
            this.lblKg.Text = "kg";
            // 
            // lblCm
            // 
            this.lblCm.AutoSize = true;
            this.lblCm.BackColor = System.Drawing.Color.Transparent;
            this.lblCm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCm.Location = new System.Drawing.Point(323, 40);
            this.lblCm.Name = "lblCm";
            this.lblCm.Size = new System.Drawing.Size(38, 25);
            this.lblCm.TabIndex = 5;
            this.lblCm.Text = "cm";
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rdoMale);
            this.grpGender.Controls.Add(this.rdoFemale);
            this.grpGender.Location = new System.Drawing.Point(476, 37);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(269, 66);
            this.grpGender.TabIndex = 6;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Geschlecht";
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdoMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMale.Location = new System.Drawing.Point(141, 22);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(111, 29);
            this.rdoMale.TabIndex = 1;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "männlich";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFemale.Location = new System.Drawing.Point(7, 22);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(102, 29);
            this.rdoFemale.TabIndex = 0;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "weiblich";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // cmdCalcBMI
            // 
            this.cmdCalcBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCalcBMI.Location = new System.Drawing.Point(40, 204);
            this.cmdCalcBMI.Name = "cmdCalcBMI";
            this.cmdCalcBMI.Size = new System.Drawing.Size(252, 44);
            this.cmdCalcBMI.TabIndex = 7;
            this.cmdCalcBMI.Text = "BMI Berechnen";
            this.cmdCalcBMI.UseVisualStyleBackColor = true;
            this.cmdCalcBMI.Click += new System.EventHandler(this.cmdCalcBMI_Click);
            // 
            // cmdResetInput
            // 
            this.cmdResetInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdResetInput.Location = new System.Drawing.Point(40, 268);
            this.cmdResetInput.Name = "cmdResetInput";
            this.cmdResetInput.Size = new System.Drawing.Size(252, 45);
            this.cmdResetInput.TabIndex = 8;
            this.cmdResetInput.Text = "Eingabe Zurücksetzen";
            this.cmdResetInput.UseVisualStyleBackColor = true;
            this.cmdResetInput.Click += new System.EventHandler(this.cmdResetInput_Click);
            // 
            // cmdEndProgram
            // 
            this.cmdEndProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEndProgram.Location = new System.Drawing.Point(40, 331);
            this.cmdEndProgram.Name = "cmdEndProgram";
            this.cmdEndProgram.Size = new System.Drawing.Size(252, 46);
            this.cmdEndProgram.TabIndex = 9;
            this.cmdEndProgram.Text = "Programm Beenden";
            this.cmdEndProgram.UseVisualStyleBackColor = true;
            this.cmdEndProgram.Click += new System.EventHandler(this.cmdEndProgram_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(310, 214);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(183, 75);
            this.lblOutput.TabIndex = 10;
            this.lblOutput.Text = "Mann/Frau\r\nAusgabe Ergebniss\r\nInterpretation\r\n";
            // 
            // BMICalc
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.cmdEndProgram);
            this.Controls.Add(this.cmdResetInput);
            this.Controls.Add(this.cmdCalcBMI);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblKg);
            this.Controls.Add(this.lblCm);
            this.Name = "BMICalc";
            this.Text = "BMI-Rechner Rauch";
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblKg;
        private System.Windows.Forms.Label lblCm;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.Button cmdCalcBMI;
        private System.Windows.Forms.Button cmdResetInput;
        private System.Windows.Forms.Button cmdEndProgram;
        private System.Windows.Forms.Label lblOutput;
    }
}

