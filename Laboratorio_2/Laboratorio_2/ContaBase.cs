using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_2
{
    class ContaBase
    {
        private string numeroIndentificacao;
        private string nomeCorrentista;
        protected double saldoAtual;

        public ContaBase(string numeroIndentificacao, string nomeCorrentista)
        {
            this.numeroIndentificacao = numeroIndentificacao;
            this.nomeCorrentista = nomeCorrentista;           
            this.saldoAtual = 0;
        }

        public string NumeroIndentificacao { get => numeroIndentificacao; }
        public string NomeCorrentista { get => nomeCorrentista; }       
        public double SaldoAtual { get => saldoAtual; }

        public string VerificarSaldo()
        {
            
            if (saldoAtual > 0)
            {
                return $"Seu saldo atual é: {saldoAtual.ToString("C")}";
            }
            else
            {
                return "Saldo atual indisponivel, verifique com o banco se existe dinheiro na conta ou se não há debitos.";
            }
        }


        public virtual string DebitarValorSaque(double valor)
        {
            return "Tipo de conta não foi informada, por favor tente novamente.";
        }

        public virtual string DebitarValorTransferencia(double valor)
        {
            return "Tipo de conta não foi informada, por favor tente novamente.";
        }

        public void DepositarDinheiro(double valor)
        {
            saldoAtual +=  valor;
        }

        public virtual string TransferirDinheiro(double valorTransferencia, ContaBase contaDestinatario)
        {
            return "Tipo de conta não foi informada, por favor tente novamente.";
        }
    }
}
