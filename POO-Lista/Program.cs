using System;
using System.Collections.Generic;

namespace POO_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarado a lista de strings.
            List<string> list = new List<string>();
            //Adicionado elementos na lista criada préviamente.
            list.Add("Fábio"); list.Add("Wilson"); list.Add("Angelina"); list.Add("Eliney"); list.Add("André");
            //Inserção de um elemento novo em uma posição específica.
            list.Insert(2, "Lucas");
            //Realização de um loop de leitura dos elementos préviamente inseridos. (Eu realmente não entendi o porque disso, e porque repetir todas as vezes.)
            foreach (string obj in list)
            {
                //Contagem da quantidade de elementos na lista.
                Console.WriteLine("Quantidade de elementos na lista: " + list.Count);
                //Código para encontrar o primeiro elemento da lista que inicia-se com a letra "A".
                string s1 = list.Find(x => x[0] == 'A');
                Console.WriteLine("Primeiro elemento que começa com a letra 'A': " + s1);
                //Código para encontrar o último elemento da lista que inicia-se com a letra "A".
                string s2 = list.FindLast(x => x[0] == 'A');
                Console.WriteLine("Último elemento que começa com a letra 'A': " + s2);
                //Código para encontrar um elemento de acordo com a sua posição.
                int pos1 = list.FindIndex(x => x[0] == 'A');
                Console.WriteLine("Primeira posição de 'A': " + pos1);
                int pos2 = list.FindLastIndex(x => x[0] == 'A');
                Console.WriteLine("Última posição de 'A': " + pos2);
            }
            //Código para encontrar elementos que possuem o comprimento desejado. Ex.: 5.
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Lista de nomes com 5 letras: ");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }
            //Código para remover elementos da lista. Ex.: André.
            list.Remove("André");
            Console.WriteLine("===================");
            Console.WriteLine("Nova lista de nomes sem o nome 'André': ");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            //Código para remover todos os elementos da lista por um parâmetro. Ex.: Elementos com a letra "W".
            list.RemoveAll(x => x[0] == 'W');
            Console.WriteLine("+++++++++++++++++++");
            Console.WriteLine("A mesma lista, agora sem nomes com W: ");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            //Código para remover um elemento em uma determinada posição. Ex.: 3.
            list.RemoveAt(3);
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine("A mesma lista, sem o atual nome da terceira posição: ");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            //Código para remover elementos da lista em uma determinada posição, e a quantidade de elementos a ser removida.
            list.RemoveRange(1, 2);
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine("A mesma lista, sem o nome na primeira (isto é, segunda, pois a primeira posição é a zero) posição, e logo após sem o nome que substituiu essa posição: ");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            }
        }
    }
