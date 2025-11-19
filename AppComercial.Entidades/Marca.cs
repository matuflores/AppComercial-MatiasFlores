using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppComercial.Entidades
{
    public class Marca
    {
        public int MarcaId { get; set; }
        public string Descripcion { get; set; } = null!;

        public override string ToString()
        {
            return $"{Descripcion}";
        }
        public Marca Clonar()
        {
            return new Marca
            {
                MarcaId = MarcaId,
                Descripcion = Descripcion
            };
        }
    }
}
