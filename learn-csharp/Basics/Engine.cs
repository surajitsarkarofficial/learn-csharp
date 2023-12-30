using learn_csharp.Browsers;
using learn_csharp.WebDriver;
using static learn_csharp.Basics.CsEnums;

namespace learn_csharp.Basics
{
	public class Engine
	{
        public static void Main(string[] args)
        {
            //CsArrays.ArrayBasics();
            //CsHashtable.HashtableBasics();
            //CsDictionary.DictionaryBasics();
            //ListCustomType.UserData();
            //CsEnums.launchBrowser(Browser.FIREFOX);
            IWebDriver driver = new Chrome();
            driver.FindElement();
            driver.Click();
            driver.SendKeys();


            driver = new Firefox();
            driver.FindElement();
            driver.Click();
            driver.SendKeys();
        }

    }
}

