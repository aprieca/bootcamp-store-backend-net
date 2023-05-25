﻿using AutoMapper;
using bootcamp_store_backend.Application.Dtos;
using bootcamp_store_backend.Domain.Entities;

namespace bootcamp_store_backend.Application.Mappings;

public class ItemMapperProfile : Profile
{
    public ItemMapperProfile()
    {

        CreateMap<Item, ItemDto>();
        CreateMap<ItemDto, Item>();
    }
}