namespace Delivery.Domain.Core.Models
{
    public abstract class ProdutoConfiguracao
    {
        public bool VendaPorQuilo { get; set; }

        public bool IsentoTaxaServico { get; set; }

        public bool ItemCozinha { get; set; }
    }
}
