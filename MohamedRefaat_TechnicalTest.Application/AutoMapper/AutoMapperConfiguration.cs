﻿using AutoMapper;
using PanMedica.Application.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MohamedRefaat_TechnicalTest.Application.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DomainToDTOsProfile());
                cfg.AddProfile(new DTOsToDomainProfile());
            });
        }
    }
}
