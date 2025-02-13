using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Constructor for Form1
            InitializeComponent();
            comboBox.SelectedIndex = 0;

            ListBox2.Enabled = false;
            ListBox3.Enabled = false;
            Button1.Enabled = false;
            Button2.Enabled = false;
        }

        bool hairdresser = false;

        /// <summary>
        /// Event handler for the selection change in listBox1 (ListBox).
        /// Enables Button1 when an item is selected, and disables it when no item is selected.
        /// </summary>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBox.SelectedIndex != -1)
            {
                Button1.Enabled = true;
            }
            else
            {
                Button1.Enabled = false;
            }
        }

        /// <summary>
        /// Event handler for the Click event of button1 (Button).
        /// Enables Button2 when Button1 is enabled.
        /// Disables comboBox and calculates the service and dresser prices based on user selections.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            if (Button1.Enabled)
            {
                Button2.Enabled = true;
            }
            else
            {
                Button2.Enabled = false;
            }

            comboBox.Enabled = false;

            if (ListBox.SelectedIndex != -1 && comboBox.SelectedIndex != -1)
            {
                string service = ListBox.SelectedItem.ToString();
                string dresser = comboBox.SelectedItem.ToString();
                decimal servicePrice = 0;
                decimal dresserPrice = 0;

                switch (service)
                {
                    case "Cut":
                        servicePrice = 30;
                        break;
                    case "Wash, blow-dry, and style":
                        servicePrice = 20;
                        break;
                    case "Colour":
                        servicePrice = 40;
                        break;
                    case "Highlights":
                        servicePrice = 50;
                        break;
                    case "Extension":
                        servicePrice = 200;
                        break;
                    case "Up-do":
                        servicePrice = 60;
                        break;
                    default:
                        servicePrice = 30;
                        break;
                }

                switch (dresser)
                {
                    case "Jan":
                        dresserPrice = 30;
                        break;
                    case "Pat":
                        dresserPrice = 45;
                        break;
                    case "Ron":
                        dresserPrice = 40;
                        break;
                    case "Sue":
                        dresserPrice = 50;
                        break;
                    case "Laurie":
                        dresserPrice = 55;
                        break;
                    default:
                        dresserPrice = 0;
                        break;
                }

                if (!hairdresser)
                {
                    ListBox2.Items.Add(dresser);
                    ListBox3.Items.Add(dresserPrice.ToString("0.00"));
                    hairdresser = true;
                }

                ListBox2.Items.Add(service);
                ListBox3.Items.Add(servicePrice.ToString("0.00"));
            }
        }

        /// <summary>
        /// Event handler for the Click event of button2 (Button).
        /// Calculates the total price of selected items and displays it in the TextBox.
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            decimal totalPrice = 0;

            foreach (var pricing in ListBox3.Items)
            {
                if (pricing != null)
                {
                    if (decimal.TryParse(pricing.ToString(), out decimal itemPrice))
                    {
                        totalPrice += itemPrice;
                    }
                }
            }

            TextBox.Text = "$" + totalPrice.ToString("0.00"); // converting the prices to string and adding to textbox
        }

        /// <summary>
        /// Event handler for the Click event of button3 (Button).
        /// Resets the form's state to its initial values.
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            comboBox.SelectedIndex = 0;
            TextBox.Text = "";
            ListBox.SelectedIndex = -1;
            Button2.Enabled = false;
            ListBox3.SelectedIndex = -1;
            ListBox2.Items.Clear();
            ListBox3.Items.Clear();
            comboBox.Enabled = true;
            hairdresser = false;
            comboBox.Focus();
        }

        /// <summary>
        /// Event handler for the Click event of button4 (Button).
        /// Exits the application.
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
