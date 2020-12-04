using System.Collections.Generic;
using Restaurante.Api.Model;

namespace Restaurante.Api.Repositories

{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly List<Pedido> _storage;

        public PedidoRepository()
        {
            _storage = new List<Pedido>();
        }
        
        public void ValidarPedido(Pedido pedido)
        {
            string entrada = "";
            string principal = "";
            string bebida = "";
            string sobremesa = "";
            string p = "";
            int contador = 1;

            string[] words = pedido.Descricao.Split(',');

            if(words[0] == "Manhã")
            {
               for(int i = 1; i < words.Length; i++)
               {
                   if(words[i] == " 1")
                   {
                       entrada = "ovos,";
                   }
                   if(words[i] == " 2")
                   {
                       principal = "torradas,";
                   }
                   if(words[i] == " 3")
                   {
                       if(bebida == "")
                       {
                           bebida = "café,";
                       }else{
                           contador++;
                           bebida = $"café(x{contador}),";
                           
                       }
                   }
                   if(words[i] == " 4")
                   {
                       sobremesa = "erro";
                   }

               }
            p = $"{entrada} {principal} {bebida} {sobremesa} ";

            }

             if(words[0] == "Noite")
            {
               for(int i = 1; i < words.Length; i++)
               {
                   if(words[i] == " 1")
                   {
                       entrada = "bife,";
                   }
                   if(words[i] == " 2")
                   {
                       if(principal == "")
                       {
                           principal = " batatas,";
                       }else{
                           contador++;
                           principal = $"batatas(x{contador}),";
                           
                       }
                    }
                    if(words[i] == " 3")
                    {
                       bebida = "vinho,";
                    }
                    if(words[i] == " 4")
                    {
                       sobremesa = "bolo";
                    }

               }

            p = $"{entrada} {principal} {bebida} {sobremesa} ";
            }

            pedido.Descricao = p;
        }
        public void AdicionarPedido(Pedido pedido)
        {
            ValidarPedido(pedido);
            _storage.Add(pedido);
        }

        public IEnumerable<Pedido> ListarPedido()
        {
            return _storage;
        }
    }
}