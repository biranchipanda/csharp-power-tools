namespace CSharpPowerTools.Client
{
    using System;
    using CSharpPowerTools.Extensions;

    public class Test
    {

        private static void Main()
        {
            MyApplication.OnUnhandledException(ex =>
            {
                Console.WriteLine(ex);
                Console.WriteLine("Exiting Application...");
            });

            new Test().DoSomething();
        }

        private void DoSomething()
        {
            int i = 0;
            int j = 1 / i;
        }
    }
}