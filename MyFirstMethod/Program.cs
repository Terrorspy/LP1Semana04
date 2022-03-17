using System;

namespace MyFirstMethod
{
    /// <summary>
    /// Este programa invoca a função CountTo10 duas vezes e imprime os números até n que o utilizador pode alterar na invocação da função CountToN dentro da função CountTo10
    /// </summary>
    class Program
    {
        /// <summary>
        /// Invoca a função CountTo10 duas vezes e recebe inputs do utilizador
        /// </summary>
        private static void Main(string[] args)
        {
            string aux = Console.ReadLine();
            int nCount = Convert.ToInt32( aux );
            CountToN(nCount);

            for(int num = 0; num < 2; num++)
                CountTo10();
        }
        
        /// <summary>
        /// Invoca a função CountToN e conta até n.
        /// </summary>
        private static void CountTo10()
        {
            CountToN(10);
        }
        /// <summary>
        /// Cria um ciclo for e soma até chegar a n.
        /// </summary>

        private static void CountToN(int n)
        {
            for( int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
