﻿using bootcamp_store_backend.Application.Dtos;
using bootcamp_store_backend.Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;

namespace bootcamp_store_backend.Infrastructure.Rest;
[Route("store/[controller]")]
[ApiController]

public class CategoriesController:ControllerBase
{

    private readonly ICategoryService _categoryService;

    public CategoriesController(ICategoryService categoryService) {
        _categoryService = categoryService;
    }

    [HttpGet]
    public ActionResult<CategoryDto> GetCategories()
    {
        var categories = _categoryService.GetAllCategories();
        return Ok(categories);
    }

}