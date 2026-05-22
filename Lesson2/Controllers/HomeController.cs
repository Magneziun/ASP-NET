using Lesson2.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Lesson2.Controllers;

public class HomeController : Controller
{
    private readonly CatRepository _catRepository;
    public HomeController()
    {
        _catRepository = new CatRepository();
    }

    public IActionResult Index()
    {
        var memes = _catRepository.Get();

        return View(memes);
    }

    public IActionResult Details(int id)
    {
        var meme = _catRepository.GetById(id);

        return View(meme);
    }
}
