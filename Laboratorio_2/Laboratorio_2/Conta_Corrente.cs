using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_2
{
    class Conta_Corrente : ContaBase
    {
        const double tarifaSaqueContaCorrent = 0.0037d;
        const double tarifaTransferenciaContaCorrente = 0.001d;
        private string mensagemSaldoInsuficiente = "Saldo insuficiente ! entre em contato o banco.";

        public Conta_Corrente(string numeroIndentificacao, string nomeCorrentista
               ) : base(numeroIndentificacao, nomeCorrentista)
        {
        }

        public override string DebitarValorSaque(double valor)
        {
            double valorTarifa = valor * tarifaSaqueContaCorrent;
            if (saldoAtual - valor - valorTarifa < 0)
            {
                return mensagemSaldoInsuficiente;
            }
            saldoAtual = saldoAtual - valor - valorTarifa;
            return "operação realizada com sucesso.";
        }

        public override string DebitarValorTransferencia(double valor)
        {
            double valorTarifa = valor * tarifaTransferenciaContaCorrente;
            if (saldoAtual - valor - valorTarifa < 0)
            {
                return mensagemSaldoInsuficiente;
            }
            saldoAtual = saldoAtual - valor - valorTarifa;
            return "operação realizada com sucesso.";
        }

        public override string TransferirDinheiro(double valorTransferencia,
            ContaBase contaDestinataria)
        {
            if (this.DebitarValorTransferencia(valorTransferencia) != mensagemSaldoInsuficiente)
            {
                contaDestinataria.DepositarDinheiro(valorTransferencia);
                return "operação realizada com sucesso";
            }

            return mensagemSaldoInsuficiente;
        }
    }
}
