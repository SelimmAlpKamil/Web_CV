using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Portfolio
    {
        [Key]
        public int PortfolioId { get; set; }
        public string PortfolioTitle { get; set; }
        public string PortfolioImageURL { get; set; }
        public string PortfolioURL { get; set; }
    }
}
