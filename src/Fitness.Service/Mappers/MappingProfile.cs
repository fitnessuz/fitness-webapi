using AutoMapper;
using Fitness.Domain.Entities;
using Fitness.Domain.Entities.Carts;
using Fitness.Domain.Entities.Messages;
using Fitness.Domain.Entities.Orders;
using Fitness.Domain.Entities.Products;

namespace Fitness.Service.Mappers;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        /*//User
        CreateMap<User, UserResultDto>().ReverseMap();
        CreateMap<UserUpdateDto, User>().ReverseMap();
        CreateMap<UserCreationDto, User>().ReverseMap();

        //Teacher
        CreateMap<Teacher, TeacherResultDto>().ReverseMap();
        CreateMap<TeacherUpdateDto, Teacher>().ReverseMap();
        CreateMap<TeacherCreationDto, Teacher>().ReverseMap();

        //Product
        CreateMap<Product, ProductResultDto>().ReverseMap();
        CreateMap<ProductUpdateDto, Product>().ReverseMap();
        CreateMap<ProductCreationDto, Product>().ReverseMap();

        //ProductCategory
        CreateMap<ProductCategory, ProductCategoryResultDto>().ReverseMap();
        CreateMap<ProductCategoryUpdateDto, ProductCategory>().ReverseMap();
        CreateMap<ProductCategoryCrestionDto, ProductCategory>().ReverseMap();

        //Plan
        CreateMap<Plan, PlanResultDto>().ReverseMap();
        CreateMap<PlanUpdateDto, Plan>().ReverseMap();
        CreateMap<PlanCreationDto, Plan>().ReverseMap();

        //Attachment
        CreateMap<Attachment, AttachmentResultDto>().ReverseMap();

        //OrderEquepment
        CreateMap<OrderEquepment, OrderEquepmentResultDto>().ReverseMap();
        CreateMap<OrderEquepmentUpdateDto, OrderEquepment>().ReverseMap();
        CreateMap<OrderEquepmentCreationDto, OrderEquepment>().ReverseMap();

        //OrderProduct
        CreateMap<OrderProduct, OrderProductPackResultDto>().ReverseMap();
        CreateMap<OrderProductPackUpdateDto, OrderProduct>().ReverseMap();
        CreateMap<OrderProductPackCreationDto, OrderProduct>().ReverseMap();

        //Mesage
        CreateMap<Message, MessageResultDto>().ReverseMap();
        CreateMap<MessageUpdateDto, Message>().ReverseMap();
        CreateMap<MessageCreationDto, Message>().ReverseMap();

        //Equepment
        CreateMap<Equepment, EquepmentResultDto>().ReverseMap();
        CreateMap<EquepmentUpdateDto, Equepment>().ReverseMap();
        CreateMap<EquepmentCreationDto, Equepment>().ReverseMap();

        //EquepmentCategory
        CreateMap<EquepmentCategory, EquepmentCategoryResultDto>().ReverseMap();
        CreateMap<EquepmentCategoryUpdateDto, EquepmentCategory>().ReverseMap();
        CreateMap<EquepmentCategoryCreationDto, EquepmentCategory>().ReverseMap();

        //CartEquepment
        CreateMap<CartEquepment, CartEquepmentResultDto>().ReverseMap();
        CreateMap<CartEquepmentUpdateDto, CartEquepment>().ReverseMap();
        CreateMap<CartEquepmentCreationDto, CartEquepment>().ReverseMap();

        //CartProduct
        CreateMap<CartProduct, CartProductResultDto>().ReverseMap();
        CreateMap<CartProductUpdateDto, CartProduct>().ReverseMap();
        CreateMap<CartProductCreationDto, CartProduct>().ReverseMap();*/
    }
}