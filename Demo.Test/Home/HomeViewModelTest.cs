using NUnit.Framework;

namespace Demo.Test.Home
{
    public class HomeViewModelTest
    {
        [TestMethod]  
        public void TestMethod1()  
        {  
            //Arrange  
            Method m1 = new Method();  
            int expectedResult = 16;  
  
  
            //Act  
            int actualResult = m1.Addition(11, 5);  
  
  
            //Assert  
            Assert.AreEqual(expectedResult, actualResult);  
              
        }  
    }
}