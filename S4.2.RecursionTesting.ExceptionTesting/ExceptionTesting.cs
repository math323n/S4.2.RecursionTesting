using System;

namespace S4._2.RecursionTesting.ExceptionTesting
{
    public class ExceptionTesting
    {
        public static Exception GetInnerExceptions(Exception ex)
        {
            return (ex.InnerException == null) ? ex : GetInnerExceptions(ex.InnerException);

        }
    }
}