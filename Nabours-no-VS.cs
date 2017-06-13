using System;
using System.Collections.Generic;

namespace Mission.Planning
{
  class routine
  {
    //This is simply proof of concept, the actual program would utilize System.Data which this IDE does not have the ability to import.
    //will rewrite this when we get the devland up and running using the proper libraries. 
    //for now I give you: the entire program using nothing but strings and the console
    static string[] data = new string[0];
    static void Main()
    {
      Console.WriteLine(data.Length);
      Console.WriteLine("Enter 'new' or 'display'?");
        string in1 = Console.ReadLine();
      if (in1.ToLower() == "new")
      {
        Console.WriteLine("Enter Point/Line/circle");
          string in2 = Console.ReadLine();
          if (in2.ToLower() == "point")
          {
            Array.Resize(ref data, data.Length + 1);
            data[data.Length - 1]=NewPoint();
            Console.WriteLine("Added point successfully");
          }
          else if (in2.ToLower() == "line")
          {
            Array.Resize(ref data, data.Length + 1);
            data[data.Length - 1]=NewLine();
            Console.WriteLine("Added line successfully");
          }
          else if(in2.ToLower() == "circle")
          {
            Array.Resize(ref data, data.Length + 1);
            data[data.Length - 1]=NewCircle();
            Console.WriteLine("Added circle successfully");
          }
          else 
          {
            Console.WriteLine("Invalid entry");
          }
            Main();
      }
      else if (in1.ToLower() == "display")
      {
        Console.WriteLine("enter a value to search by, or enter 'all' to display all");
          string in3 = Console.ReadLine();
          if (in3.ToLower() == "all")
          {
            foreach (string s in data)
            {
              Console.WriteLine(s);
            }
          }
          else Display(data, in3);
          Main();
      }
    }
    static string NewPoint()
    {
      Console.WriteLine("Enter 'X' Coordinate");
        string x = Console.ReadLine();
        ErrorCheck(x);
        
      Console.WriteLine("Enter 'Y' Coordinate");
        string y = Console.ReadLine();
        ErrorCheck(y);
        
      Console.WriteLine("Enter a name for the point (" + x + "," + y + ")");
        string pointName = Console.ReadLine();
        
      string point = String.Format("Point {0} = ({1},{2})", pointName, x, y);
      return point;
    }
    static string NewLine()
    {
      string result;
      
      Console.WriteLine("Enter 'X1' Coordinate");
        string x1 = Console.ReadLine();
        ErrorCheck(x1);
        
      Console.WriteLine("Enter 'Y1' Coordinate");
        string y1 = Console.ReadLine();
        ErrorCheck(y1);
        
      Console.WriteLine("Enter 'X2' Coordinate");
        string x2 = Console.ReadLine();
        ErrorCheck(x2);
        
      Console.WriteLine("Enter 'Y2' Coordinate");
        string y2 = Console.ReadLine();
        ErrorCheck(y2);
        
      Console.WriteLine("Enter a name for the line (" + x1 + "," + y1 + ") -> (" + x2 + "," + y2 + ")");
        string lineName = Console.ReadLine();
        
      string line = "line " + lineName + " = (" + x1 + "," + y1 + ")";
      do
      {
        Console.WriteLine("Enter an X Coordinate for the midpoint");
          string x3 = Console.ReadLine();
         ErrorCheck(x3);
          
        Console.WriteLine("Enter a Y Coordinate for the midpoint");
          string y3 = Console.ReadLine();
         ErrorCheck(y3);
          
        line +=  " -> (" + x3 + "," + y3 + ")";
        Console.WriteLine("Add another midpoint? y/n");
        result = Console.ReadLine();
          
      }while(result!="n");
      line += " -> (" + x2 + "," + y2 + ")";
      return line;
    }
    static string NewCircle()
    {
      Console.WriteLine("Enter 'X' Coordinate for the centerpoint");
        string x = Console.ReadLine();
        ErrorCheck(x);
      Console.WriteLine("Enter 'Y' Coordinate for the centerpoint");
        string y = Console.ReadLine();
        ErrorCheck(y);
      Console.WriteLine("Enter a radius for the circle");
        string r = Console.ReadLine();
        ErrorCheck(r);
      Console.WriteLine("Enter a name for the circle (" + x + "," + y + ") r=" + r);
        string circleName = Console.ReadLine();
      string circle = String.Format("Circle {0} = ({1},{2}) r = {3}", circleName, x, y, r);
      return circle;
    }
    static void Display(String[] stringdata, string k)
    {
      foreach (string z in stringdata)
      {
        if (z.Contains(k)) Console.WriteLine(z);
      }
    }
    static void ErrorCheck(string s)
    {
      foreach (char c in s)
      if (char.IsWhiteSpace(c)==false | char.IsNumber(c)==false)
      {
        Console.WriteLine("You've met a terrible fate haven't you?");
        Array.Resize(ref data, data.Length-1);
        Main();
      }
    }
  }
}
