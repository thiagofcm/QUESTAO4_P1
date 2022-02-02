using System;
using System.Collections.Generic;
using System.Text;

namespace QUESTAO4_P1
{
    class Saude : Pagtos
    {
        //atributos
        private String estabelecimento;
        private double vlfatSaude;
        
        //metodos
        public Saude() { //construtor default

        }
        public Saude(long _cpf, double _valor, int _cod,String _estabelecimento, double _vlfatSaude) : base(_cpf, _valor, _cod) {
            estabelecimento = _estabelecimento;
            vlfatSaude = _vlfatSaude;
        }
        // gets
        public String getEstabelecimento() {
            return estabelecimento;
        }
        public double getVlfatSaude() {
            return vlfatSaude;
        }
        //sets
        public void setEstabelecimento(String _estabelecimento) {
            estabelecimento = _estabelecimento;
        }
        public void setVlfatSaude(double _vlfatSaude) {
            vlfatSaude = _vlfatSaude;
        }
        public override void faturar() {
            //base.faturar();
            Console.WriteLine("Digite o nome do estcabelecimento: ");
            String _estabelecimento = Console.ReadLine();
            setEstabelecimento(_estabelecimento);
            Console.WriteLine("Digite o valor da fatura de saude: ");
            double _valor = double.Parse(Console.ReadLine());
            setVlfatSaude(_valor);
            double fat;
            fat = getVlfatSaude()*1.12;
            Console.WriteLine("o valor do faturamento eh: " + fat + "reais e o nome do estabelecimento eh: " + getEstabelecimento());
        }
    }
}
