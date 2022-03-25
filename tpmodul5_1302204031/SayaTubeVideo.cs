using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace tpmodul5_1302204031
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo() { }
        public SayaTubeVideo(string judul)
        {
            if (judul.Length > 100 && judul == null)
                throw new Exception("Judul kelebihan");
            title = judul;
            Random rnd = new Random();
            id = rnd.Next(10000, 100000);
            playCount = 0;
        }
        public void IncreasePlayCount(int jumlah)
        {
            
            {
                playCount = checked(playCount + jumlah);
            }
            
            {
                Console.WriteLine("Jumlah play count akan melampaui batas");
            }
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("ID       :" + id);
            Console.WriteLine("Judul    :" + title);
            Console.WriteLine("Views    :" + playCount);
        }
    }
}