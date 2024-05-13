using controle_de_banco_atividade.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace controle_de_banco_atividade.Controllers
{
    public class ContaController : Controller
    {
        private static List<Conta> contas = new List<Conta>();

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult ListarContas()
        {
            return View("ListarContas", contas);
        }

        [HttpPost]
        public IActionResult CriarConta(string tipoConta, string nomeCliente, float saldo)
        {
            if (tipoConta == "Poupanca" && saldo >= 100)
            {
                saldo = saldo / 100;

                ContaPoupanca contaPoupanca = new ContaPoupanca(nomeCliente, saldo);

                contaPoupanca.CriarConta(nomeCliente, saldo);

                contas.Add(contaPoupanca);

                ViewBag.mensagem = "Sua conta Poupança foi criada com sucesso!";
            }
            else if (tipoConta == "Corrente" && saldo > 0)
            {
                saldo = saldo / 100;

                ContaCorrente contaCorrente = new ContaCorrente(nomeCliente, saldo);

                contaCorrente.CriarConta(nomeCliente, saldo);

                contas.Add(contaCorrente);

                ViewBag.mensagem = "Conta Corrente criada foi criada com sucesso";
            }
            else
            {
                ViewBag.mensagemErro = "Erro ao efetuar a criação da sua conta. Desculpe, tente novamente!";
            }

            return RedirectToAction("ListarContas");

            
        }
    }
}
