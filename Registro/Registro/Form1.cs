using Registro.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro
{
    public partial class Form1 : Form
    {
        List<Product> Persons;
        public Form1()
        {
            InitializeComponent();
            Persons = new List<Product>();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            Product producto = new Product();
            producto.Name = tbProduc.Text;
            producto.Precio = int.Parse(tbPrecio.Text);
            Persons.Add(producto);
            ShowProduct();
        }
        private void ShowProduct()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = Persons;
        }
    }
}
