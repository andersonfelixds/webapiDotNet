using webapi.Models;
using System.Collections.Generic;
using System.Linq;

namespace webapi.Services
{
    public static class TaxaJurosService
    {
        static List<TaxaJuros> TaxaJuros { get; }
        static TaxaJurosService()
        {
            TaxaJuros = new List<TaxaJuros>
            {
                new TaxaJuros { Juros = (double) 0.01 },
            };
        }

        //public static List<TaxaJuros> GetAll() => TaxaJuros;
        public static double GetAll()
        {
            return 0.01;
        }
      
    }
}