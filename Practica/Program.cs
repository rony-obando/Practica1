using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            List<double> FNE = new List<double>();
            Console.WriteLine("cantidad");
            int cantidad= int.Parse(Console.ReadLine());
            for(int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"Escribir {i}");
                FNE.Add(double.Parse(Console.ReadLine()));
            }
            double VPN = 0;
            double[] Si = FNE.ToArray();
            /*for (int i = 0; i < cantidad; i++)
            {*/
                VPN = Financial.IRR(ref Si);//(FNE[i] / (Math.Pow(1.12, i)))+VPN;
            //}
            for(int i = 0; i < Si.Length; i++)
            {
                Console.Write(Si[i]+", ");
            }
            VPN = Financial.IRR(ref Si);
            Console.WriteLine(VPN);
            Console.ReadLine();
            
        }
    }
}
