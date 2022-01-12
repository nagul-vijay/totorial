using System;

namespace basiclearing;
internal class Sector{
     static void Main(String[] args){
            Calculator cal = new Calculator();
            Console.WriteLine("Enter the 1st number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("add");
            Console.WriteLine("sub");
            Console.WriteLine("mul");
            Console.WriteLine("div");
            switch (Console.ReadLine()){
                case "add": Console.WriteLine(cal.addNumber(x,y));
                      break;
                case "sub": Console.WriteLine(cal.subNumber(x,y));
                     break;
                case "mul": Console.WriteLine(cal.mulNumber(x,y));
                     break;
                case "div": Console.WriteLine(cal.divNumber(x,y));
                     break;
                default: Console.WriteLine("Enter valid character");
                     break;
                      

            }
        }

    }
    
    
    
