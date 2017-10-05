using Delivery.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery.Domain.Models.Produtos
{
    public class Produto : Entity, Estoque.Structs.Estoque
    {
        public string Codigo { get; set; } = null;

        public string Nome { get; set; } = null;

        public string ModePreparo { get; set; } = null;

        public string Descricao { get; set; }

        public double PrecoVenda { get; set; } = 0;

        public double PrecoCusto { get; set; } = 0;

        public Guid Id_categoria { get; set; }

    }
}
