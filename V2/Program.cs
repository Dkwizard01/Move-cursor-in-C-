using System;

namespace Cursor;
public class Program
{ 
        public static string character = "x";  
     public static string apple = "a";
        public static int x = 5;
        public static int y = 5;
        public static bool check = true; 
        
     public static Random random = new Random(); 
     public static int moveApplex = random.Next(7,8);
     public static int moveAppley = random.Next(8,11);
	
  public static int counter = 1;
  
  
 public static void Main()
 
 {
   Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
	
  Console.SetCursorPosition(0,0);
     Console.WriteLine("Press D to move right, A to move left, W to jump and S to go down. Your goal is to collect the apple.");
      
       Move();
       

  
 }
 
 
 public static void Apple ()
{  
                            Console.SetCursorPosition(moveApplex,moveAppley);
                            Console.WriteLine(apple);
                             if((x == moveApplex) && (y == moveAppley))
                     { 
                        apple.Remove(0);
                        moveApplex = random.Next(12,26);
                        moveAppley = random.Next(4,6);
                        Console.SetCursorPosition(0,3);
                       Console.Write("Number of apples collected: " + counter+"");
                        counter++;
                       

                      
     
                     }
  
  
 }

 public static void Move()
 { 
	 Maze(); 
    
     Console.SetCursorPosition(5,5);
        while(check==true) { 
               
          Apple();
    
         var key = Console.ReadKey(intercept: true).Key; // Intercept does not work on Mono.
    switch(key)
    {
        case ConsoleKey.D:
         x++;
        Console.SetCursorPosition(x, y);
        Console.Write(character);
        break;
        case ConsoleKey.A:
        x--;
        Console.SetCursorPosition(x,y);
        Console.Write(character);
        break;
        case ConsoleKey.S:
        y++;
        Console.SetCursorPosition(x,y);
        Console.Write(character);
        break;
        case ConsoleKey.W:
        y--;
        Console.SetCursorPosition(x,y);
       Console.Write(character);
        break;
        default:
        check=false;
        return;
  
  
     }
    }
     
 } 
public static void Maze()
{
   for (int n=0; n<100; n++)
   {
      Console.SetCursorPosition(n,2);
      Console.WriteLine("|");
      
   }
  for (int j=0; j<100; j++)
   {
      Console.SetCursorPosition(j,10);
      Console.WriteLine("|");
      
   }

 
}

}
