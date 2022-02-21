using PhoneBook.List;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PhoneBook
{
    public partial class Form1 : Form
    {
        Query controller;
        public Form1()
        {
            InitializeComponent();
            controller = new Query(ConnectionString.ConnStr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.UpdatePerson();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controller.Add(textBox1.Text, textBox2.Text, textBox3.Text,int.Parse(textBox4.Text));
           
            dataGridView1.DataSource = controller.UpdatePerson();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            controller.Delete(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Id"].Value.ToString()));
            dataGridView1.DataSource = controller.UpdatePerson();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // Connection.Open();
           
         
        }

      
     

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.Clear();

        }

        private void textBox4_MouseDown(object sender, MouseEventArgs e)
        {
           textBox4.Clear();
            

        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.Clear();
        }

        private void textBox3_MouseDown(object sender, MouseEventArgs e)
        {
            textBox3.Clear();
        }

        
    }
    
}
