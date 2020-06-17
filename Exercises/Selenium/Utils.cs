using System.Threading;

namespace Selenium
{
    public static class Utils
    {
        public static void Delay(int delay = 1000)
        {
            Thread.Sleep(delay);
        }
    }
}
