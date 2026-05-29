using Lesson2.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lesson2.Controllers;

public class HomeController : Controller
{
    private readonly IMemeRepository _memeRepository;

    public HomeController(IMemeRepository memeRepository)
    {
        _memeRepository = memeRepository;
    }

    public IActionResult Index()
    {
        var memes = _memeRepository.Get();
        return View(memes);
    }

    public IActionResult Details(int id)
    {
        var meme = _memeRepository.GetById(id);
        return View(meme);
    }

    // Добавленный метод для страницы Контакты
    public IActionResult Contact()
    {
        return View();
    }
}