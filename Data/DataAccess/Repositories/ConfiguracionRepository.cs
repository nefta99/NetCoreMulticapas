using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using Data.Utils;
using Services.Contracts;

namespace Data.DataAccess.Repositories
{
    public class ConfiguracionRepository : IConfiguracionRepository
    {
        //Atributos
        public DataContext Context { get; }
        //Constructor
        public ConfiguracionRepository(DataContext context)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));

        }


        //Metodos.
       public Configuracion GetConfiguracionPorAtributo(string atributo)
        {
            return this.Context.Configuracion.Where(w => w.Atributo == atributo).FirstOrDefault();
        }
    }
}
