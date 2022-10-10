using api_itexpert_task1.DAL.Entities;
using AutoMapper;
using System;

namespace api_itexpert_task1.Models.Mapping
{
    public class ModelsMappingProfile : Profile
    {
        public ModelsMappingProfile()
        {
            CreateMap<CodeValueModel, CV>().ReverseMap();
        }
    }
}
