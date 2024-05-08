using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Calculadora
    {

        private List<string> _historico;
        private string _data;

        public Calculadora(string data)
        {
            _historico = new List<string>();
            this._data = data;
        }

        private void AdicionarNoHistorico(int res)
        {
            _historico.Insert(0, "Res: " + res + "| Data: "+ this._data);
        }

        public int Somar (int n1, int n2)
        {
            AdicionarNoHistorico(n1 + n2);
            return n1 + n2;
            //return 0;
        }

        public int Subtrair(int n1, int n2)
        {
            AdicionarNoHistorico(n1 - n2);
            return n1 - n2;
            //return 0;
        }

        public int Multiplicar (int n1, int n2)
        {
            AdicionarNoHistorico (n1 * n2);
            return n1 * n2;
            //return 0;
        }

        public int Dividir(int n1, int n2)
        {
            AdicionarNoHistorico(n1 / n2);
            return n1 / n2;
            //return 0;
        }

        public List<string> Historico()
        {
            _historico.RemoveRange(3, _historico.Count - 3) ;
            //Console.WriteLine (_historico);
            return _historico;
        }
    }
}
