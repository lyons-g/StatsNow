using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using StatsNow.Models;

namespace StatsNow.Controllers
{
    public class GamesController : Controller
    {
        private readonly AppDbContext _context;

        public GamesController(AppDbContext context)
        {
            _context = context;
        }


        // GET: Games
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Games.Include(g => g.Category);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Games/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Games
                .Include(g => g.Category)
                .FirstOrDefaultAsync(m => m.GameId == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // GET: Games/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId");
            return View();
        }

        // POST: Games/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GameId,Home,Away,Venue,HomeScore,AwayScore,IsGamesOfTheSeason,CategoryId,Win,FG,FGA,FGperC")] Game game)
        {
            if (ModelState.IsValid)
            {
                _context.Add(game);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", game.CategoryId);
            return View(game);
        }

        // GET: Games/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Games.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", game.CategoryId);
            return View(game);
        }

        // POST: Games/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GameId,Home,Away,Venue,HomeScore,AwayScore,IsGamesOfTheSeason,CategoryId,Win,FG,FGA,FGperC")] Game game)
        {
            if (id != game.GameId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(game);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameExists(game.GameId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", game.CategoryId);
            return View(game);
        }

        // GET: Games/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Games
                .Include(g => g.Category)
                .FirstOrDefaultAsync(m => m.GameId == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // POST: Games/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var game = await _context.Games.FindAsync(id);
            _context.Games.Remove(game);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        
        private bool GameExists(int id)
        {
            return _context.Games.Any(e => e.GameId == id);
        }


        //   public async Task<IActionResult> Dashboard()
        //     {
        //        var JsonData = Json(await _context.Games.ToListAsync());
        //        return View();

        public IActionResult GameStats()
        {
            var Data = Json(_context.Games.ToListAsync());
            return Json(Data);
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public async Task<JsonResult> Method()
        {
            var game = await _context.Games.Select(g => g.GameId).Distinct().ToListAsync();

            var win = _context.Games
                .Where(g => g.Win == "Yes")
                .Select(g => g.FGperC);
            var CountWin = win.ToArray();

            var loss = _context.Games
                .Where(g => g.Win == "No")
                .Select(g => g.FGperC);
            var CountLoss = loss.ToArray();

            var all = _context.Games
                .Select(g => g.FGperC).ToArray();

            return new JsonResult(new { myGame = game, myWin = win, myLoss = loss, myAll=all });

       
        }

      /*  public async Task<JsonResult>BarChart()
        {
            var label = await _context.Games.Select(g => g.GameId).Distinct().ToListAsync();

            var WinFg = _context.Games;
             

            return new JsonResult(new { });
        }*/
        }
    }




        
        

