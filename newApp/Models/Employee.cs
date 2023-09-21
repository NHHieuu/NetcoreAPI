
namespace newApp.Models
{
     public class Employeeclass
     {
          public Employeeclass(){
               Ten = " Nguyen Hong Hieu";
               Masinhvien = "2121050189";
               Tuoi = 20;
          }
          public string Ten { get; set;}
          public string Masinhvien{ get; set;}
          public int Tuoi{get; set;}
          public int Luong{get; set;}
          public void nhapdulieu()
          {
               Console.Write("Ten:");
               Ten = Console.ReadLine();
               Console.Write("Masinhvien:");
               Masinhvien = Console.ReadLine();
               Console.Write("Tuoi: ");
               Tuoi = Convert.ToInt32(Console.ReadLine());
               Console.Write("Luong: ");
               Luong = Convert.ToInt16(Console.ReadLine());
          }
          public void Display(){
               Console.WriteLine("{0} - {1} - {2} - {3}", Ten, Masinhvien, Tuoi, Luong);
          }
          
     }
}