using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PingPong.Models;
using System;

namespace PingPong.Tests
{
  [TestClass]
  public class PingPongTest
  {
    [TestMethod]
    public void GetPing_ReturnPing_Int()
    {
      int test = 30;
      PingPongGenerator ping = new PingPongGenerator();
      Assert.AreEqual(true, ping.IfPing(test));
    }
    [TestMethod]
    public void GetPong_ReturnPong_Int()
    {
      int test = 150;
      PingPongGenerator pong = new PingPongGenerator();
      Assert.AreEqual(true, pong.IfPong(test));
    }
    [TestMethod]
    public void GetPing_ReturnPingPong_Int()
    {
      int test = 90;
      PingPongGenerator pingPong = new PingPongGenerator();
      Assert.AreEqual(true, pingPong.IfPingPong(test));
    }
    [TestMethod]
    public void GetPingPongOutput_ReturnPingPongList_String()
    {
      int userInputNumber = 15;
      PingPongGenerator pingPong = new PingPongGenerator();
      List<string> testList = pingPong.PingPongOutput(userInputNumber);
      testList.ForEach(i => Console.Write("{0}\t", i));
      Console.WriteLine("");
      List<string> expectedResult = new List<string>{"1","2","Ping","4","Pong","Ping","7","8","Ping","Pong","11","Ping","13","14","Ping-Pong"};
      CollectionAssert.AreEqual(expectedResult, testList);
    }
  }
}
