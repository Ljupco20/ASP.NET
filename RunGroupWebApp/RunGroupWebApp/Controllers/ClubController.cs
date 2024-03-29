﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroupWebApp.Data;
using RunGroupWebApp.Interfaces;
using RunGroupWebApp.Models;
using RunGroupWebApp.Repository;

namespace RunGroupWebApp.Controllers
{

    public class ClubController : Controller
    {
        private readonly IClubRepository _clubRepository;

        public ClubController(ApplicationDbContext context, IClubRepository clubRepository)
        {
            _clubRepository = clubRepository;
        }
        public async Task<IActionResult> Index() //C
        {
            IEnumerable<Club> clubs = await _clubRepository.GetAll(); //M
            return View(clubs); //V
        }
        public async Task<IActionResult> Detail(int id)
        {
            Club club = await _clubRepository.GetByIdAsync(id);
            return View(club);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
