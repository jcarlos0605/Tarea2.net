using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2.Features.Productos
{
    public class Productos : Entity
    {

        public string Codigo { get; set; }

        public string Descripcion { get; set; }


        public decimal Precio {get; set; }


        public int Existencia { get; set; }

        public bool Activo { get; set; }
    }
}
