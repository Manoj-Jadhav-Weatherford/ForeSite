using System;

namespace WFT.ForeSite.Framework
{
    public static class ExceptionHandling
    {
        public static void Process<T>(Action<T> action, T parameter)
        {
            if (action == null) throw new ArgumentNullException("action");
            try
            {
                action(parameter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static T ProcessReturn<T>(Func<T, T> action, T parameter)
        {
            if (action == null) throw new ArgumentNullException("action");
            try
            {
                return action(parameter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
