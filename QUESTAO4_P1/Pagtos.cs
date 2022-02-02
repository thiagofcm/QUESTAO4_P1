using System;
using System.Collections.Generic;
using System.Text;

namespace QUESTAO4_P1
{
    class Pagtos
    {
        //atributos
        protected long cpf;
        protected double valor;
        protected int cod;
        //metodos
        public Pagtos() { //construtor default

        }
        public Pagtos(long _cpf, double _valor, int _cod) { //construtor default
            cpf = _cpf;
            valor = _valor;
            cod = _cod;
        }
        //gets
        public long getCpf() {
            return cpf;
        }
        public double getValor() {
            return valor;
        }
        public int getCod() {
            return cod;
        }
        // sets
        public void setCpf(long _cpf) {
            cpf = _cpf;
        }
        public void setValor(double _valor) {
            valor = _valor;
        }
        public void setCod(int _cod) {
            cod = _cod;
        }
        //faturar
        public virtual void faturar() {

        }
        public void solicitaPagto() {
            Console.WriteLine("Digite seu cpf: ");
            long _cpf = long.Parse(Console.ReadLine());
            setCpf(_cpf);
            Console.WriteLine("Digite o valor do pagamento: ");
            double _valor = double.Parse(Console.ReadLine());
            setValor(_valor);
            Console.WriteLine("Digite o codigo: ");
            int _cod = int.Parse(Console.ReadLine());
            setCod(_cod);
        }


    }
}