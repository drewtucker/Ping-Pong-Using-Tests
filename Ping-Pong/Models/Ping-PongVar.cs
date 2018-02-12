using System;
using System.Collections.Generic;

namespace PingPong.Models
{
  public class PingPongGenerator
  {
    public List<string> PingPongOutput(int number)
    {
      List<string> pingPongList = new List<string>{};
      for (int i = 1; i <= number; i++)
      {
        if (IfPingPong(i))
        {
          pingPongList.Add("Ping-Pong");
        }
        else if (IfPong(i))
        {
          pingPongList.Add("Pong");
        }
        else if (IfPing(i))
        {
          pingPongList.Add("Ping");
        }
        else
        {
          pingPongList.Add(i.ToString());
        }
      }
      return pingPongList;
    }
    public bool IfPing(int num)
    {
      if (num % 3 == 0)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public bool IfPong(int num)
    {
      if (num % 5 == 0)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public bool IfPingPong(int num)
    {
      if ((num % 3 == 0) && (num % 5 == 0))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
