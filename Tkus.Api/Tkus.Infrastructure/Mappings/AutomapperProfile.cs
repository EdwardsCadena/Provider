using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tkus.Infrastructure.Data;
using Tkus.Core.DTOs;
using Tkus.Core.Entities;

namespace Tkus.Infrastructure.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {

            CreateMap<City, CityDtos>();
            CreateMap<CityDtos, City>();

            CreateMap<Form, FormDtos>();
            CreateMap<FormDtos, Form>();

            CreateMap<Service, ServiceDtos>();
            CreateMap<ServiceDtos, Service>();

            CreateMap<Supplier, SupplierDtos>();
            CreateMap<SupplierDtos, Supplier>();

            CreateMap<Typeform, TypeformDtos>();
            CreateMap<TypeformDtos, Typeform>();


        }
    }
}
