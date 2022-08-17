using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PokemonAPI.Models
{
    public class PokeList {

        [JsonProperty("count")]
        public long quantidade { get; set; }

        [JsonProperty("next")]
        public string next { get; set; }

        [JsonProperty("previous")]
        public object previous { get; set; }

        [JsonProperty("results")]
        public List<Pokemon> pokemonsList { get; set; }

    }
}
