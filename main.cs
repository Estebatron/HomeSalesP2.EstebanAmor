using System;
using System.Collections.Generic;
class Program {
  public static void Main (string[] args) {
    
    var initial1 = "";
    var initial2 = "";
    var initial3 = "";
    
    String[] names = {"Danielle", "Edward", "Frasncis"};
    
    List<string> allowedInitials = new List<string>{"D","E","F"};
    
      int sale1 = 0;
      int sale2 = 0;
      int sale3 = 0;
        int total = sale1 + sale2 +sale3;
    
    int[] sales = {sale1, sale2, sale3};
do 
{
  Console.WriteLine("Enter the name of the first salesperson");
  initial1 = Console.ReadLine();
  
if (allowedInitials.Contains(initial1))
  {
    Console.WriteLine("Enter the value of the first sale");
    sale1 = int.Parse(Console.ReadLine());
  }
  else
    {
    Console.WriteLine("Please enter a valid initial");
      continue;
    }
    
    
   

  
}while(true);
     
   }

 }
  
  