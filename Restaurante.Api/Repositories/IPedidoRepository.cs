using System.Collections.Generic;
using Restaurante.Api.Model;

namespace Restaurante.Api.Repositories

{
    public interface IPedidoRepository
    {
        void AdicionarPedido(Pedido pedido);

        IEnumerable<Pedido> ListarPedido();
    }
}