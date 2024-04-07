﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BTLG06WNC;

public class HomeController : Controller
{
    
    private DbG06wncContext _context;

    public HomeController(DbG06wncContext context)
    {
        this._context = context;
    }

    public IActionResult Index()
    {
        return View(_context);
    }

    public IActionResult Activity()
    {
        var news = _context.Contents.Where(p => p.ICategoryId == 2).ToList();
        return View(news);
    }

    public IActionResult Contact()
    {
        return View();
    }

    public IActionResult Feedback()
    {
        return View();
    }

    public IActionResult Introduce()
    {
        return View();
    }

    public IActionResult Member()
    {
        var members = _context.Accounts.Where(p => p.IRoleId == 2).ToList();
        return View(members);
    }

    public IActionResult News()
    {
        var news = _context.Contents.Where(p => p.ICategoryId == 1).ToList();
        return View(news);
    }
}