using System;
using System.Globalization;
using System.Collections.Generic;

namespace estudosCSharp
{
    class Program
    {
        static void Main(string[] args){
            Conta eliezer = new Conta("Eliézer");

            System.Console.WriteLine(eliezer.Saldo());
            eliezer.Deposita(500);
            System.Console.WriteLine(eliezer.Saldo());
            string saca = eliezer.Saca(300) ? "Transação ok" : "Sem saldo";
            System.Console.WriteLine(saca);

            Conta rhayssa = new Conta("Rhayssa");
            System.Console.WriteLine(rhayssa.Saldo());

            System.Console.WriteLine("_____________________________");

            eliezer.Transfere(rhayssa, 170);
            System.Console.WriteLine("Eliézer " + eliezer.Saldo());
            System.Console.WriteLine("Rhayssa " + rhayssa.Saldo());
            System.Console.WriteLine("_____________________________");
            System.Console.WriteLine("Console");
            System.Console.WriteLine("Outro console");

        }
    }

}
