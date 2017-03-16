using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Assignment1
{
    public delegate void TempUC(object sender, EventArgs e);
    public partial class TemperatureUC : UserControl
    {
        public TemperatureUC()
        {
            InitializeComponent();
        }
        public event TempUC tempselected;
      

        public string Temperature
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }


        public ComboBox.ObjectCollection Temptypes
        {
            get { return comboBox1.Items; }

        }
        public string comboboxvalue
        {
            get { return comboBox1.SelectedItem.ToString(); }
            set { comboBox1.SelectedItem = value; }
        }


        public int Comboboxindex
        {
            get { return comboBox1.SelectedIndex; }
            set { comboBox1.SelectedIndex = value; }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (this.tempselected != null)
            {
                this.tempselected(sender, e);
            }
        }
        
    }
}
