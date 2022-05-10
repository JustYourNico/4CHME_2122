
namespace B4_SimpleCommunication_RGB_LED_CS
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
            this.components = new System.ComponentModel.Container();
            this.numRed = new System.Windows.Forms.NumericUpDown();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdSend = new System.Windows.Forms.Button();
            this.cmdOpenPort = new System.Windows.Forms.Button();
            this.cmdClosePort = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lboSent = new System.Windows.Forms.ListBox();
            this.numGreen = new System.Windows.Forms.NumericUpDown();
            this.lblGreen = new System.Windows.Forms.Label();
            this.numBlue = new System.Windows.Forms.NumericUpDown();
            this.LblBlue = new System.Windows.Forms.Label();
            this.tbRed = new System.Windows.Forms.TrackBar();
            this.tbGreen = new System.Windows.Forms.TrackBar();
            this.tbBlue = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.numRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // numRed
            // 
            this.numRed.Location = new System.Drawing.Point(82, 147);
            this.numRed.Margin = new System.Windows.Forms.Padding(4);
            this.numRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numRed.Name = "numRed";
            this.numRed.Size = new System.Drawing.Size(160, 22);
            this.numRed.TabIndex = 19;
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(25, 147);
            this.lblRed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(30, 17);
            this.lblRed.TabIndex = 18;
            this.lblRed.Text = "Rot";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(95, 157);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 17);
            this.lblInfo.TabIndex = 17;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(25, 50);
            this.lblPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(70, 17);
            this.lblPort.TabIndex = 16;
            this.lblPort.Text = "COM-Port";
            // 
            // cboPort
            // 
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Location = new System.Drawing.Point(28, 78);
            this.cboPort.Margin = new System.Windows.Forms.Padding(4);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(152, 24);
            this.cboPort.TabIndex = 15;
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(581, 331);
            this.cmdExit.Margin = new System.Windows.Forms.Padding(4);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(111, 52);
            this.cmdExit.TabIndex = 14;
            this.cmdExit.Text = "Programm beenden";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdSend
            // 
            this.cmdSend.Location = new System.Drawing.Point(581, 238);
            this.cmdSend.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSend.Name = "cmdSend";
            this.cmdSend.Size = new System.Drawing.Size(111, 52);
            this.cmdSend.TabIndex = 13;
            this.cmdSend.Text = "Zahl senden";
            this.cmdSend.UseVisualStyleBackColor = true;
            this.cmdSend.Click += new System.EventHandler(this.cmdSend_Click);
            // 
            // cmdOpenPort
            // 
            this.cmdOpenPort.Location = new System.Drawing.Point(581, 50);
            this.cmdOpenPort.Margin = new System.Windows.Forms.Padding(4);
            this.cmdOpenPort.Name = "cmdOpenPort";
            this.cmdOpenPort.Size = new System.Drawing.Size(111, 52);
            this.cmdOpenPort.TabIndex = 12;
            this.cmdOpenPort.Text = "Port öffnen";
            this.cmdOpenPort.UseVisualStyleBackColor = true;
            this.cmdOpenPort.Click += new System.EventHandler(this.cmdOpenPort_Click);
            // 
            // cmdClosePort
            // 
            this.cmdClosePort.Location = new System.Drawing.Point(581, 139);
            this.cmdClosePort.Margin = new System.Windows.Forms.Padding(4);
            this.cmdClosePort.Name = "cmdClosePort";
            this.cmdClosePort.Size = new System.Drawing.Size(111, 52);
            this.cmdClosePort.TabIndex = 11;
            this.cmdClosePort.Text = "Port schließen";
            this.cmdClosePort.UseVisualStyleBackColor = true;
            this.cmdClosePort.Click += new System.EventHandler(this.cmdClosePort_Click);
            // 
            // lboSent
            // 
            this.lboSent.FormattingEnabled = true;
            this.lboSent.ItemHeight = 16;
            this.lboSent.Location = new System.Drawing.Point(28, 300);
            this.lboSent.Margin = new System.Windows.Forms.Padding(2);
            this.lboSent.Name = "lboSent";
            this.lboSent.Size = new System.Drawing.Size(274, 116);
            this.lboSent.TabIndex = 20;
            // 
            // numGreen
            // 
            this.numGreen.Location = new System.Drawing.Point(82, 201);
            this.numGreen.Margin = new System.Windows.Forms.Padding(4);
            this.numGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numGreen.Name = "numGreen";
            this.numGreen.Size = new System.Drawing.Size(160, 22);
            this.numGreen.TabIndex = 22;
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(25, 203);
            this.lblGreen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(48, 17);
            this.lblGreen.TabIndex = 21;
            this.lblGreen.Text = "Gruen";
            // 
            // numBlue
            // 
            this.numBlue.Location = new System.Drawing.Point(82, 254);
            this.numBlue.Margin = new System.Windows.Forms.Padding(4);
            this.numBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numBlue.Name = "numBlue";
            this.numBlue.Size = new System.Drawing.Size(160, 22);
            this.numBlue.TabIndex = 24;
            // 
            // LblBlue
            // 
            this.LblBlue.AutoSize = true;
            this.LblBlue.Location = new System.Drawing.Point(25, 254);
            this.LblBlue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBlue.Name = "LblBlue";
            this.LblBlue.Size = new System.Drawing.Size(36, 17);
            this.LblBlue.TabIndex = 23;
            this.LblBlue.Text = "Blau";
            // 
            // tbRed
            // 
            this.tbRed.Location = new System.Drawing.Point(289, 147);
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(232, 56);
            this.tbRed.TabIndex = 25;
            this.tbRed.ValueChanged += new System.EventHandler(this.tbRed_ValueChanged);
            // 
            // tbGreen
            // 
            this.tbGreen.Location = new System.Drawing.Point(289, 197);
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(232, 56);
            this.tbGreen.TabIndex = 26;
            this.tbGreen.ValueChanged += new System.EventHandler(this.tbGreen_ValueChanged);
            // 
            // tbBlue
            // 
            this.tbBlue.Location = new System.Drawing.Point(289, 254);
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(232, 56);
            this.tbBlue.TabIndex = 27;
            this.tbBlue.Scroll += new System.EventHandler(this.tbBlue_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.lboSent);
            this.Controls.Add(this.tbBlue);
            this.Controls.Add(this.tbGreen);
            this.Controls.Add(this.tbRed);
            this.Controls.Add(this.numBlue);
            this.Controls.Add(this.LblBlue);
            this.Controls.Add(this.numGreen);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.numRed);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.cboPort);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdSend);
            this.Controls.Add(this.cmdOpenPort);
            this.Controls.Add(this.cmdClosePort);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numRed;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.ComboBox cboPort;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdSend;
        private System.Windows.Forms.Button cmdOpenPort;
        private System.Windows.Forms.Button cmdClosePort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ListBox lboSent;
        private System.Windows.Forms.NumericUpDown numGreen;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.NumericUpDown numBlue;
        private System.Windows.Forms.Label LblBlue;
        private System.Windows.Forms.TrackBar tbRed;
        private System.Windows.Forms.TrackBar tbGreen;
        private System.Windows.Forms.TrackBar tbBlue;
    }
}

