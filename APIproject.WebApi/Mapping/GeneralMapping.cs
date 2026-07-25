using AutoMapper;
using APIproject.WebApi.Entities;
using APIproject.WebApi.Dtos.FeatureDtos;
using APIproject.WebApi.Dtos.MessageDtos;
using APIproject.WebApi.Dtos.ProductDtos;

namespace APIproject.WebApi.Mapping
{
    public class GeneralMapping: Profile
    {
        public GeneralMapping()
        {
            CreateMap<Feature, ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
            CreateMap<Feature, GetByIdFeatureDto>().ReverseMap();

            CreateMap<Message, ResultMessageDto>().ReverseMap();
            CreateMap<Message, CreateMessageDto>().ReverseMap();
            CreateMap<Message, UpdateMessageDto>().ReverseMap();
            CreateMap<Message, GetByIdMessageDto>().ReverseMap();

            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, ResultProductWithCategoryDto>().ForMember(x=>x.CategoryName, y=>y.MapFrom(z=>z.Category.CategoryName)).ReverseMap();
        }
    }
}
