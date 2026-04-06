using System;

namespace tpmodul6_103082400042
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            this.title = title;
            // Generate ID random 5 digit [cite: 204]
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.playCount = 0; // Default 0 [cite: 204]
        }

        public void IncreasePlayCount(int count)
        {
            this.playCount += count;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("Play Count: " + this.playCount);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Panggil sesuai judul instruksi [cite: 207]
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Andra");

            // Coba tambah playCount standar
            video.IncreasePlayCount(100);

            video.PrintVideoDetails();
        }
    }
}