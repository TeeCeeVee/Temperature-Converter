using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_fahrenheit_Click(object sender, EventArgs e)
        {
            convertFromFahrenheit();
        }

        private void convertFromFahrenheit()
        {
            float fahrenheit = 0;

            try
            {
                // input from the user
                fahrenheit = float.Parse(txt_fahrenheit.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Enter numbers only");
            }


            // formula convert to celsius
            float celsius = 5f / 9 * (fahrenheit - 32);
            //placing celsius value into the celsius box
            txt_celsius.Text = celsius.ToString();

            //formula to convert 

            float kelvin = (fahrenheit - 32) * 5 / 9 + 273.15f;
            // placing kelvin value into the kelvin box
            txt_kelvin.Text = kelvin.ToString();

        }

        private void btn_celsius_Click(object sender, EventArgs e)
        {
            convertFromCelsius();

        }

        private void convertFromCelsius()
        {
            float celsius = 0;
            try
            {
                //input from the user
                celsius = float.Parse(txt_celsius.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Enter numbers only.");
            }

            //formula to convert to Fahrenheit
            float fahrenheit = (celsius * 9 / 5) + 32f;
            txt_fahrenheit.Text = fahrenheit.ToString();

            //formula to convert to Kelvin
            float kelvin = celsius + 273.15f;
            txt_kelvin.Text = kelvin.ToString();

        }

        private void btn_kelvin_Click(object sender, EventArgs e)
        {
            convertFromKelvin();
        }

        private void convertFromKelvin()
        {
            float kelvin = 0;

            try
            {
                // input
                kelvin = float.Parse(txt_kelvin.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Enter numbers only");
            }

            //formula to convert to Fahrenheit
            float fahrenheit = (kelvin - 273.15f) * 9 / 5 + 32;
            txt_fahrenheit.Text = fahrenheit.ToString();

            //formula to convert to Celsius
            float celsius = kelvin - 273.15f;
            txt_celsius.Text = celsius.ToString();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
