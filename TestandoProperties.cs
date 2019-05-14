using System;

namespace estudosCSharp {
    class TestandoProperties {

        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public TestandoProperties( string nome, double preco, int quantidade ) {
            if(nome.Length > 1) {
                this._nome = nome;
            }else{
                System.Console.WriteLine("Nome muito curto, o valor User será definido");
                this._nome = "User";
            }
            this.Preco = preco;
            this.Quantidade = quantidade;
        }

        public string SetName(string nome) {
            if(this._nome.Length > 0) {
                return this._nome = nome;
            }else{
                System.Console.WriteLine("Nome muito curto, o valor User será definido");
                return this._nome = "User";
            }
        }
        
        public string GetName() {
            return this._nome;
        }

        public override string ToString() {
            return $"Nome: {this._nome}, Valor: {this.Preco} Quantidade: {this.Quantidade}";
        }

    }
}