using NUnit.Framework;
using IsometrixApp;

namespace IsometrixApp.Tests;

[TestFixture]
public class LinkedListTests
{
  [Test]
  public void Insert_EmptyList_HeadSetCorrectly()
  {
    var list = new LinkedList<string>();
    list.Insert(0, "Test");

    Assert.AreEqual("Test", list.head.Data);
    Assert.AreEqual(1, list.Count);
  }

  [Test]
  public void Insert_BeginningOfList_NodeInsertedAtHead()
  {
    var list = new LinkedList<int>();
    list.Insert(0, 10);
    list.Insert(0, 5);

    Assert.AreEqual(5, list.head.Data);
    Assert.AreEqual(2, list.Count);
  }

  [Test]
  public void Insert_MiddleOfList_NodeInsertedCorrectly()
  {
    var list = new LinkedList<string>();
    list.Insert(0, "A");
    list.Insert(1, "C");
    list.Insert(1, "B");

    var secondNode = list.head.Next;
    Assert.AreEqual("B", secondNode.Data);
    Assert.AreEqual(3, list.Count);
  }

}
