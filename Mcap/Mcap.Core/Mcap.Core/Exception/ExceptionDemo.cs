namespace Mcap.Core.Exception
{
    public class ExceptionDemo : System.Exception
    {
        public ExceptionDemo()
        {
        }
        public ExceptionDemo(string message)
            : base(message)
        {
        }
    }
}
