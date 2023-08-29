using System;
using System.Collections.Generic;

namespace Game.Models
{
  public class PingPong
  {
    public int Steps {get; set;}

    public PingPong(int numSteps)
    {
      Steps = numSteps; 
    }
    public List<string> DoPingPong()
    {
      List<string> result = new List<string>{};
      for(int i=1; i<=Steps; i++)
      {
        string toAdd = "";
        if(i%3 == 0)
        {
          toAdd += "ping";
          
        }
        if(i%5==0)
        {
          toAdd += "pong";
        }
        if(!(i%3 ==0) && !(i%5==0))
        {
          toAdd += $"{i}";
        }
        result.Add(toAdd);
        Console.WriteLine($"Added {toAdd}");
        toAdd = "";
      }
      return result;
    }
  }
}