using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookGallery.Models;
using ComicBookGallery.Data;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ComicBooksController()
        {
            comicRepository = new ComicRepository();
        }

        private ComicRepository comicRepository;

        public ActionResult Index()
        {
            return View(comicRepository.GetComicBooks());
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
                return HttpNotFound();
            ComicBook comicBook = comicRepository.GetComicBook(id.Value);
            if (comicBook == null)
                return HttpNotFound();
            return View(comicBook);
        }
    }
}