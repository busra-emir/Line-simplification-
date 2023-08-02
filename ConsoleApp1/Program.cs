using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;

public class Veri
{
    public List<Cooordinate> HatKoordinatlari { get; set; }

    public class Cooordinate
    {
        public double X { get; set; }
        public double Y { get; set; }

        
    }
}


public class Program
{
    // x0 y0 is point and x1,y1 x2,y2 are points of line
    public static void Main()
    {

        //List<(double x, double y)> newList = ReadJson.ReadData();

        //simplyfied_list.Add((newList[0].x, newList[0].y));
        //Simplify_points(newList, 0, newList.Count() - 1);
        //simplyfied_list.Add((newList[newList.Count() - 1].x, newList[newList.Count() - 1].y));
        //Console.WriteLine("SadelestirilmisHat: ");
        //foreach (var item in simplyfied_list)
        //{
        //    Console.WriteLine("X: " + item.x + ",  Y: " + item.y);
        //}
    }
}