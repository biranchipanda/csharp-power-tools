namespace CSharpPowerTools.Common.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ApplicationInfraTests
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void OnUnhandledException_WithOutGlobalHandlerTest()
        {
            int i = 0;
            int j = 1 / i;
        }

        // TODO: figure out a way to test this
        //[TestMethod]
        //public void OnUnhandledException_WithGlobalHandlerTest()
        //{
        //    // set up
        //    ApplicationInfra.OnUnhandledException(ex =>
        //    {
        //        Console.WriteLine(ex);
        //        Console.WriteLine("Exiting Application...");
        //    });

        //    int i = 0;
        //    int j = 1 / i;
        //}
    }
}