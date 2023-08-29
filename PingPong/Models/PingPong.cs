using System;

namespace Game.Models
{
  public class PingPong
  {
    public int Steps {get; set;}

    public PingPong(int numSteps)
    {
      Steps = numSteps; 
    }
  }
}