using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DataPaging.Tests
{
    [TestClass]
    public class DataPaginTests
    {
        [TestCategory("Data Paging Tests")]
        [TestMethod("Generic List Empty")]
        public void GenericListEmpty()
        {

            var genericList = new List<object>();

            Assert.AreEqual(0, genericList.Pagination(1, 10).Count);
        }

        [TestCategory("Data Paging Tests")]
        [TestMethod("Generic List int values")]
        public void GenericListIntValues()
        {
            var genericList = new List<int> { 1,2,3,4,5,6,7,8,9,10,11};

            Assert.AreEqual(5, genericList.Pagination(1, 5).Count);
        }

        [TestCategory("Data Paging Tests")]
        [TestMethod("Generic List string values")]
        public void GenericListStringValuesFail()
        {
            var genericList = new List<string> { "1", "2", "3" };

            Assert.AreNotEqual(10, genericList.Pagination(1, 10).Count);
        }

        [TestCategory("Data Paging Tests")]
        [TestMethod("Generic List string values")]
        public void GenericListStringValuesSucess()
        {
            var genericList = new List<string> { "1", "2", "3" };

            Assert.AreEqual(3, genericList.Pagination(1, 10).Count);
        }
    }
}
