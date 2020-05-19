﻿using System;
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
        private readonly ApplicationDbContext context;
        public HeroController(ApplicationDbContext context)
        {
            context = new ApplicationDbContext();
        }
        


        // GET: Hero
        public ActionResult Index()
        {

            return View();
        }

        // GET: Hero/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Hero/Create
        public ActionResult Create()
        {
            Hero hero = new Hero();
            return View(hero);
        }

        // POST: Hero/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Hero hero)
        {
            try
            {
                // TODO: Add insert logic here
                context.Heroes.Add(hero);
                context.SaveChanges();
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
            return View();
        }

        // POST: Hero/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Hero/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Hero/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}