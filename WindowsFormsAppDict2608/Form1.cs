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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> mijnDictionary = new Dictionary<int, string>();
            mijnDictionary.Add(1, "Een");
            mijnDictionary.Add(2, "Twee");
            mijnDictionary.Add(3, "Drie");
            mijnDictionary.Add(4, "Vier");
            mijnDictionary.Add(5, "Vijf");
            mijnDictionary.Add(6, "Zes");
            mijnDictionary.Add(7, "Zeven");
            mijnDictionary.Add(8, "Acht");
            mijnDictionary.Add(9, "Negen");
            mijnDictionary.Add(10, "Tien");

            


            cbGetallen.DataSource = new BindingSource(mijnDictionary, null);
            cbGetallen.DisplayMember = "Key";
            cbGetallen.ValueMember = "Value";

            
     
        }

        private void cbGetallen_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<int, string> pair = (KeyValuePair<int, string>)cbGetallen.SelectedItem;

            lblVoluit.Text = pair.Value;
            lblCijfer.Text = pair.Key.ToString();
        }
    }
}
