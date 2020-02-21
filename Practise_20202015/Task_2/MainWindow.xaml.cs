using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Task_2.Models;

namespace Task_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            using (var context = new DoctorWhoContext())
            {
                var enemies = context.TblEpisode.Where(episode => episode.AuthorId == 5)
                    .Include(episode => episode.EpisodeEnemies)
                    .ThenInclude(episodeE => episodeE.Enemy).ToList();

                //foreach (var episode in enemies)
                //{
                //    Console.WriteLine($"SeriesNumber-{episode.SeriesNumber}");
                //    foreach (var enemy in episode.EpisodeEnemies)
                //        Console.WriteLine($"EpisodeId-{enemy.EpisodeId}\nTitle-{enemy.Enemy.EnemyName}\n");
                //    Console.WriteLine("----------------------");
                //}
            }
        }
    }
}
