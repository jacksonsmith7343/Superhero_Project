using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFavoriteSuperHero_Project.Data;
using MyFavoriteSuperHero_Project.Models;

namespace MyFavoriteSuperHero_Project.Controllers
{
    
    public class HeroController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HeroController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        // GET: Hero
        public ActionResult Index()
        {
            
            return View(_context.Heroes);
        }

        // GET: Hero/Details/5
        public ActionResult Details(int id)
        {
            var heroInDb = _context.Heroes.Where(s => s.Id == id).FirstOrDefault();
            return View(_context.Heroes);
        }

        // GET: Hero/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hero/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Hero hero)
        {
            try
            {
                // TODO: Add insert logic here
                _context.Heroes.Add(hero);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hero/Edit/5
        public ActionResult Edit(int id)
        {
            var heroInDb = _context.Heroes.Where(s => s.Id == id).FirstOrDefault();
            
            return View(heroInDb);
        }

        // POST: Hero/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Hero hero)
        {
            try
            {
                // TODO: Add update logic here
                var heroInDb = _context.Heroes.Where(s => s.Id == id).FirstOrDefault();
                heroInDb.Name = hero.Name;
                heroInDb.AlterEgo = hero.AlterEgo;
                heroInDb.PrimarySuperheroAbility = hero.PrimarySuperheroAbility;
                heroInDb.SecondarySuperheroAbility = hero.SecondarySuperheroAbility;
                heroInDb.CatchPhrase = hero.CatchPhrase;
                _context.SaveChanges();
                return RedirectToAction("Index");
                
            }
            catch
            {
                return View();
            }
        }

        // GET: Hero/Delete/5
        public ActionResult Delete(int id)
        {
            var heroInDb = _context.Heroes.Where(s => s.Id == id).FirstOrDefault();
            return View(id);
        }

        // POST: Hero/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Hero hero)
        {
            try
            {
                // TODO: Add delete logic here
                _context.Heroes.Remove(hero);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}