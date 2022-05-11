using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U1_BMI_Rauch
{
    
    public partial class BMICalc : Form
    {
        private double height, weight, bmi;
        public BMICalc()
        {
            InitializeComponent();
        }

        private void cmdResetInput_Click(object sender, EventArgs e)
        {
            txtWeight.Text = " ";
            txtHeight.Text = " ";
            rdoFemale.Checked = false;
            rdoMale.Checked = false;
            lblOutput.Text = "Mann/Frau\r\nAusgabe Ergebniss\r\nInterpretation\r\n";
        }

        private void cmdCalcBMI_Click(object sender, EventArgs e)
        {

            if(txtHeight.Text==string.Empty || txtWeight.Text==string.Empty ||(rdoMale.Checked==false & rdoFemale.Checked==false))
            {
                MessageBox.Show("Eine Angabe wurde nich getätigt");
            }
            try
            {
                weight = double.Parse(txtWeight.Text);
                height = Convert.ToUInt16(txtHeight.Text) / 100;
                if(rdoFemale.Checked==true)
                    {
                        bmi = (weight / Math.Pow(height, 2)) * 0.95;
                        lblOutput.Text = "Weiblich";
                    }
                else
                    {
                        bmi = (weight / Math.Pow(height, 2));
                        lblOutput.Text = "Männlich";
                    }
                if(bmi<18.5)
                    {
                        lblOutput.Text = lblOutput.Text + Environment.NewLine + "Untergewichtig" + Environment.NewLine + "BMI: " + bmi.ToString("F2");
                    }
                else if(bmi<25)
                    {
                        lblOutput.Text = lblOutput.Text + Environment.NewLine + "Normalgewichtig" + Environment.NewLine + "BMI: " + bmi.ToString("F2");
                    }
                else
                    {
                        lblOutput.Text = lblOutput.Text + Environment.NewLine + "Übergewichtig" + Environment.NewLine + "BMI: " + bmi.ToString("F2");
                    }

            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "Es sind nur ganze ZAHLEN zulässig");
                return;
            }
            catch(OverflowException ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "Eine der Angegebenen Zahlen ist zu groß um diese zu verarbeiten");
                return;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void cmdEndProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
