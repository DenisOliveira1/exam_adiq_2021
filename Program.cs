using System;
using System.Collections.Generic;

namespace SilvioSantos
{
    class Program
    {
        static void Main(string[] args)
        {

            const int limiteInferior = 0;
            const int limiteSuperior = 100;

            List<Pares> lista = new List<Pares> {
                new Pares(3, "a"),
                new Pares(5, "b"),
                new Pares(7, "c")
            };

            var verificador =  new VerificaLista();
            verificador.verificarLista(lista, limiteInferior, limiteSuperior);

        }

        public class Pares {

            private int _dividendo { get; set; }
            private string _result { get; set; }

            public Pares(int dividendo, string result)
            {
                this._dividendo = dividendo;
                this._result = result;
            }

            public string verificaNumero(int numero) {
                if (numero % _dividendo == 0)
                {
                    return _result;
                }
                else {
                    return String.Empty;
                }
            }
        }

        public class VerificaLista
        {

            public void verificarLista(List<Pares> lista, int limiteInferior, int limiteSuperior) {

                for (var i = limiteInferior; i < limiteSuperior; i++) {

                    var result = "";

                    foreach (var item in lista)
                    {
                        result += item.verificaNumero(i);
                    }

                    if (!string.IsNullOrEmpty(result))
                    {
                        Console.WriteLine(result);
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }

        }
    }
}
