using MetodoBurbuja.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodoBurbuja
{
    public partial class Form1 : Form
    {
        int[] numbers = new int[10];
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(btnumero.Text);
                numbers[i++] = number;
                ShowNumbers();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ShowNumbers()
        {
            if (lblist.Items.Count > 0)
            {
                lblist.Items.Clear();
            }
            foreach(int number in numbers)
            {
                lblist.Items.Add(number);
            }
            clear();
        }
        private void clear()
        {
            btnumero.Clear();
            btnumero.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Burbuja burbuja = new Burbuja();
            burbuja.BubbleSort(numbers);
            ShowNumbers();
        }
    }
}
