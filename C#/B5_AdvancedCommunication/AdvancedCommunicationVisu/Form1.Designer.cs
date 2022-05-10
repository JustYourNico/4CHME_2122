namespace AdvancedCommunicationVisu
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
            this.lblComInfo = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lboDataToSend = new System.Windows.Forms.ListBox();
            this.lblDelayTime = new System.Windows.Forms.Label();
            this.lblDelay = new System.Windows.Forms.Label();
            this.lboDataToLog = new System.Windows.Forms.ListBox();
            this.lblDataToSend = new System.Windows.Forms.Label();
            this.lblDataReceived = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comunicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closePortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsComPort = new System.Windows.Forms.ToolStripComboBox();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clearListboxesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sendDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbDelayTime = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDelayTime)).BeginInit();
            this.SuspendLayout();
            // 
            // lblComInfo
            // 
            this.lblComInfo.AutoSize = true;
            this.lblComInfo.Location = new System.Drawing.Point(457, 44);
            this.lblComInfo.Name = "lblComInfo";
            this.lblComInfo.Size = new System.Drawing.Size(33, 25);
            this.lblComInfo.TabIndex = 2;
            this.lblComInfo.Text = "---";
            // 
            // lboDataToSend
            // 
            this.lboDataToSend.FormattingEnabled = true;
            this.lboDataToSend.ItemHeight = 25;
            this.lboDataToSend.Location = new System.Drawing.Point(56, 175);
            this.lboDataToSend.Name = "lboDataToSend";
            this.lboDataToSend.Size = new System.Drawing.Size(369, 304);
            this.lboDataToSend.TabIndex = 12;
            // 
            // lblDelayTime
            // 
            this.lblDelayTime.AutoSize = true;
            this.lblDelayTime.Location = new System.Drawing.Point(52, 51);
            this.lblDelayTime.Name = "lblDelayTime";
            this.lblDelayTime.Size = new System.Drawing.Size(252, 25);
            this.lblDelayTime.TabIndex = 16;
            this.lblDelayTime.Text = "Timespan between sending";
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(287, 91);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(38, 25);
            this.lblDelay.TabIndex = 17;
            this.lblDelay.Text = "ms";
            // 
            // lboDataToLog
            // 
            this.lboDataToLog.Enabled = false;
            this.lboDataToLog.FormattingEnabled = true;
            this.lboDataToLog.ItemHeight = 25;
            this.lboDataToLog.Location = new System.Drawing.Point(461, 175);
            this.lboDataToLog.Name = "lboDataToLog";
            this.lboDataToLog.Size = new System.Drawing.Size(369, 304);
            this.lboDataToLog.TabIndex = 18;
            // 
            // lblDataToSend
            // 
            this.lblDataToSend.AutoSize = true;
            this.lblDataToSend.Location = new System.Drawing.Point(56, 147);
            this.lblDataToSend.Name = "lblDataToSend";
            this.lblDataToSend.Size = new System.Drawing.Size(154, 25);
            this.lblDataToSend.TabIndex = 19;
            this.lblDataToSend.Text = "Data for sending";
            // 
            // lblDataReceived
            // 
            this.lblDataReceived.AutoSize = true;
            this.lblDataReceived.Location = new System.Drawing.Point(456, 150);
            this.lblDataReceived.Name = "lblDataReceived";
            this.lblDataReceived.Size = new System.Drawing.Size(148, 25);
            this.lblDataReceived.TabIndex = 20;
            this.lblDataReceived.Text = "Data for logging";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comunicationToolStripMenuItem,
            this.operationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(924, 28);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // comunicationToolStripMenuItem
            // 
            this.comunicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPortToolStripMenuItem,
            this.closePortToolStripMenuItem});
            this.comunicationToolStripMenuItem.Name = "comunicationToolStripMenuItem";
            this.comunicationToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.comunicationToolStripMenuItem.Text = "comunication";
            // 
            // openPortToolStripMenuItem
            // 
            this.openPortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsComPort});
            this.openPortToolStripMenuItem.Name = "openPortToolStripMenuItem";
            this.openPortToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openPortToolStripMenuItem.Text = "open port";
            // 
            // closePortToolStripMenuItem
            // 
            this.closePortToolStripMenuItem.Name = "closePortToolStripMenuItem";
            this.closePortToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.closePortToolStripMenuItem.Text = "close port";
            // 
            // tsComPort
            // 
            this.tsComPort.Name = "tsComPort";
            this.tsComPort.Size = new System.Drawing.Size(121, 28);
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDataToolStripMenuItem,
            this.toolStripSeparator1,
            this.clearListboxesToolStripMenuItem,
            this.toolStripSeparator2,
            this.sendDataToolStripMenuItem,
            this.logDataToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.operationsToolStripMenuItem.Text = "operations";
            // 
            // loadDataToolStripMenuItem
            // 
            this.loadDataToolStripMenuItem.Name = "loadDataToolStripMenuItem";
            this.loadDataToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loadDataToolStripMenuItem.Text = "load data";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // clearListboxesToolStripMenuItem
            // 
            this.clearListboxesToolStripMenuItem.Name = "clearListboxesToolStripMenuItem";
            this.clearListboxesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clearListboxesToolStripMenuItem.Text = "clear listboxes";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // sendDataToolStripMenuItem
            // 
            this.sendDataToolStripMenuItem.Name = "sendDataToolStripMenuItem";
            this.sendDataToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sendDataToolStripMenuItem.Text = "send data";
            // 
            // logDataToolStripMenuItem
            // 
            this.logDataToolStripMenuItem.Name = "logDataToolStripMenuItem";
            this.logDataToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.logDataToolStripMenuItem.Text = "log data";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(221, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "exit";
            // 
            // tbDelayTime
            // 
            this.tbDelayTime.Location = new System.Drawing.Point(61, 88);
            this.tbDelayTime.Name = "tbDelayTime";
            this.tbDelayTime.Size = new System.Drawing.Size(220, 56);
            this.tbDelayTime.TabIndex = 22;
            this.tbDelayTime.Scroll += new System.EventHandler(this.tbDelayTime_Scroll_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 488);
            this.ControlBox = false;
            this.Controls.Add(this.tbDelayTime);
            this.Controls.Add(this.lblDataReceived);
            this.Controls.Add(this.lblDataToSend);
            this.Controls.Add(this.lboDataToLog);
            this.Controls.Add(this.lblDelay);
            this.Controls.Add(this.lblDelayTime);
            this.Controls.Add(this.lboDataToSend);
            this.Controls.Add(this.lblComInfo);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Advanced communication with µC";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDelayTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label lblComInfo;
    private System.IO.Ports.SerialPort serialPort1;
    private System.Windows.Forms.ListBox lboDataToSend;
    private System.Windows.Forms.Label lblDelayTime;
    private System.Windows.Forms.Label lblDelay;
    private System.Windows.Forms.ListBox lboDataToLog;
    private System.Windows.Forms.Label lblDataToSend;
    private System.Windows.Forms.Label lblDataReceived;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem comunicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox tsComPort;
        private System.Windows.Forms.ToolStripMenuItem closePortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem clearListboxesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sendDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TrackBar tbDelayTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

