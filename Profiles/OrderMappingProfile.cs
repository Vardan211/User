using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskVardan.DataAccess;
using TaskVardan.Domain.Models;

namespace TaskVardan.Profiles
{
    public class OrderMappingProfile:Profile 
    {
        public OrderMappingProfile()
        {
            CreateMap<UserDto, ApplicationUser>(MemberList.None).ReverseMap();
        }
    }
}
