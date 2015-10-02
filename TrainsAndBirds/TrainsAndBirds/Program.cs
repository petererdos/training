using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainsAndBird {
    class BirdDistance {
        static void Main() {
            Console.WriteLine("Adunate impreuna, trenurile au aceeasi viteza si parcurg aceeasi distanta ca si pasarea.");
            Console.WriteLine("");
            Console.Write("Introdu distanta: ");
            int d = Convert.ToInt32(Console.ReadLine());
            float da = d / 2;
            float db = d / 2;
            float dp = da / 2 + db / 2;
            Console.WriteLine("Distanta parcursa de pasare: " + dp);
            Console.ReadLine();
        }
    }
}
