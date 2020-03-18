using Microsoft.AspNetCore.Mvc;
using RestaurantTown.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RestaurantTown.Controllers
{
  public class RestaurantsController : Controller
  {
    private readonly RestaurantTownContext _db;

    public RestaurantsController(RestaurantTownContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Cuisine> model = _db.Cusines.Include(cuisines => cuisines.Restaurants).ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.CategoryId = new SelectList(_db.Restaurants, "RestaurantId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Cuisine cuisine)
    {
      _db.Cusines.Add(cuisine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Cuisine thisCuisine = _db.Cuisines.FirstOrDefault(restaurants => restaurants.RestaurantId == id);
      return View(thisCuisine);
    }

    public ActionResult Edit(int id)
    {
      var thisResturant = _db.Restaurants.FirstOrDefault(restuarants => restuarants.ItemId == id);
      ViewBag.CuisineId = new SelectList(_db.Cusines, "CuisineId", "Name");
      return View(thisResturant);
    }

    [HttpPost]
    public ActionResult Edit(Restaurant restaurant)
    {
      _db.Entry(restaurant).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisResturant = _db.Restaurants.FirstOrDefault(restaurants => restaurants.RestaurantId == id);
      return View(thisResturant);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisResturant = _db.Restaurants.FirstOrDefault(restaurants => restaurants.RestaurantId == id);
      _db.Restaurants.Remove(thisResturant);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}