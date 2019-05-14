using System;

namespace estudosCSharp {

    class Lista {

        public string[] lista = new string[100];

    }
    class Adcionar {

        Lista lista  = new Lista();
        int contador = 0;
        public void Adciona(String nome) {
            if(nome.Length > 1) {
                lista.lista[contador] = nome;
                contador++;
            }
        }

        public override string ToString(){

            foreach(string nome in lista.lista) {
                System.Console.WriteLine(nome);
            }
            return "";
        }

    }
}