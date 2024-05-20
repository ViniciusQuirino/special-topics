using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG ";
            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim(); //começo e fim
            int n1 = original.IndexOf("bc"); //primeira ocorrencia
            int n2 = original.LastIndexOf("bc"); //ultima ocorrencia
            string s4 = original.Substring(3); //recortar
            string s5 = original.Substring(3, 5); 
            string s6 = original.Replace('a', 'x'); //substituir
            string s7 = original.Replace("abc", "xy");
            bool b1 = String.IsNullOrEmpty(original); //conteudo nulo ou vazio
            bool b2 = String.IsNullOrWhiteSpace(original); //nulo ou espaço em branco 
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
        }
    }
}