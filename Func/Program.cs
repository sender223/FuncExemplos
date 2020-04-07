using System;
using ActionExemplo.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Func {
    class Program {
        static void Main(string[] args) {

            //O FUNC É PARECIDO COM O ACTION, A DIFERENÇA É QUE O ACTION RETORNA VOID
            //E FUNC RETORNA O VALOR CONVERTIDO

            List<Produto> lista = new List<Produto>();

            lista.Add(new Produto("TV", 900.00));
            lista.Add(new Produto("Mouse", 50.00));
            lista.Add(new Produto("Tablet", 350.50));
            lista.Add(new Produto("HD Case", 80.90));

            //pegamos a lista original e convertemos o IEnumerable para lista
            //e o SELECT é uma função que retorna um produto e o resultado dele.
            List<string> result = lista.Select(NomeUpper).ToList();
            foreach (string s in result) {
                Console.WriteLine(s);
            }
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-");
            //EXEMPLO 2
            //Func recebe o produto e retorna string
            Func<Produto, string> func = NomeUpper;
            List<string> result2 = lista.Select(func).ToList();
            foreach (string s in result) {
                Console.WriteLine(s);
            }
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-");
            //versão com lambda
            Func<Produto, string> func2 = p => p.Nome.ToUpper();
            List<string> result3 = lista.Select(func2).ToList();
            foreach (string s in result) {
                Console.WriteLine(s);
            }
            //versão inLine            
            List<string> result4 = lista.Select(p => p.Nome.ToUpper()).ToList();
            foreach (string s in result) {
                Console.WriteLine(s);
            }
            //essas diferenças é que a dif1 ja retorna um valor ou resultado
            Func<Produto, string> dif1 = p => p.Nome.ToUpper();
            //a dif2 terá que retornar um valor caso a função fosse do tipo void. 
            Func<Produto, string> dif2 = p => { return p.Nome.ToUpper(); };              


        }        
        //função simples que retorna um produto P em maiusculo
        static string NomeUpper(Produto p) {
            return p.Nome.ToUpper();
        }
    }
}