using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.Interfaces
{
    public interface IConfiguracionServices
    {
        public Configuracion GetConfiguracionPorAtributo(string atributo);
    }
}
