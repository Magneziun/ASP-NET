using Lesson2.Model;
using Lesson2.Repositories.Interfaces;

namespace Lesson2.Repositories;

public class MemeRepository : IMemeRepository
{
    private List<Meme> _memes;

    public MemeRepository()
    {
        _memes = new List<Meme>
        {
            new() { Id = 1, Name = "БРДЫЩ", Description = "Брдыщ — это интернет-мем, представляющий собой сюрреалистичное гибридное существо. Это рыба с головой собаки, которое обрело огромную популярность в 2026 году в русскоязычном сегменте соцсетей", Rating = 666, PhotoSrc = "https://i.pinimg.com/736x/49/09/f5/4909f5060b1b5c5f2734b9422adc57fd.jpg" },
            new() { Id = 2, Name = "СЕМГА", Description = "Семга — это мем, который стал популярным в интернете, особенно среди молодежи. Он представляет собой странное животное, выглядящее как гибрид льва и кролика, которое появилось в ИИ-роликах о советском быте. Сначала это было просто шутка, но затем мем стал центром множества пародийных роликов и даже песен, где Черемша и Семга становятся героями, помогая советским гражданам в трудные времена", Rating = 67, PhotoSrc = "https://i.pinimg.com/736x/a7/35/67/a735672cec99d6af904e3b293d90d1c7.jpg" },
            new() { Id = 3, Name = "ЧЕРЕМША", Description = "Мем «Черемша» в сгенерированных нейророликах о суровых буднях в СССР стал заметным интернет-трендом в 2026 году — как и фраза «тихо, не спеша, без суеты». РБК Life разобрался, что означает этот мем и откуда он взялся.", Rating = 69, PhotoSrc = "https://i.pinimg.com/736x/00/7e/64/007e64f95ad1f95aff8b741a890dec99.jpg" },
            new() { Id = 4, Name = "НИКОГДА НЕ СДАВАЙСЯ", Description = "Описание не нужно, тут итак все понятно", Rating = 777, PhotoSrc = "https://i.pinimg.com/736x/25/bf/ed/25bfedf04c1c90162903f821d14eb20d.jpg"},
            new() { Id = 5, Name = "КОТ В СМЕТАНЕ", Description = "Кот типа жрал сметану и потом заляпался ну вы поняли, лицо у него еще тупое хахааха", Rating = 9210, PhotoSrc = "https://i.pinimg.com/736x/24/cb/68/24cb6862997f2bf23e7e9d62a2a3ac54.jpg"},
            new() { Id = 6, Name = "ВСПОМНИЛ", Description = "Переделка оригинального мема Забыл с тем же котом только грусным", Rating = 1991, PhotoSrc = "https://i.pinimg.com/736x/00/60/ab/0060abf5f013d9fc5e4e563af8a6aed9.jpg"},
            new() { Id = 7, Name = "AI", Description = "машинное зрени вышло на новый кровень, совеменные технологие без ошибок определяют содержимое изображений, это просто чудо", Rating = 29, PhotoSrc = "https://i.pinimg.com/736x/06/5d/9b/065d9b84f3dabb0b78631abf59f46bc9.jpg"},
            new() { Id = 8, Name = "Запарашцы", Description = "Хз че они делают но точно не письмо", Rating = 9, PhotoSrc = "https://i.pinimg.com/736x/26/6a/c6/266ac68366f6beeee6c94c81f8edc642.jpg"},
            new() { Id = 9, Name = "Новая банда", Description = "В Лос-Сантосе орудует новое опг они уже захватили в заложники С Джея, настоящие новости уточняются", Rating = 67, PhotoSrc = "https://i.pinimg.com/736x/4f/06/8b/4f068b1289f21d85fcabdbcda7374c3a.jpg"},
            new() { Id = 10, Name = "Хаско Фиаско ", Description = "У собаки есть на то свои причины, пса снизу тоже жалко", Rating = 6742, PhotoSrc = "https://i.pinimg.com/736x/8f/48/8b/8f488b2a32abff76d227b3ae5904e3d8.jpg"},
            new() { Id = 11, Name = "Роберт Оппенгеймер", Description = "Создаеет первое в мире ядерное оружие, формула записана мелом на доске", Rating = 999999, PhotoSrc = "https://i.pinimg.com/736x/90/e8/a7/90e8a73c09c7519b405ee297d42e0182.jpg"},
            new() { Id = 12, Name = "Просто мем", Description = "Для простого обывателя", Rating = 0, PhotoSrc = "https://i.pinimg.com/1200x/2c/70/a5/2c70a584cc85684bb4ac6c0549656a17.jpg"}
        };
    }

    public List<Meme> Get() => _memes;
    public Meme GetById(int id) => _memes.First(x => x.Id == id);
}