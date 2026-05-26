using Lesson2.Model;

namespace Lesson2.Repositories.Interfaces;

public interface IMemeRepository
{
    List<Meme> Get();
    Meme GetById(int id);
}