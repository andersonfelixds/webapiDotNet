using webapi.Models;
using System.Collections.Generic;
using System.Linq;
using System;


namespace webapi.Services
{
    public static class calculajurosService
    {
        
        public static double Get(double valorInicial, double meses)
        {

            return Math.Round(valorInicial * (Math.Pow((1 + TaxaJurosService.GetAll()), meses)),2);
        }

        
      
    }
}