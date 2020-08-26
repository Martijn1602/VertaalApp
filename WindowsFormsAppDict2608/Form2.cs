using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppDict2608
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Dictionary<string, string> woorden = new Dictionary<string, string>();
        public Dictionary<string, Dictionary<string, string>> mijnDictionary = new Dictionary<string, Dictionary<string, string>>();


        private void Form2_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> mijnDictionary = new Dictionary<string, string>();
            mijnDictionary.Add("Sleutels", "Keys");
            mijnDictionary.Add("Tafel", "Table");
            mijnDictionary.Add("Car", "Auto");
            mijnDictionary.Add("Bloemen", "Flowers");
            mijnDictionary.Add("Schoenen", "Shoes");
            mijnDictionary.Add("Nummer", "Number");
            mijnDictionary.Add("Speler", "Player");
            mijnDictionary.Add("Huis", "House");
            mijnDictionary.Add("Tuin", "Garden");
            mijnDictionary.Add("Keuken", "Kitchen");

            cbVertaling.DataSource = new BindingSource(mijnDictionary, null);
            cbVertaling.DisplayMember = "Key";
            cbVertaling.ValueMember = "Value";
        }

        private void cbVertaling_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<string, string> pair = (KeyValuePair<string, string>)cbVertaling.SelectedItem;

            lblTeVertalen.Text = pair.Value;
            lblVertaling.Text = pair.Key;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            KeyValuePair<string, string> pair = (KeyValuePair<string, string>) cbVertaling.SelectedItem;
            mijnDictionary.Remove(pair.Key);
            cbVertaling.DataSource = new BindingSource(mijnDictionary, null);
            cbVertaling.DisplayMember = "Key";
            cbVertaling.ValueMember = "Value";
        }
    }
}
