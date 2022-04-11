using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_2
{
    class Conta_Poupança : ContaBase
    {
        const double tarifaSaqueContaPoupanca = 0.002d ;
        const double tarifaTransferenciaContaPoupanca = 0.0015d;
        private string mensagemInsuficienciaSaldo = "Saldo insuficiente ! entre em contato o banco."; 

        public Conta_Poupança(string numeroIndentificacao, string nomeCorrentista
               ):base(numeroIndentificacao,nomeCorrentista)
        {          
        }
        public override string DebitarValorSaque(double valor)
        {
            double valorTarifa = valor * tarifaSaqueContaPoupanca;
            if (saldoAtual - valor - valorTarifa < 0)
            {
                return mensagemInsuficienciaSaldo;
            }
            saldoAtual = saldoAtual - valor - valorTarifa;
            return "operação realizada com sucesso.";
        }

        public override string DebitarValorTransferencia(double valor)
        {
            double valorTarifa = valor * tarifaTransferenciaContaPoupanca;
            if (saldoAtual - valor - valorTarifa < 0)
            {
                return mensagemInsuficienciaSaldo;
            }
            saldoAtual = saldoAtual - valor - valorTarifa;
            return "operação realizada com sucesso.";
        }

        public override string TransferirDinheiro(double valorTransferencia,
            ContaBase contaDestinataria)
        {
            if (this.DebitarValorTransferencia(valorTransferencia) != mensagemInsuficienciaSaldo)
            {
                contaDestinataria.DepositarDinheiro(valorTransferencia);
                return "operação realizada com sucesso";
            }

            return mensagemInsuficienciaSaldo;
        }


    }

    
    
}
