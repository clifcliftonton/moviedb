using System;
using System.Data;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using WebApplication1.Models;

namespace WebApplication.Controllers
{
    public class MovieController : Controller
    {

        private readonly MovieDBContext db = new MovieDBContext();


        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Error()
        //{
        //    return View();
        //}


        //public ActionResult List()
        //{
        //    if (!User.Identity.IsAuthenticated)
        //    {
        //        return RedirectToAction("error");
        //    }
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult GetList()
        //{
        //    try
        //    {
        //        int id = WebSecurity.GetUserId(User.Identity.Name);

        //        var lists = from e in db.MovieLists
        //                    where e.UserId == id
        //                    select e;
        //        return Json(new
        //        {
        //            Succeeded = true,
        //            Lists = lists.ToList()
        //        });

        //    }
        //    catch (Exception e)
        //    {
        //    }

        //    return Json(new
        //    {
        //        Succeeded = false,
        //        Message = "Failed to retrieve movie list"
        //    });
        //}

        //[HttpPost]
        //public ActionResult Add(Movie m)
        //{
        //    MovieList newML = new MovieList();
        //    try
        //    {
        //        int id = WebSecurity.GetUserId(User.Identity.Name);
        //        var ml = from e in db.MovieLists
        //                 where e.UserId == id
        //                 select e;
        //        if (!ml.Any())
        //        {
        //            newML.Id = Guid.NewGuid();
        //            newML.UserId = WebSecurity.GetUserId(User.Identity.Name);
        //            newML.Movies.Add(m);
        //        }
        //        else
        //        {
        //            newML = ml.First<MovieList>();
        //            newML.Movies.Add(m);
        //        }
        //        db.MovieLists.Add(newML);
        //        db.SaveChanges();

        //    }
        //    catch (Exception e)
        //    {
        //        return Json(new
        //        {
        //            Succeeded = false,
        //            Message = "Failed to add movie"
        //        });
        //    }
        //    return Json(new
        //    {
        //        Succeeded = true,
        //        Message = "Successfully added movie"
        //    });
        //}

    }
}
