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

/***
 * 
 * @author  Susanne
 * @date    1.6.2021
 * @brief   advanced communication between µC and WinForm
 * @details values to be sent can be read from a file
 *          and are displayed in a list box
 *          a track bar is used to set the delay time 
 *          between each sending of data to the µC
 *          received data from the µC are displayed in
 *          a second list box, the data can be saved to 
 *          a file on request
 * 
 * */

namespace AdvancedCommunicationVisu
{
    public partial class Form1 : Form
    {
        /*** private object variables used within the form */
        private string saveFileName;
        private string openFileName;
        private string[] sendData;
        private int transmitIndex = -1;

        public Form1()
        {
            InitializeComponent();
            listComPorts();
            configureTrackBar();
        }

        /*** 
         * set minimum and maximum value of trackbar 
         * set intervals for slider changes
         * display actual value for delay time 
         */
        private void configureTrackBar()
        {
            tbDelayTime.Minimum = 200;
            tbDelayTime.Maximum = 2000;
        }

        /***
         * display all connected COM ports in a combo box
         */
        private void listComPorts()
        {
            tsComPort.Items.AddRange(SerialPort.GetPortNames());
        }

        /***
        * menu item load data 
        * opens file dialog and loads data into string array and list box 
        */
        private void msOpLoadData_Click(object sender, EventArgs e)
        {

        }

        /***
        * menu item clear listboxes 
        * clears the content of both list boxes
        */
        private void msOpClearListBoxes_Click(object sender, EventArgs e)
        {

        }

        /***
         * display current value of task bar 
         */
        private void tbDelayTime_Scroll(object sender, EventArgs e)
        {

        }

        /***
        * menu item activated for opening of com port
        */
        private void msComOpenPort_Click(object sender, EventArgs e)
        {
            //if (tsCboPort.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a com port!");
            }
            //else
            {
                try
                {
                    //serialPort1.PortName = tsCboPort.SelectedItem.ToString();
                    if (!serialPort1.IsOpen)
                    {
                        serialPort1.Open();
                        lblComInfo.Text = "com port successfully opened";
                    }
                    else
                    {
                        MessageBox.Show("com port already open!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem while opening port" +
                        System.Environment.NewLine +
                        ex.Message);
                }
            }
        }

        /***
         * menu item activated for closing of com port
         */
        private void msComClosePort_Click(object sender, EventArgs e)
        {
            closePort();
        }

        private void closePort()
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    lblComInfo.Text = "com port successfully closed";
                }
                else
                {
                    MessageBox.Show("com port already closed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("problems while closing com port" +
                    System.Environment.NewLine +
                    ex.Message);
            }
        }

        /***
         * menu item exit 
         * before closing of application the com port will be closed as well
         */
        private void msOpExitApp_Click(object sender, EventArgs e)
        {

        }

        /***
         * menu item log data 
         * content of list box will be written in a file
         * user can chose location and name in a file dialogue
         */
        private void msOpLogData_Click(object sender, EventArgs e)
        {
            if (lboDataToLog.Items.Count > 0)
            {

            }
            else
            {
                MessageBox.Show("No data to log!");
            }
        }

        /***
         * menu item send data 
         * selects line from list box and sends data to µc
         * reads data from µC and shows them in list box
         * interval between sending depends on current slider value
         */
        private void msOpSendData_Click(object sender, EventArgs e)
        {
            try
            {
                if (lboDataToSend.Items.Count > 0)
                {
                    if (serialPort1.IsOpen)
                    {

                    }
                    else
                    {
                        MessageBox.Show("com port is closed!");
                    }
                }
                else
                {
                    MessageBox.Show("no data to send!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("problems whit serial communication"+
                    System.Environment.NewLine +
                    ex.Message);
            }
        }

        private void transmitData()
        {
            if ((transmitIndex >= 0) &&
                (transmitIndex < lboDataToSend.Items.Count))
            {
                try
                {

                }
                catch (Exception ex)
                {
                    MessageBox.Show("problem while communicating"
                        + System.Environment.NewLine +
                        ex.Message);
                }               
            }
            else
            {

            }
        }

        /***
        * revoke method every time timer event is activated
        * send data to µC and read and display response
        */
        private void timer1_Tick(object sender, EventArgs e)
        {
            transmitData();
            readRespose();
        }

        /***
        * read data from µC
        * display data in listbox
        */
        private void readRespose()
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    string receivedData = serialPort1.ReadLine();
                    if (receivedData.Length > 0)
                    {
                        lboDataToLog.Items.Add(receivedData);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("problems while communicating"
                        + System.Environment.NewLine + ex.Message);
                }
            }
        }

        private void tbDelayTime_Scroll_1(object sender, EventArgs e)
        {

        }
    }
}
