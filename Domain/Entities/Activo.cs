using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Activo
    {
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Valor { get; set; }
        public int VidaUtil { get; set; }
        public double ValorResidual { get; set; }
        public string Codigo { get; set; }
        public int IdEmpleado { get; set; }
        public EstadoActivo Estado { get; set; }

        public override string ToString()
        {
            return $"{this.Id}";
        }
    }
}
