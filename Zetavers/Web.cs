using System;
using System.Net;

namespace Zetavers
{
    public static class Web
    {
        public static bool Online;
        public static void ConnentServer()
        {
            try
            {
                using (var Client = new WebClient())
                using (Client.OpenRead("https://ax.reiz-0.repl.co/"))
                {
                    Online = true;
                }
            }
            catch
            {
                Online = false;
            }
        }
    }
}
