using System;

namespace HomeWork7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1.
            // Console.Write("side1:"); 
            // double side1 = double.Parse(Console.ReadLine());
            // Console.Write("side2:"); 
            // double side2= double.Parse(Console.ReadLine());
            
            // Rectangle rec = new Rectangle(); 
                
            //     rec.AreaCalculator(side1,side2);
            //     rec.PerimeterCalculator(side1,side2);

          //----------------------------------------------------//
            //Задание 2.
            //  Console.Write("Write Title:"); 
            //  string bookTitle = Console.ReadLine();
            //  Console.Write("Write Author:"); 
            //  string bookAuthor = Console.ReadLine();
            //  Console.Write("Write Content:"); 
            //  string bookContent = Console.ReadLine();
            // Book b = new Book();
            // b.ShowTitle(bookTitle);
            // b.ShowAuthor(bookAuthor);
            // b.ShowContent(bookContent);
           
          //-------------------------------------------------------//

          //Задание 3. 
          
           Car c = new Car("Toyota", "White", 240, 2010);
            c.getInfo(); 
            c.Drive();
            c.Stop();
            c.SpeedUp();

          
        }
    }

    

    //Задание 1.
    //  class Rectangle
    //  {
    //         public double side1 {get;set;}
    //         public double side2{get;set;} 
    //         public double area {get { return side1 * side2; } }
    //         public double perimeter{get { return 2 * (side1 + side2); }}
    

    
    //          public void AreaCalculator(double side1, double side2)
    //          {
    //             Console.WriteLine($"Ploshad pryamougolnika s = {side1 * side2}");
    //          }
    //          public void PerimeterCalculator(double side1, double side2)
    //          {
    //           Console.WriteLine($"Perimetr pryamogolnika P = {(side1 * side2)*2}");
    //          }
    //  }

    //------------------------------------------------------------------------------------//
    //Задание2.

    // class Book
    // {
    //     public string title {get;set;}
    //     public string author {get; set;}
    //     public string content {get;set;}

    //      public void ShowTitle(string title){
    //        Console.ForegroundColor = ConsoleColor.Yellow;  
    //          Console.WriteLine(title);
    //      }
    //      public void ShowAuthor(string author){
    //        Console.ForegroundColor = ConsoleColor.Red;  
    //          Console.WriteLine(author);
    //      }
    //      public void ShowContent(string content){
    //        Console.ForegroundColor = ConsoleColor.Green;  
    //          Console.WriteLine(content);
    //      }
    // }


    //---------------------------------------------------------------//

    //Задание 3.

    class Car 
    {
      public string model {get;set;}
      public string color {get;set;}
      public int speed {get;set;}
      public int year{get;set;}

      public Car(string model, string color, int speed, int year){
        this.model = model;
        this.color = color;
        this.speed = speed;
        this.year = year;
      }
      
      
      public void getInfo(){
          
        Console.WriteLine($"Model = {this.model}");
        Console.WriteLine($"Color = {this.color}");
        Console.WriteLine($"Speed = {this.speed} km/h");
        Console.WriteLine($"Year = {this.year}");
        Console.WriteLine("-------------------------------");
      }

      public void Drive(){
        Console.WriteLine("I can drive");
      }

      public void Stop(){
        Console.WriteLine("I can stop");
      }
      public void SpeedUp(){
        Console.WriteLine("I can speedUp to 240 km/h");
      }

    }
    
    
    

}

