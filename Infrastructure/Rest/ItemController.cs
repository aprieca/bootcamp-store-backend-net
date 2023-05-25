﻿using System.Security.Cryptography.X509Certificates;
using bootcamp_store_backend.Application.Dtos;
using bootcamp_store_backend.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace bootcamp_store_backend.Infrastructure.Rest;

[Route("store/[controller]")]
[ApiController]
public class ItemController : GenericCrudController<ItemDto>

{
    public ItemController(IItemService service) : base(service) { }

    [NonAction]
    public override ActionResult<IEnumerable<ItemDto>> Get() {
        throw new NotImplementedException();
    }

    [HttpGet("/store/categories/{categoryId}/items")]
    [Produces("application/json")]
    public ActionResult<IEnumerable<ItemDto>> GetAllFromCategory(long categoryId)
    {
        var categories = ((IItemService)_service).GetAllByCategoryId(categoryId);
        return Ok(categories);
    }
}