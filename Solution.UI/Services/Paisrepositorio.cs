using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solution.UI.Services
{
    public class Paisrepositorio : IRepositorioPais
    {
        public List<string> ObtenerTodos()
        {
            //List<String> paises = new List<string>() { "Costa Rica", "panama" };
            return new List<string>() { "Costa Rica", "panama" };
        }
    }
}
