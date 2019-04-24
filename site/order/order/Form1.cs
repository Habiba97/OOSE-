using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using price;

namespace order
{
    public partial class Form1 : Form
    {
        public double[] arr = new double[3];
        public Form1()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            List<string> list;
            ListViewItem listViewItem;
            order_details o = new order_details();
            
            

            //Add first item
            
           
            if (checkBox1.Checked)
            {

                arr[0] = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox4.Text);
                list = new List<string>();
                list.Add(checkBox1.Text);
                list.Add(arr[0].ToString());
                list.Add(textBox4.Text);
                string[] row = list.ToArray();
                listViewItem = new ListViewItem(row);
                o.listView1.Items.Add(listViewItem);
                
            

               
                

            }
            if (checkBox2.Checked)
            {
                arr[1] = Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox5.Text);
                list = new List<string>();
                list.Add(checkBox2.Text);
                list.Add(arr[1].ToString());
                list.Add(textBox5.Text);
                string[] row1 = list.ToArray();
                listViewItem = new ListViewItem(row1);
                o.listView1.Items.Add(listViewItem);
                
                

            }
            if (checkBox3.Checked)
            {

                arr[2] = Convert.ToDouble(textBox3.Text) * Convert.ToDouble(textBox6.Text);
                list = new List<string>();
                list.Add(checkBox3.Text);
                list.Add(arr[2].ToString());
                list.Add(textBox6.Text);
                string[] row1 = list.ToArray();
                listViewItem = new ListViewItem(row1);
                o.listView1.Items.Add(listViewItem);
            }




           
            o.Show();
           
            

            price.price p = new price.price();
            p.prices = arr;
            p.calculate();
            
            
            
           
            
            
            o.Show();

            
           




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
