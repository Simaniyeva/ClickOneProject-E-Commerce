﻿namespace Entities.DTOs.SubCategory;

public class SubCategoryUpdateDto : IDto
{
    public int Id { get; set; }
    public string Name { get; set; }

    //Relations
    public int CategoryId { get; set; }
}