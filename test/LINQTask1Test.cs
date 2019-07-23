using LINQBasics;
using System;
using System.Collections.Generic;
using Xunit;
namespace test
{
    public class LINQTask1Test: IClassFixture<TestFixture>
    {
        TestFixture _fixture;
        private readonly LINQTask1 LINQTask1PropertyObject;
        #region Constructor
        public LINQTask1Test(TestFixture fixture)
        {
            _fixture = fixture;
            LINQTask1PropertyObject = _fixture.LINQTask1Property;
        }
        #endregion
        [Fact]
        public void TestToGetSelectedNameOfEmployee()
        {
            //Arrange
            //Actual
            string actual = LINQTask1PropertyObject.SendSelectedNameofEmployee();
            string expected = "Vikram";
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestToGetSelectedCourses()
        {
            //Actual
            List<string> actual = LINQTask1PropertyObject.SendSelectedCourses();
            List<string> expected = new List<string> {"Full Stack .Net", "Full Stack Java", "Full Stack Mean" };
            //Assert
            Assert.Equal(expected, actual);
        }
    }
    #region TestFixtureClass
    public class TestFixture : IDisposable
    {
        public LINQTask1 LINQTask1Property { get; private set; }
        public TestFixture()
        {
            LINQTask1Property = new LINQTask1();
        }
        public void Dispose()
        {
            LINQTask1Property = null;
        }
    }
    #endregion
}
