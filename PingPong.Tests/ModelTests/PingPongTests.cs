using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Pong;

namespace Program.Tests
{
  [TestClass]
  public class PingPongTest
  {
    [TestMethod]
    public void IsPingPong_PrintOne_1()
    {
        List<string> expected = new List<string>{"1"};
        PingPong actual = new PingPong();
        CollectionAssert.AreEqual(expected,  actual.IsPingPong(1));
    }

    [TestMethod]
    public void IsPingPong_PrintPing_Ping()
    {
        List<string> expected = new List<string>{"1", "2", "ping"};
        PingPong actual = new PingPong();
        CollectionAssert.AreEqual(expected,  actual.IsPingPong(3));
    }

    [TestMethod]
    public void IsPingPong_PrintPong_Pong()
    {
        List<string> expected = new List<string>{"1", "2", "ping", "4", "pong"};
        PingPong actual = new PingPong();
        CollectionAssert.AreEqual(expected,  actual.IsPingPong(5));
    }

        [TestMethod]
    public void IsPingPong_PrintPingPong_PingPong()
    {
        List<string> expected = new List<string>{"1", "2", "ping", "4", "pong", "ping", "7", "8", "ping", "pong", "11", "ping", "13", "14", "ping-pong"};
        PingPong actual = new PingPong();
        CollectionAssert.AreEqual(expected,  actual.IsPingPong(15));
    }
  }
}