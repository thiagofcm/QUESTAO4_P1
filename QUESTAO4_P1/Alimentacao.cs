using System;
using System.Collections.Generic;
using System.Text;

namespace QUESTAO4_P1
{
    class Alimentacao : Pagtos
    {
        //atributos
        private String descricao;
        private double vlfatAliment;

        //metodos
        public Alimentacao() { //construtor default

        }
        public Alimentacao(long _cpf, double _valor, int _cod, String _descricao, double _vlfatAliment) : base(_cpf, _valor, _cod) {
            descricao = _descricao;
            vlfatAliment = _vlfatAliment;
        }
        // gets
        public String getDescricao() {
            return descricao;
        }
        public double getVlfatAliment() {
            return vlfatAliment;
        }
        //sets
        public void setDescricao(String _descricao) {
            descricao = _descricao;
        }
        public void setVlfaAliment(double _vlfatAliment) {
            vlfatAliment = _vlfatAliment;
        }
        
        public override void faturar() {
            //base.faturar();
            Console.WriteLine("Digite a descricao do produto: ");
            String _descricao = Console.ReadLine();
            setDescricao(_descricao);
            Console.WriteLine("Digite o valor da fatura de alimentacao: ");
            double _valor = double.Parse(Console.ReadLine());
            setValor(_valor);
            double fat;
            fat = getVlfatAliment() * 1.05;
            Console.WriteLine("o valor do faturamento eh: " + fat + "reais e a descricao do produto eh: " + getDescricao());
        }
    }
}
