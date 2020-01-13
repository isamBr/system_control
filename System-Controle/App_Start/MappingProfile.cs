using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System_Controle.Dtos;
using System_Controle.Models;

namespace System_Controle.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {



            Mapper.CreateMap<Customer, CustomerDto>();

            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(m => m.Id, option => option.Ignore());


            Mapper.CreateMap<Movie, MovieDto>();

            //The exception is thrown when AutoMapper attempts to set the Id of movie: 
            Mapper.CreateMap<MovieDto, Movie>()
                 .ForMember(m => m.Id, option => option.Ignore());

            Mapper.CreateMap<MembershipType, MembershipDto>();

            //The exception is thrown when AutoMapper attempts to set the Id of movie: 
            Mapper.CreateMap<MembershipDto, MembershipType>()
                 .ForMember(m => m.Id, option => option.Ignore());
        }
    }
}