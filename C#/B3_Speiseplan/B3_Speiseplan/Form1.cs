using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B3_Speiseplan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lboMeals.Items.Add("Pizza");
            string[] meals = { "Schnitzelsemmerl", "Frankfurther" };
            lboMeals.Items.AddRange(meals);
        }

        private void cmdEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (txtFood.Text == string.Empty)
            {
                MessageBox.Show("Sie müssen eine Speise auswählen");
                return;
            }
            string newMeal = txtFood.Text.Trim();
            if (lboMeals.Items.Contains(newMeal))
            {
                MessageBox.Show("Diese Speise gibt es bereits!");
            }
            else
            {
                lboMeals.Items.Add(newMeal);
            }
            txtFood.Text = "";
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if(lboMeals.SelectedIndex == -1)
            {
                MessageBox.Show("Sie haben keon Element ausgewählt");
                return;
            }
            int index = lboMeals.SelectedIndex;
        }

        private void cmdCommit_Click(object sender, EventArgs e)
        {
            if(lboMeals.SelectedIndex==-1 || cboWeekdays.SelectedIndex==-1)
            {
                MessageBox.Show("Sie müssen sowohl eine Speise als auch einen Wochentag auswählen");
            }
            else
            {
                string newItem = cboWeekdays.SelectedItem.ToString() + ": " + lboMeals.SelectedItem.ToString();
                if (lboWeekplan.SelectedIndex == -1)
                {
                    lboWeekplan.Items.Add(newItem);
                }
                else
                {
                    lboWeekplan.Items.Insert(lboWeekplan.SelectedIndex, newItem);
                }
                lboWeekplan.SelectedIndex = -1;
                cboWeekdays.SelectedIndex = -1;
                lboMeals.SelectedIndex = -1;
            }
            
        }
    }
}
