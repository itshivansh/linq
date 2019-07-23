using LINQBasics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace test
{
    public class LINQTask3Test: IClassFixture<TestFixture3>
    {
        TestFixture3 _fixture3;
        private readonly LINQTask3 LINQTask3PropertyObject;
        #region Constructor
        public LINQTask3Test(TestFixture3 fixture3)
        {
            _fixture3 = fixture3;
            LINQTask3PropertyObject = _fixture3.LINQTask3Property;
        }
        #endregion
        [Fact]
        public void TestToGetEvenNumberOfValues()
        {
            
            //Actual
            ArrayList actual = LINQTask3PropertyObject.FunToReturnEvenNumberofItems();
            //Getting even Numbers using LINQ
            ArrayList expected = new ArrayList() { 46, 56 };
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestToGetOddNumberOfValues()
        {

            //Actual
            ArrayList actual = LINQTask3PropertyObject.FunToReturnOddNumberofItems();
            //Getting odd Numbers of Values using LINQ
            ArrayList expected = new ArrayList() { 11,21,33,89,09,67};
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestToGetValueFromDelegate()
        {
            int valuefromTestcase = 2;
            //Actual
            int actual = LINQTask3PropertyObject.FuntoUseDelegatewithLambda(valuefromTestcase);
       
            int expected = 4;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestToGetValueFromDelegatewithMorethnOneParameters()
        {
            int firstvalue = 10;
            int secondvalue = 15;
            //Actual
            int actual = LINQTask3PropertyObject.FuntoUseDelegatewithLambdawithTwoParameters(firstvalue, secondvalue);

            int expected = 25;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void FuntoUseFuncDelegate()
        {
            int fisrstvaluetofuncdelegate = 10;
            //Actual
            int actual = LINQTask3PropertyObject.FuntoUseFuncDelegate(fisrstvaluetofuncdelegate);

            int expected = 11;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestToCheckfuncDelegatewithClassProperties()
        { 
            //Actual
            int actual = LINQTask3PropertyObject.FuntoCheckfuncDelegatewithClassProperties();

            int expected = 10;
            //Assert
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void TestToGetMaxValueofEmployeeId()
        {
            //Actual
            int actual = LINQTask3PropertyObject.FunToGetMaxValueofEmployeeId();

            int expected = 4;
            //Assert
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void TestToGetMinValueofEmployeeId()
        {
            //Actual
            int actual = LINQTask3PropertyObject.FunToGetMinValueofEmployeeId();

            int expected = 1;
            //Assert
            Assert.Equal(expected, actual);

        }
    }
    #region TestFixtureClass
    public class TestFixture3 : IDisposable
    {
        public LINQTask3 LINQTask3Property { get; private set; }
        public TestFixture3()
        {
            LINQTask3Property = new LINQTask3();
        }
        public void Dispose()
        {
            LINQTask3Property = null;
        }
    }
    #endregion
}
