using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox_Özellikleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((listBox1.Items.IndexOf(textBox1.Text.ToUpper()) == -1) && ((listBox2.Items.IndexOf(textBox1.Text.ToUpper()) == -1)))
                listBox1.Items.Add(textBox1.Text.ToUpper());
            else
                MessageBox.Show("Bu değer dahaönce listeye eklenmiştir");

            textBox1.SelectAll();
            textBox1.Focus();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);
        }

        private void button1den2ye_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                //değere göre işlem yapmak için
                listBox2.Items.Add(listBox1.Text);
                listBox1.Items.Remove(listBox1.Text);
                // index numarasına göre işlem yapmal için
                //listBox2.Items.Add(listBox1.Items[listBox1.SelectedIndex]);
                //listBox2.Items.RemoveAt(listBox1.SelectedIndex);
                if (listBox1.Items.Count>0)
                    listBox1.SelectedIndex = 0;

                listBox1.Focus();
            }
        }

        private void button2den1e_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex > -1)
            {
                listBox1.Items.Add(listBox2.Text);
                listBox2.Items.Remove(listBox2.Text);
                if (listBox2.Items.Count > 0)
                    listBox2.SelectedIndex = 0;

                listBox2.Focus();
            }
        }

        private void button1den2yehepsi_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
                listBox2.Items.Add(listBox1.Items[i]);

            listBox1.Items.Clear();
        }

        private void button2den1ehepsi_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
                listBox1.Items.Add(listBox2.Items[i]);

            listBox2.Items.Clear();
        }
    }
}
