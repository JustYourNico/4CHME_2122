namespace B4_SimpleCommunicationVisu
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
            this.components = new System.ComponentModel.Container();
            this.cmdClosePort = new System.Windows.Forms.Button();
            this.cmdOpenPort = new System.Windows.Forms.Button();
            this.cmdSend = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.numData = new System.Windows.Forms.NumericUpDown();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lboSent = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numData)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdClosePort
            // 
            this.cmdClosePort.Location = new System.Drawing.Point(543, 158);
            this.cmdClosePort.Margin = new System.Windows.Forms.Padding(4);
            this.cmdClosePort.Name = "cmdClosePort";
            this.cmdClosePort.Size = new System.Drawing.Size(111, 52);
            this.cmdClosePort.TabIndex = 0;
            this.cmdClosePort.Text = "Port schließen";
            this.cmdClosePort.UseVisualStyleBackColor = true;
            this.cmdClosePort.Click += new System.EventHandler(this.cmdClosePort_Click);
            // 
            // cmdOpenPort
            // 
            this.cmdOpenPort.Location = new System.Drawing.Point(543, 76);
            this.cmdOpenPort.Margin = new System.Windows.Forms.Padding(4);
            this.cmdOpenPort.Name = "cmdOpenPort";
            this.cmdOpenPort.Size = new System.Drawing.Size(111, 52);
            this.cmdOpenPort.TabIndex = 1;
            this.cmdOpenPort.Text = "Port öffnen";
            this.cmdOpenPort.UseVisualStyleBackColor = true;
            this.cmdOpenPort.Click += new System.EventHandler(this.cmdOpenPort_Click);
            // 
            // cmdSend
            // 
            this.cmdSend.Location = new System.Drawing.Point(543, 238);
            this.cmdSend.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSend.Name = "cmdSend";
            this.cmdSend.Size = new System.Drawing.Size(111, 52);
            this.cmdSend.TabIndex = 2;
            this.cmdSend.Text = "Zahl senden";
            this.cmdSend.UseVisualStyleBackColor = true;
            this.cmdSend.Click += new System.EventHandler(this.cmdSend_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(543, 317);
            this.cmdExit.Margin = new System.Windows.Forms.Padding(4);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(111, 52);
            this.cmdExit.TabIndex = 3;
            this.cmdExit.Text = "Programm beenden";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cboPort
            // 
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Location = new System.Drawing.Point(47, 91);
            this.cboPort.Margin = new System.Windows.Forms.Padding(4);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(152, 24);
            this.cboPort.TabIndex = 4;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(47, 54);
            this.lblPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(70, 17);
            this.lblPort.TabIndex = 5;
            this.lblPort.Text = "COM-Port";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(43, 143);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 17);
            this.lblInfo.TabIndex = 6;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(43, 184);
            this.lblNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(36, 17);
            this.lblNum.TabIndex = 7;
            this.lblNum.Text = "Zahl";
            // 
            // numData
            // 
            this.numData.Location = new System.Drawing.Point(105, 182);
            this.numData.Margin = new System.Windows.Forms.Padding(4);
            this.numData.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numData.Name = "numData";
            this.numData.Size = new System.Drawing.Size(160, 22);
            this.numData.TabIndex = 8;
            // 
            // lboSent
            // 
            this.lboSent.FormattingEnabled = true;
            this.lboSent.ItemHeight = 16;
            this.lboSent.Location = new System.Drawing.Point(50, 253);
            this.lboSent.Margin = new System.Windows.Forms.Padding(2);
            this.lboSent.Name = "lboSent";
            this.lboSent.Size = new System.Drawing.Size(274, 116);
            this.lboSent.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(704, 404);
            this.Controls.Add(this.lboSent);
            this.Controls.Add(this.numData);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.cboPort);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdSend);
            this.Controls.Add(this.cmdOpenPort);
            this.Controls.Add(this.cmdClosePort);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Mikrocontroller-Kommunikation";
            ((System.ComponentModel.ISupportInitialize)(this.numData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdClosePort;
        private System.Windows.Forms.Button cmdOpenPort;
        private System.Windows.Forms.Button cmdSend;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.ComboBox cboPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.NumericUpDown numData;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ListBox lboSent;
    }
}

