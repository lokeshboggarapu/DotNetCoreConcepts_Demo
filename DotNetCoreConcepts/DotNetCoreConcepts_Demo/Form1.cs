using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

         //   temperatureUC1.tempselected += comboBox1_SelectedIndexChanged;
            temperatureUC1.tempselected += new TempUC(comboBox1_SelectedIndexChanged);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaseClass b = new IntermediateClass();
            b.baseclass();
            MessageBox.Show(b.baseclass());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BaseClass c = new DerivedClass();
            c.demo();
            MessageBox.Show(c.demo());
        }

        private void button3_Click(object sender, EventArgs e)
        {

            IntermediateClass d = new DerivedClass();
            d.demo();
            MessageBox.Show(d.demo());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbsInherit a = new AbsInherit ();
            a.abs();
            MessageBox.Show(a.abs());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SealClass s = new SealClass();
            s.baseclass();
            MessageBox.Show(s.baseclass());
        }

      void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (temperatureUC1.comboboxvalue == "Celsius")
            {

                int input = Convert.ToInt32(temperatureUC1.Temperature);
               double result = (input -32)*0.55; 

            MessageBox.Show("Celsius temperature is: "+result.ToString());

            }

            else if (temperatureUC1.comboboxvalue == "Farenheit")
            {
                int input = Convert.ToInt32(temperatureUC1.Temperature);
                double result = (input * 1.8)+32;
                MessageBox.Show("Farenheit temperature is: " + result.ToString());
            }
            else
            {
                MessageBox.Show("Please enter Input");
            }
        }





    }
}
