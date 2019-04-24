using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace order
{
    public partial class order_details : Form
    {
        public order_details()
        {
            InitializeComponent();
            
            
            
                
            
                

            
        }

        private void order_details_Load(object sender, EventArgs e)
        {
            double sum = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                string x = listView1.Items[i].SubItems[1].Text; ;
                
                sum += Convert.ToDouble(listView1.Items[i].SubItems[1].Text) * Convert.ToDouble(listView1.Items[i].SubItems[2].Text);

            }
            textBox1.Text = sum.ToString();
        }

        public void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
