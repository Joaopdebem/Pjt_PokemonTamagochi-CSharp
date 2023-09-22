using System;
using RestSharp;
using System.Web.Script.Serialization;
using Pokemagochi.Pokemons;
using Pokemagochi.Funcionamento;
using System.Collections.Generic;

namespace Pokemagochi
{
    public class Program
    {
        static void Main()
        {

            //MenuPoketamagochi();
            ListaBrutaPokemons();

            JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            dynamic pegaAPI = ListaBrutaPokemons();

            dynamic retorno = serializer.DeserializeObject(pegaAPI);
            //var quantidadePokemons = retorno.string[1]; 

            foreach (KeyValuePair<string, object> item in retorno)
            {
                var key = item.Key;
                var value = item.Value;

                Console.WriteLine(String.Format("{0} : {1}", key, value));
            }

            //Console.WriteLine(quantidadePokemons);
            Console.WriteLine(retorno);
            Console.WriteLine("\n\n");

            /*foreach (var item in resultado.pokemonWrapper.results)
            {
                var name = item.name;
                var url = item.url;

                Console.WriteLine($"Nome: {name}");
                Console.WriteLine($"URL: {url}");
                Console.WriteLine("");
            }*/

            
            Console.ReadKey();
        }

        private static dynamic ListaBrutaPokemons()
        {
            RestClient consultaListBrutaPokeAPI = new RestClient($"https://pokeapi.co/api/v2/pokemon/2");
            RestRequest request = new RestRequest("", Method.Get);
            dynamic resultadoListaBrutaPokeAPI = consultaListBrutaPokeAPI.Execute(request);

            if (resultadoListaBrutaPokeAPI.StatusCode != System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine(resultadoListaBrutaPokeAPI.ErrorMessage);
            }
            return resultadoListaBrutaPokeAPI.Content;
        }

        public static void MenuPoketamagochi()
        {
            Console.WriteLine("Bem vindo ao seu Poketamagochi!\n");
            Console.WriteLine("Iremos primeiramente selecionar um pokemon para ser seu.");
            Console.WriteLine("Escolha um pelo Nome ou ID\n\n");
        }


    }
}
