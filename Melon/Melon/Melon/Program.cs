using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melon {
    class Program {
        static void Main() {
            Console.Write("Melon kg: ");
            bool result = false;
            int kg = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= kg; i++) {
                if (i % 2 == 0) {
                    int difference = kg - i;
                    if (difference % 2 == 0) {
                        result=true;                        
                        } 
                    }                    
                }
            if (result == true) {
                Console.WriteLine("DA");
            } else {
                Console.WriteLine("NU");
            }
             Console.ReadLine();
            }
        }
    }