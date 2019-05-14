using System;

namespace estudosCSharp {
    class Calculadora {
        private string _nome;
        public double Valor { get; private set; }
        private int _quantidade;
        

        public Calculadora(string nome, double valor, int quantidade) {
            _nome  = nome;
            Valor = valor;
            _quantidade = quantidade;
        }
        
        public string Nome {
            set { this._nome = value; }
            get { return this._nome; }
        }


        public override string ToString() {
            return $"Nome: {_nome}, \n Valor: {Valor}, \n {_quantidade}";
        }
    }
}