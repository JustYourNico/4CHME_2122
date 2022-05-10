using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.IO;

namespace B4_SimpleCommunicationVisu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ListComPorts();
            cmdOpenPort.Enabled = true;
            cmdClosePort.Enabled = false;
            cmdSend.Enabled = false;
        }

        private void ListComPorts()
        {
            cboPort.Items.AddRange(SerialPort.GetPortNames());
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            Application.Exit();
        }

        private void cmdOpenPort_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboPort.SelectedIndex == -1)
                { // -1 indicated that no line was selected in the dropdown box
                    MessageBox.Show("Bitte COM-Port auswählen!");
                }
                else
                {
                    // define the selected com port as port name
                    serialPort1.PortName = cboPort.SelectedItem.ToString();

                    if (!serialPort1.IsOpen)
                    {
                        // establish serial connection if not already open
                        serialPort1.Open(); lblInfo.Text = "Port geöffnet";
                        // toggle open / close buttons
                        cmdOpenPort.Enabled = false;
                        cmdClosePort.Enabled = true;
                        cmdSend.Enabled = true;
                    }
                    else
                    {
                        lblInfo.Text = "Port bereits geöffnet";
                    }
                }
            }
            catch(Exception ex) //Addition 2 for the C#-program
            {
                MessageBox.Show(ex.Message + "\nIhre Verbindung wurde getrennt, bitte überprüfen Sie ihre Hardware!");

                //Resetting the buttons to default-status
                cmdOpenPort.Enabled = true;
                cmdClosePort.Enabled = false;
                cmdSend.Enabled = false;
                return;
            }           
        }

        private void cmdClosePort_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    lblInfo.Text = "Port wurde geschlossen";
                    cmdOpenPort.Enabled = true;
                    cmdClosePort.Enabled = false;
                    cmdSend.Enabled = false;
                }
                else
                {
                    lblInfo.Text = "Port nicht geöffnet";
                }
            }
            catch(Exception ex) //Addition 2 for the C#-program
            {
                MessageBox.Show(ex.Message + "\nIhre Verbindung wurde getrennt, bitte überprüfen Sie ihre Hardware!");

                //Resetting the buttons to default-status
                cmdOpenPort.Enabled = true;
                cmdClosePort.Enabled = false;
                cmdSend.Enabled = false;
                return;
            }           
        }

        private void cmdSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.WriteLine(numData.Value.ToString());
                    Thread.Sleep(200);
                    string data = serialPort1.ReadExisting();
                    lboSent.Items.Insert(0, data); //Addition 1 for the C#-program
                }
                else
                {
                    lblInfo.Text = "Port nicht geöffnet";
                }
            }
            catch(Exception ex) //Addition 2 for the C#-program
            {
                MessageBox.Show(ex.Message + "\nIhre Verbindung wurde getrennt, bitte überprüfen Sie ihre Hardware!");

                //Resetting the buttons to default-status
                cmdOpenPort.Enabled = true;
                cmdClosePort.Enabled = false;
                cmdSend.Enabled = false;
                return;
            }           
        }

    }
}
