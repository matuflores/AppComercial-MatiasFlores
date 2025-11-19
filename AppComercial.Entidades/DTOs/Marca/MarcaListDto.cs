using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppComercial.Entidades.DTOs.Marca
{
    public class MarcaListDto
    {
        public int MarcaId { get; set; }
        public string Descripcion { get; set; } = null!;
    }
}
