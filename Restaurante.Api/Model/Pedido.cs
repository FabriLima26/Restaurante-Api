using System;

namespace Restaurante.Api.Model

{
    public class Pedido
    {
        public Pedido()
        {
            Id = Guid.NewGuid();
            
        }
        public Guid Id { get;}
        public string Descricao { get; set; }


    }
}