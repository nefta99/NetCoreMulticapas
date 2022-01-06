using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using Services.Contracts;
using Services.Services.Interfaces;

namespace Services.Services
{
    public class ConfiguracionService :IConfiguracionServices
    {
        //Atributos
        private IConfiguracionRepository ConfiguracionRepository { get; set; }
        //Constructor
        public ConfiguracionService(IConfiguracionRepository configuracionRepocitorio)
        {
            this.ConfiguracionRepository = configuracionRepocitorio ?? throw new ArgumentException(nameof(configuracionRepocitorio));
        }
        public Configuracion GetConfiguracionPorAtributo(string atributo)
        {
            return this.ConfiguracionRepository.GetConfiguracionPorAtributo(atributo);
        }
    }
}
