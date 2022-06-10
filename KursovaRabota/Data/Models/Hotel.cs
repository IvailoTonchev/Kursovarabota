using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaRabota.Models
{
    public class Hotel
    {
        public int Id { get; set; }        
        public double Pricefor18orolders { get; set; }
        public double Priceforunder18years { get; set; }
        public double Priceforover60years { get; set; }
        public int Freerooms { get; set; }
        public int Cleaners { get; set; }
        
    }
}
