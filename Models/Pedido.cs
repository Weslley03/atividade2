using System;
using System.Collections.Generic;

namespace atividade2.Models
{
    public class Pedido
    {
        private  List<ItemPedido> ListadePedido = new List<ItemPedido>();
        
        
        public void IncluirPedido(ItemPedido item)
        {
            ListadePedido.Add(item);
        }

        public double TotalizarPedido()
        {
            double total = 0;

            foreach(var lista in ListadePedido)
            {
                total = total +  lista.quantidade * lista.valorUnitario;
            }
            return total;
        }

        public List<ItemPedido> ListaPedidos()
        {
            return ListadePedido;
        }


    }

}