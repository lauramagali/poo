using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace RestauranteForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var restaurante = new Restaurante();
            var chef1 = new Chef();
            restaurante.SacarPlato(chef1);
            restaurante.SacarPlato(chef1);
            var repostero1 = new Repostero();
            restaurante.SacarPlato(repostero1);

            MessageBox.Show($"El total es {restaurante.CostoTotal}");

        }
    }
}
