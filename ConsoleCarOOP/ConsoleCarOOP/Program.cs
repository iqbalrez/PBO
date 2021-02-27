using System;

namespace ConsoleCarOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tampilan UI            
            Console.WriteLine("Masukkan Merk Kendaraanmu?");
            string merk = Console.ReadLine();
            // model
            Console.WriteLine("Masukkan Model Kendaraan?");
            string model = Console.ReadLine();
            // HP
            Console.WriteLine("Masukkan Horse Power Kendaraan Anda");
            double hp = Convert.ToDouble(Console.ReadLine());
            // instancing
            Vehicle car = new Vehicle(merk,model,hp);
            // call procedure 
            car.ShowVehicleInformation();
            // call function 
            double velocity = car.CalculateOptimumVelocity(hp);
          
            Console.WriteLine("Kecepatan Optimum Mobil ini adalah {0}", velocity );
            Console.ReadLine();


        }
    }
}
