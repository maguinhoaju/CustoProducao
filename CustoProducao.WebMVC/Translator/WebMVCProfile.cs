using AutoMapper;
using CustoProducao.Core.Entities;
using CustoProducao.WebMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustoProducao.WebMVC.Translator
{
    public class WebMVCProfile : Profile
    {
        public WebMVCProfile()
        {
            CreateMap<Empresa, EmpresaViewModel>().ReverseMap();
        }
    }
}
