
namespace estudosCSharp {
  public class Ex1 {

      private string _conta;
      private double _saldo;

      public Ex1(string conta) {
          this._conta = conta;
          this._saldo = 100.00;
      }

      public double Saldo() {
          return this._saldo;
      }
      public bool Saca(double valor) {
          if(this._saldo >= valor) {
              _saldo -= valor;
              return true;
          }
          return false;
      }

      public void Deposita(double valor) {
          this._saldo += valor;
      }

      public bool transfere(double valor, Ex1 ex) {
          if(this._saldo > valor) {

              this.Saca(valor);
              ex.Deposita(valor);
              
              return true;
          }
          return false;
      }

  }
}