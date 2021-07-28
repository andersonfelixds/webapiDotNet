using webapi.Models;
using System.Collections.Generic;
using System.Linq;


namespace webapi.Services
{
    public static class ShowmeCodeService
    {
        static ShowmeCodeService()
        {
            
        }

        //public static List<TaxaJuros> GetAll() => TaxaJuros;
        public static string Get()
        {
            return (string ) "https://github.com/andersonfelixds/webapiDotNet";
        }
      
    }
}