using System;

namespace QUESTAO4_P1
{
    class Program
    {
        static void Main(string[] args) {
            Pagtos[] lista = new Pagtos[6]; 
            for (int i = 0; i < 6; i++) {
                lista[i] = new Pagtos();
                lista[i].solicitaPagto();
                if (lista[i].getCod() == 1) {
                    lista[i] = new Alimentacao();
                    lista[i].faturar();
                }
                if (lista[i].getCod() == 2) {
                    lista[i] = new Saude();
                    lista[i].faturar();
                }
            }
        }
    }
}
