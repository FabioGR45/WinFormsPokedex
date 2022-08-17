using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokemonAPI.Models;

namespace PokemonAPI
{
    public partial class Form1 : Form
    {

        APIrequest api = new APIrequest();

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void LoadData() {

            flowLayoutPanel1.Controls.Clear();

            PokeList pokemon = new PokeList();

            pokemon = api.obtainList();

            foreach(var item in pokemon.pokemonsList) {

                flowLayoutPanel1.Controls.Add(new PokeVista(item.pokemonName, item.GetImageN()));

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
