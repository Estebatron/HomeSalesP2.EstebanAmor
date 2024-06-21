using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    
    string initial1 = "";
    string initial2 = "";
    string initial3 = "";
    
    String[] names = {"Danielle", "Edward", "Frasncis"};
    
    List<string> allowedInitials = new List<string>{"d","D","e","E","f","F"};
    
      int sale1 = 0;
      int sale2 = 0;
      int sale3 = 0; //sets the natural state of the intigers to be 0
      
   
  
  do //First loop to get the first initial and first sale
    {
      Console.WriteLine("Enter the initial of the first salesperson");
      initial1 = Console.ReadLine();
   if (allowedInitials.Contains(initial1))
      {
     Console.WriteLine("Enter the value of the first sale");   
      sale1 = int.Parse(Console.ReadLine());
        break;
      }  
  
    else
       {
      Console.WriteLine("Please enter a valid initial");
         
      continue;    
       } 
      
  }while(true); //end of first loop
  
  do // Second loop to determine the second initial and second sale
  {
     Console.WriteLine("Please enter the initial of the second salesperson, or z to end program");
     initial2 = Console.ReadLine();
    
    if (allowedInitials.Contains(initial2))
    {
      Console.WriteLine("Please enter the second sales value");
      sale2 = int.Parse(Console.ReadLine());
      break;
    }
    else if (initial2 == "Z" || initial2 == "z")
    {
      goto end;
    }
    else
    {
      Console.WriteLine("Please enter a valid initial");
      continue;
    }
  }while(true); // End of second loop
  
  do // Third loop to determine the third initial and third sale
  {
    Console.WriteLine("Please enter the initial of the third salesperson, or z to end program");
    initial3 = Console.ReadLine();
    
    if (allowedInitials.Contains(initial3))
    {
      Console.WriteLine("Please enter the third sales value");
      sale3 = int.Parse(Console.ReadLine());
      break;
    }
    else if (initial3 == "Z" || initial3 == "z")
    {
      break;
    }
    else
    {
      Console.WriteLine("Please enter a valid initial");
      continue;
    }
  }while(true);// End of third loop
end:
    if(initial1 == allowedInitials[0] || initial1 == allowedInitials[1])
    {
      initial1 = "Danielle";
    }
    else if(initial1 == allowedInitials[2] || initial1 == allowedInitials[3])
    {
      initial1 = "Edward";
    }
    else
    {
      initial1 = "Francis";
    }

    if(initial2 == allowedInitials[0] || initial2 == allowedInitials[1])
      {
        initial2 = "Danielle";
      }
    else if(initial2 == allowedInitials[2] || initial2 == allowedInitials[3])
      {
        initial2 = "Edward";
      }
    else
    {
      initial2 = "Francis";
    }
    
    if(initial3 == allowedInitials[0] || initial3 == allowedInitials[1])
      {
        initial3 ="Danielle";
      }
    else if(initial3 == allowedInitials[2] || initial3 == allowedInitials[3])
      {
        initial3 = "Edward";
      }
    else { 
      initial3 = "Francis";
      }
     int[] sales = {sale1, sale2, sale3};
     int total = sale1 + sale2 +sale3;
    Console.WriteLine("Grand Total: $"+ total); // calculates total sales value

    if(sales[0]>sales[1] && sales[0]>sales[2])
     {
      Console.WriteLine("The highest sale was made by " + initial1 + " at $" + sales[0]);
     }
    else if(sales[1]>sales[0] && sales[1]>sales[2])
     {
      Console.WriteLine("The highest sale was made by " + initial2 + " at $" + sales[1]);
     }
    else
     {
      Console.WriteLine("The highest sale was made by " + initial3 + " at $" + sales[2]);
     }
       //above if statement determines who had the highest sale and displays it to the user.

   }
 }
  
  