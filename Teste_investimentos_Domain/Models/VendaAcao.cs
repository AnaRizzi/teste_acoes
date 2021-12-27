using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_investimentos_Domain.Models
{
    public class VendaAcao
    {
        public int IdAcao { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataVenda { get; set; }

    }
}
