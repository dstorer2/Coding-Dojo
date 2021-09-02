using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;
using Microsoft.EntityFrameworkCore;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))
                .ToList();
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            //question 1
            ViewBag.womenLeagues = _context.Leagues
                .Where(w => w.Name.Contains
                ("Womens'"))
                .ToList();

            //question 2
            ViewBag.HockeyLeagues = _context.Leagues
                .Where(h => h.Sport == "Ice Hockey")
                .ToList();

            //question 3
            ViewBag.nonFootballLeagues = _context.Leagues
                .Where(nf => nf.Sport != "Football")
                .ToList();

            //question 4
            ViewBag.conferenceLeagues = _context.Leagues
                .Where(h => h.Name.Contains( "Conference"))
                .ToList();

            //question 5
            ViewBag.atlanticLeagues = _context.Leagues
                .Where(h => h.Name.Contains( "Atlantic"))
                .ToList();

            //question 6
            ViewBag.dallasTeams = _context.Teams
                .Where(h => h.Location.Contains( "Dallas"))
                .ToList();

            //question 7
            ViewBag.raptorsTeams = _context.Teams
                .Where(h => h.TeamName.Contains( "Raptors"))
                .ToList();

            //question 8
            ViewBag.cityTeams = _context.Teams
                .Where(h => h.Location.Contains( "City"))
                .ToList();

            //question 9
            ViewBag.TTeams = _context.Teams
                .Where(h => h.TeamName.Contains("T"))
                .ToList();

            //question 10
            ViewBag.allAlphaTeams = _context.Teams
                .OrderBy(team => team.Location)
                .ToList();

            //question 11
            ViewBag.allRevAlphaTeams = _context.Teams
                .OrderByDescending(team => team.TeamName)
                .ToList();

            //question 12
            ViewBag.Coopers = _context.Players
                .Where(player => player.LastName.Contains("Cooper"))
                .ToList();

            //questions 13
            ViewBag.Joshuas = _context.Players
                .Where(player => player.FirstName.Contains("Joshua"))
                .ToList();

            //question 14
            ViewBag.notJoshCooper = _context.Players
                .Where(player => player.LastName.Contains("Cooper"))
                .Where(player => player.FirstName != "Joshua")
                .ToList();

            //question 15
            ViewBag.AlexAndWyatt = _context.Players
                .Where(player => player.FirstName.Contains("Alexander") || player.FirstName.Contains("Wyatt"))
                .ToList();

            return View();
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            //question 1
            ViewBag.ASCTeams = _context.Teams
                .Include(team => team.CurrLeague)
                .Where(team => team.CurrLeague.Name.Contains("Atlantic Soccer Conference"))
                .ToList();

            //question 2
            ViewBag. PensPlayers = _context.Players
                .Include(guy => guy.CurrentTeam)
                .Where(team => team.CurrentTeam.Location.Contains("Boston") && team.CurrentTeam.TeamName.Contains("Penguins"))
                .ToList();

            //question 3
            ViewBag.ICBCPlayers = _context.Players
                .Include(player => player.CurrentTeam.CurrLeague)
                .Where(player => player.CurrentTeam.CurrLeague.Name == "International Collegiate Baseball Conference")
                .ToList();

            //question 4
            ViewBag.ACAFLopezes = _context.Players
                .Include(player => player.CurrentTeam.CurrLeague)
                .Where(player => player.LastName.Contains("Lopez") && player.CurrentTeam.CurrLeague.Name.Contains("American Conference of Amateur Football"))
                .ToList();

            //question 5
            ViewBag.FootballBoys = _context.Players
                .Include(player => player.CurrentTeam.CurrLeague)
                .Where(player => player.CurrentTeam.CurrLeague.Sport.Contains("Football"))
                .ToList();

            //question 6
            ViewBag.SophiaTeams = _context.Teams
                .Include(team => team.CurrentPlayers)
                .Where(team => team.CurrentPlayers.Any(player => player.FirstName == "Sophia"))
                .ToList();

            //question 7
            ViewBag.SophiaLeagues = _context.Leagues
                .Include(league => league.Teams)
                .Where(league => league.Teams.Any(team => team.CurrentPlayers.Any(player => player.FirstName == "Sophia")))
                .ToList();

            //question 8
            ViewBag.Flores = _context.Players
                .Include(players => players.CurrentTeam)
                .Where(player => player.LastName == "Flores" && player.CurrentTeam.TeamName != "Roughriders" && player.CurrentTeam.Location != "Washington")
                .ToList();


            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            //question 1
            ViewBag.SamEvans = _context.Players
                .Include(player => player.AllTeams)
                    .ThenInclude(teams => teams.TeamOfPlayer)
                .FirstOrDefault(player => player.FirstName.Contains("Samuel") && player.LastName.Contains("Evans"));

            //question 2
            ViewBag.TigerCats = _context.Teams
                .Include(team => team.CurrentPlayers)
                .Include(team => team.AllPlayers)
                    .ThenInclude(player => player.PlayerOnTeam)
                .FirstOrDefault(team => team.TeamName.Contains("Tiger-Cats") && team.Location.Contains("Manitoba"));

            //question 3
            ViewBag.FormerVikings = _context.Teams
                .Include(team => team.AllPlayers)
                    .ThenInclude(player => player.PlayerOnTeam)
                .FirstOrDefault(team => team.TeamName.Contains("Vikings") && team.Location.Contains("Wichita"));

            //question 4
            ViewBag.Gray = _context.Players
                .Include(play => play.AllTeams)
                    .ThenInclude(team => team.TeamOfPlayer)
                .FirstOrDefault(play => play.FirstName.Contains("Jacob") && play.LastName == "Gray");

            //question 5
            ViewBag.AFoABP = _context.Leagues
                .Include(lea => lea.Teams)
                    .ThenInclude(tea => tea.AllPlayers)
                        .ThenInclude(al => al.PlayerOnTeam)
                .FirstOrDefault(lea => lea.Name == "Atlantic Federation of Amateur Baseball Players");
            
            //question 6
            

            return View();
        }

    }
}