using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListDataStructureProgram;

namespace LinkedListUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_Data_When_Searched_Should_Return_Found_Or_NotFound()
        {
            int data = 30;
            LinkedList list = new LinkedList();
            list.AddNode(56);
            list.AddNode(30);
            list.AddNode(70);
            Node node = list.SearchNode(30);
            Assert.AreEqual(data, node.data);
        }
    }
}
