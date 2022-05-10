using System;
using System.Windows.Forms;

namespace B2_ErrorHandling
{
    public partial class Form1 : Form
    {
        private int number1;
        private int number2;
        private double result;
        private bool rc1;
        private bool rc2;
        public Form1()
        {
            InitializeComponent();
        }

        /** Konvertierung der Eingabe in Textbox in eine Integer-Zahl
            ohne weitere Prüfung mit Convert bzw Parse
            Absturz wenn kein oder ungültiger Input */
        private void cmdDivide1_Click(object sender, EventArgs e)
        {
            //prüfen, ob Textfelder etwas beinhalten
            if(txtNumber1.Text == "" || txtNumber2.Text == String.Empty)
            {
                MessageBox.Show("Sie müssen in beide Felder etwas eingeben!");
            }
            number1 = int.Parse(txtNumber1.Text);
            number2 = Convert.ToInt32(txtNumber2.Text);
            result = number1 / number2;
            txtResult.Text = result.ToString("F2");
        }

        /** Konvertierung der Eingabe in Textbox in eine Integer-Zahl
            mit Hilfe von TryParse
            Fehlermeldung wenn kein oder ungültiger Input */
        private void cmdDivide2_Click(object sender, EventArgs e)
        {

            if (txtNumber1.Text == "" || txtNumber2.Text == String.Empty)
            {
                MessageBox.Show("Sie müssen in beide Felder etwas eingeben!");
            }
            else
            {
                rc1 = int.TryParse(txtNumber1.Text, out number1);
                rc2 = int.TryParse(txtNumber2.Text, out number2);
                if (rc1 == false)
                {
                    MessageBox.Show("Sie müssen eine Zahl eingeben im 1. Textfeld eingeben!");
                }
                if (rc2 == false)
                {
                    MessageBox.Show("Sie müssen eine Zahl eingeben im 2. Textfeld eingeben!");
                }
                result = (double)number1 / number2;
                txtResult.Text = result.ToString("F2");
            }
        
        }

        /** Konvertierung der Eingabe in Textbox in eine Integer-Zahl
            innerhalb eines try-Blocks
            mögliche Fehler werden in Catch-Blöcken abgefangen */
        private void cmdDivide3_Click(object sender, EventArgs e)
        {
            if (txtNumber1.Text == "" || txtNumber2.Text == String.Empty)
            {
                MessageBox.Show("Sie müssen in beide Felder etwas eingeben!");
            }
            try
            {
                number1 = int.Parse(txtNumber1.Text);
                number2 = Convert.ToInt32(txtNumber2.Text);
                result = (double) number1 / number2;
                txtResult.Text = result.ToString("F2");
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "Sie müssen eine ganze Zahl eingeben!");
                return;
            }
            catch(DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "Sie können nicht durch 0 dividieren");
                return;
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "Die eingabe ist dür den Datentypen zu groß/Klein");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                txtNumber1.Text = "";
                txtNumber2.Text = "";
            }
        }
    }
}
