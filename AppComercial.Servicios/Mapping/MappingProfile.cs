using AppComercial.Entidades;
using AppComercial.Entidades.DTOs.Marca;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppComercial.Servicios.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            LoadMarcaMapping();
        }

        private void LoadMarcaMapping()
        {
            CreateMap<Marca, MarcaListDto>();
            CreateMap<Marca, MarcaEditDto>().ReverseMap();
            CreateMap<MarcaEditDto, MarcaListDto>();
        }
    }
}
