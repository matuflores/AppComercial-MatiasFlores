using AppComercial.Datos.Interfaces;
using AppComercial.Entidades;
using AppComercial.Entidades.DTOs.Marca;
using AppComercial.Servicios.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppComercial.Servicios.Servicios
{
    public class MarcaServicio : IMarcaServicio
    {
        private readonly IMarcaRepositorio _marcaRepositorio;
        private readonly IMapper _mapper;

        public MarcaServicio(IMarcaRepositorio marcaRepositorio,IMapper mapper)
        {
            _marcaRepositorio = marcaRepositorio;
            _mapper = mapper;
        }
        public bool Agregar(MarcaEditDto marcaDto, out List<string> errores)
        {
            errores = new List<string>();
            Marca marca = _mapper.Map<Marca>(marcaDto);
            if (_marcaRepositorio.Existe(marca))
            {
                errores.Add("Marca existente!");
                return false;
            }
            _marcaRepositorio.Agregar(marca);
            return true;
        }

        public bool Borrar(int marcaId, out List<string> errores)
        {
            errores = new List<string>();
            _marcaRepositorio.Borrar(marcaId);
            return true;
            //ACA NO ESTOY CHEQUEANDO SI ESTA RELACIONADO
        }

        public bool Editar(MarcaEditDto marcaDto, out List<string> errores)
        {
            errores = new List<string>();
            Marca marca = _mapper.Map<Marca>(marcaDto);
            if (_marcaRepositorio.Existe(marca))
            {
                errores.Add("Marca Existente!!" + Environment.NewLine + "Edicion denegada");
                return false;
            }
            _marcaRepositorio.Editar(marca);
            return true;
        }

        public bool Existe(Marca marca)
        {
            return _marcaRepositorio.Existe(marca);
        }

        public List<MarcaListDto> GetMarca(string? textoParaFiltrar = null)
        {
            var marcas = _marcaRepositorio.GetPais(textoParaFiltrar);
            return _mapper.Map<List<MarcaListDto>>(marcas);
        }

        public MarcaEditDto? GetPorId(int marcaId)
        {
            Marca? marca = _marcaRepositorio.GetPorId(marcaId);
            if (marca is null)
            {
                return null;
            }
            return _mapper.Map<MarcaEditDto>(marca);
        }

        public int ObtenerCantidad()
        {
            return _marcaRepositorio.GetCantidad();
        }
    }
}
