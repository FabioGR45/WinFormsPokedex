using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using PokemonAPI.Models;
using Newtonsoft.Json;

namespace PokemonAPI
{
    public class APIrequest {

        public string url { get; set; }

        public int actual = 0;

        public APIrequest() {

            url = "https://pokeapi.co/api/v2/pokemon?limit=10&offset=";

        }

        public PokeList obtainList() {

            var consult = (HttpWebRequest) WebRequest.Create(url + actual);
            consult.Method = "GET";
            consult.ContentType = "application/json";
            consult.Accept = "application/json";

            try {

                using (WebResponse response = consult.GetResponse()) {

                    using (Stream stream = response.GetResponseStream()) {

                    if(stream == null) {

                            return null;

                        }
                    
                        using (StreamReader reader = new StreamReader(stream)) {

                            string responseText = reader.ReadToEnd();

                            PokeList pokeList = JsonConvert.DeserializeObject<PokeList>(responseText);
                            actual += 10;

                            return pokeList;

                        }

                    }

                }

            } 
            catch (Exception){

                throw;

            }

        }

    }
}
