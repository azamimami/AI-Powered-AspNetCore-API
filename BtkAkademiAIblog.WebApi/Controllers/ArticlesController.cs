using Microsoft.AspNetCore.Mvc;
using BtkAkademiAIblog.WebApi.Context;
using BtkAkademiAIblog.WebApi.Entities;
using System;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using BtkAkademiAIblog.WebApi.Dtos.ArticleDtos;  // Add this for DateTime

namespace BtkAkademiAIblog.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ArticlesController : ControllerBase  // Fixed: ControllerBase instead of ControllersBase
{
  private readonly BlokAIContext _context;
  private readonly IMapper _mapper;
  public ArticlesController(BlokAIContext context, IMapper mapper)
  {
    _context = context;
    _mapper = mapper;
  }

  [HttpGet]
  public IActionResult ArticleList()
  {
    var values = _context.Articles.Include(x => x.Category).ToList();  // Use plural "Articles" consistently
    var dto = _mapper.Map < List<ResultArticleWithCategoryDto>>(values);
    return Ok(dto);
  }

  [HttpPost]
  public IActionResult CreatArticle(CreatArticleDto creatArticleDto)
  {
    creatArticleDto.CreateDate = DateTime.Now;  // Fixed: DateTime.Now (capital N)
    var values = _mapper.Map<Article>(creatArticleDto);
    _context.Articles.Add(values);
    _context.SaveChanges();
    return Ok("Ekleme Islemi Basarili");
  }

  [HttpDelete]
  public IActionResult DeleteArticle(int id)
  {
    var value = _context.Articles.Find(id);
    if (value == null)  // Add null check for safety
    {
        return NotFound("Article not found");
    }
    _context.Articles.Remove(value);
    _context.SaveChanges();
    return Ok("Silme Islemi Basarili");
  }

  [HttpGet("GetArticle")]
  public IActionResult GetArticle(int id)
  {
    var value = _context.Articles.Find(id);
    if (value == null)  // Add null check for safety
    {
        return NotFound("Article not found");
    }
    return Ok(_mapper.Map<GetArticleByIdDto>(value));
  }

  [HttpPut]
  public IActionResult UpdateArticle(UpdateArticleDto updateArticleDtoArticleDto)
  {
    var value = _mapper.Map<Article>(updateArticleDtoArticleDto);
    _context.Articles.Update(value);
    _context.SaveChanges();
    return Ok("Guncelleme Islemi Basarili");
  }

}