using System;

namespace Delivery.Domain.Core.Models.Produtos
{
    public abstract class ProdutoEstoque
    {
        public Guid Id_unidade { get; set; }

        public bool EstoqueControlado { get; set; }

        public double? EstoqueMinimo { get; set; } 

        public double? EstoqueAtual { get; set; }

    }
}
