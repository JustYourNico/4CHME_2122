using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace B4_SimpleCommunication_RGB_LED_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ListComPorts();
            cmdSend.Enabled = false;
            cmdClosePort.Enabled = false;
            cmdOpenPort.Enabled = true;
        }

        private void ListComPorts()
        {
            cboPort.Items.AddRange(SerialPort.GetPortNames());
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
                    // use selected com port as port name
                    serialPort1.PortName = cboPort.SelectedItem.ToString();


                    if (!serialPort1.IsOpen)
                    {
                        // establish serial connection if not already open
                        serialPort1.Open(); lblInfo.Text = "Port geöffnet";
                        cmdSend.Enabled = true;
                        cmdClosePort.Enabled = true;
                        cmdOpenPort.Enabled = false;
                    }

                    else
                    {
                        lblInfo.Text = "Port bereits geöffnet";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nIhre Verbindung wurde getrennt, bitte überprüfen Sie ihre Hardware!");


                //Resetting the buttons 
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
                    cmdSend.Enabled = false;
                    cmdClosePort.Enabled = false;
                    cmdOpenPort.Enabled = true;
                }
                else
                {
                    lblInfo.Text = "Port nicht geöffnet";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nIhre Verbindung wurde getrennt, bitte überprüfen Sie ihre Hardware!");

                //Resetting the buttons
                cmdOpenPort.Enabled = true;
                cmdClosePort.Enabled = false;
                cmdSend.Enabled = false;
                return;
            }
        }

        private void cmdSend_Click(object sender, EventArgs e)
        {
            int redValue;
            int blueValue;
            int greenValue;
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.WriteLine(string.Format("{0};{1};{2};",numRed.Value, numGreen.Value, numBlue.Value));
                    Thread.Sleep(200);
                    string data = serialPort1.ReadExisting();
                    lboSent.Items.Insert(0, data);
                }
                else
                {
                    lblInfo.Text = "Port nicht geöffnet";
                }
            }
            catch (Exception ex) //Addition 2 for the C#-program
            {
                MessageBox.Show(ex.Message + "\nIhre Verbindung wurde getrennt, bitte überprüfen Sie ihre Hardware und warten Sie bis die RGB wieder leuchtet bevor Sie sich verbinden.");

                serialPort1.Close();
                SetButtonsToDefault();
            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            Application.Exit();
        }
        private void SetButtonsToDefault()
        {
            cmdOpenPort.Enabled = true;
            cmdClosePort.Enabled = false;
            cmdSend.Enabled = false;
        }

        private void tbRed_ValueChanged(object sender, EventArgs e)
        {
            numRed.Value = tbRed.Value;
        }

        private void tbGreen_ValueChanged(object sender, EventArgs e)
        {
            numGreen.Value = tbGreen.Value;
        }

        private void tbBlue_Scroll(object sender, EventArgs e)
        {
            numBlue.Value = tbBlue.Value;
        }
    }
}
