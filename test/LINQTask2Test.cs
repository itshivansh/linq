using LINQBasics;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace test
{
    public class LINQTask2Test: IClassFixture<TestFixture2>
    {
        TestFixture2 _fixture2;
        private readonly LINQTask2 LINQTask2PropertyObject;
        #region Constructor
        public LINQTask2Test(TestFixture2 fixture2)
        {
            _fixture2 = fixture2;
            LINQTask2PropertyObject = _fixture2.LINQTask2Property;
        }
        #endregion
        [Fact]
        public void TestToGetEmployeeIdsfromList()
        {
            //Arrange
            //Actual
            int[] actual = LINQTask2PropertyObject.FunToSendSelectedEmployeeIds();
            int[] expected = { 1, 2, 3};
            //Assert
            Assert.Equal(expected, actual);
        }
       
    }
    #region TestFixtureClass
    public class TestFixture2 : IDisposable
    {
        public LINQTask2 LINQTask2Property { get; private set; }
        public TestFixture2()
        {
            LINQTask2Property = new LINQTask2();
        }
        public void Dispose()
        {
            LINQTask2Property = null;
        }
    }
    #endregion
}
