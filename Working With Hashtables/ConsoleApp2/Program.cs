using System;
using System.Collections;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("1", "Jhow");
            ht.Add("2", "Codigosimples");
            ht.Add("3", "Maria");
            ht.Add("4", "Joaquim");
            ICollection key = ht.Keys;
            Console.WriteLine("Recuperando elementos: ");
            Console.WriteLine();
            foreach (var k in key)
            {
                Console.WriteLine(k + ":" + ht[k]);
            }
            ArrayList al = new ArrayList(key);
            Console.WriteLine("Recuperando todas as chaves no array");
            Console.WriteLine();
            foreach (var n in al)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
}
