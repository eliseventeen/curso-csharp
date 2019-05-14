using System;

namespace estudosCSharp {
    class Conta {

        private string _nome;
        private double _saldo;
        public Conta(string nome) {
            this._nome = nome;
            this._saldo = 100;
        }

        public bool Saca(double valor) {
            if(this._saldo > valor) {
                this._saldo -= valor;
                return true;
            }else {
                return false;
            }
        }

        public double Deposita(double valor) {
            return this._saldo += valor;
        }
        public double Saldo() {
            return this._saldo;
        }

        public bool Transfere(Conta c, double valor) {
            if(valor < this._saldo) {
                this.Saca(valor);
                c.Deposita(valor);
                return true;
            }else {
                return false;
            }
        }
        
    }
}