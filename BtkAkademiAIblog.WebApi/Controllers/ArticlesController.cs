using Microsoft.AspNetCore.Mvc;
using BtkAkademiAIblog.WebApi.Context;
using BtkAkademiAIblog.WebApi.Entities;
using System;  // Add this for DateTime

namespace BtkAkademiAIblog.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ArticlesController : ControllerBase  // Fixed: ControllerBase instead of ControllersBase
{
  private readonly BlokAIContext _context;
  public ArticlesController(BlokAIContext context)
  {
    _context = context;
  }

  [HttpGet]
  public IActionResult ArticleList()
  {
    var values = _context.Articles.ToList();  // Use plural "Articles" consistently
    return Ok(values);
  }

  [HttpPost]
  public IActionResult CreatArticle(Article article)
  {
    article.CreateDate = DateTime.Now;  // Fixed: DateTime.Now (capital N)
    _context.Articles.Add(article);
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
    return Ok(value);
  }

  [HttpPut]
  public IActionResult UpdateArticle(Article article)
  {
    _context.Articles.Update(article);
    _context.SaveChanges();
    return Ok("Guncelleme Islemi Basarili");
  }
  
}