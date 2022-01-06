using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models
{
    [Serializable]
    [Table("DH_Configuracion")]
    public class Configuracion
    {
        [Key]
        public int Id { get; set; }
        public string Atributo { get; set; }
        public string Valor { get; set; }
        public string Descripcion { get; set; }


    }
}
