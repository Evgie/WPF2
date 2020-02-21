using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Task2_1.Models;

namespace Task2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DoctorWhoContext())
            {
                var episodes = context.TblEpisode
                    .Include(ep => ep.EpisodeEnemies)
                    .ToList();
                foreach (var episode in episodes)
                {
                    Console.WriteLine($"Title: {episode.Title}");
                }

            }
        }
    }
}
