using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery.Domain.Models.Estoque.Structs
{
    public class Estoque
    {
        bool Controlado { get; set; }

        double EstoqueMinimo { get; set; }

        double EstoqueAtual { get; set; }

        Guid Id_unidade { get; set; }
    }
}
