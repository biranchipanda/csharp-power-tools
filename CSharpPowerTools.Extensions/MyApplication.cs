namespace CSharpPowerTools.Extensions
{
    using System;

    public static class MyApplication
    {
        public static readonly AppDomain CurrentAppDomain = AppDomain.CurrentDomain;




        public static void OnUnhandledException(Action<Exception> onException, Action afterException = null)
        {
            CurrentAppDomain.UnhandledException += (s, e) =>
            {
                var ex = (Exception)e.ExceptionObject;
                onException(ex);

                if (afterException != null)
                {
                    afterException();
                }
                else
                {
                    System.Environment.Exit(0);
                }
            };
        }
    }
}