using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using atividade2.Models;

namespace atividade2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
          public IActionResult ListagemDePedidos()
        {
           
           List<ItemPedido> listagemDaMemo = Dados.PedidoAtual.ListaPedidos();
           
           return View(listagemDaMemo);
        }

          public IActionResult Cadastro()
        {
            //carregar a view de cadastro
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(ItemPedido itemForm)
        {
            //receber os dados de formulario e salvar
            Dados.PedidoAtual.IncluirPedido(itemForm);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
