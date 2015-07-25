namespace CSharpPowerTools.DesignPatterns.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SingletonTests
    {
        [TestMethod]
        public void Singleton_AreSameInstance_Test()
        {
            var instance1 = TestClass.GetInstance();
            var instance2 = TestClass.GetInstance();

            Assert.AreSame(instance1, instance2);

            // Figure out a way to stop all constructors in the derived class
            var instance3 = new TestClass();
            Assert.AreNotSame(instance1, instance3);
        }

        [TestMethod]
        public void Singleton_StopConstructor_Test()
        {
            var instance1 = TestClass.GetInstance();

            // Figure out a way to stop all constructors in the derived class
            var instance3 = new TestClass();

            Assert.AreNotSame(instance1, instance3);
        }
    }

    internal class TestClass : Singleton<TestClass>
    {
    }
}