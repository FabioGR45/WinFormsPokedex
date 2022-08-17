using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Drawing;
using System.Net;

namespace PokemonAPI.Models
{
    public  class Pokemon {

        [JsonProperty("name")]
        public string pokemonName { get; set; }

        [JsonProperty("url")]
        public Uri link { get; set; }

        public Image GetImageN()
        {

            string dir = link.ToString();
            dir = dir.Substring(0, dir.Length - 1);
            dir = dir.Substring(dir.LastIndexOf("/"));

            dir = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/" + dir + ".png";

            var request = WebRequest.Create(dir);

            using (var response = request.GetResponse()) {

                using (var stream = response.GetResponseStream()) {

                    return Bitmap.FromStream(stream);

                }

            }
        }

    }
}
