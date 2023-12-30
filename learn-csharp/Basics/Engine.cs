using learn_csharp.Browsers;
using learn_csharp.WebDriver;
using static learn_csharp.Basics.CsEnums;
using learn_csharp.ExtentsionMethods;
using learn_csharp.Linq;
using learn_csharp.Delegate;

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
            /*IWebDriver driver = new Chrome();
            driver.FindElement();
            driver.Click();
            driver.SendKeys("Hello Google");
            driver.TypeText("Hello Linkedin.");


            driver = new Firefox();
            driver.FindElement();
            driver.Click();
            driver.SendKeys("Hello Facebook");
            driver.TypeText("Hello Linkedin.");*/

            //LinqBasics.LinqBasicOps();


            //Delegate Example
            Calculate ops = DelegateExamples.Add;
            ops(20, 10);
            ops = DelegateExamples.Mul;
            ops(20, 10);
            ops = DelegateExamples.Sub;
            ops(20, 10);
            ops = DelegateExamples.Div;
            ops(20, 10);
        }

    }
}

