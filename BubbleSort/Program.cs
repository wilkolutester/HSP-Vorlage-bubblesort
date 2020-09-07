using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class Program
    {

        public List<int> bubbleSort(List<int> liste)
        {
            // bubbleSort hier
            throw new NotImplementedException();
            
            return liste;
        }

        static void Main(string[] args)
        {
            Program prg = new Program();
            Console.WriteLine(prg.bubbleSort(new List<int>() { 3, 5, 1, 2 }));
            Console.ReadKey();
        }

    }
}
