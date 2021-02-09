using System;
using System.Collections.Generic;
using System.Linq;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
             string nome = "";
             

            if(args.Length != 1)
            {
                Console.WriteLine("Por favor insira um nome");
            }
            else
            {
                nome = args[0];
                string nomeinvertido = new string(nome.Reverse().ToArray());

                Console.WriteLine(nomeinvertido);
            }
        }
    }
}
