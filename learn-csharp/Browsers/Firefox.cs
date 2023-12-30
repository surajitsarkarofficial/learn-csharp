using System;
using learn_csharp.WebDriver;

namespace learn_csharp.Browsers
{
    public class Firefox : IWebDriver
    {
        public void Click()
        {
            Console.WriteLine("Firefox Click...");
        }

        public void FindElement()
        {
            Console.WriteLine("Firefox FindElements...");
        }

        public void SendKeys()
        {
            Console.WriteLine("Firefox  SendKeys...");
        }
    }
}

