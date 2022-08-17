using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonAPI
{
    public partial class PokeVista : UserControl
    {
        public PokeVista(string nome, Image imageN)
        {
            InitializeComponent();
            this.Nome.Text = nome;
            this.imageN.Image = imageN;
        }

        private void PokeVista_Load(object sender, EventArgs e)
        {

        }
    }
}
