using learn_csharp.Browsers;
using learn_csharp.WebDriver;
using static learn_csharp.Basics.CsEnums;
using learn_csharp.ExtentsionMethods;
using learn_csharp.Linq;
using learn_csharp.Delegate;

namespace learn_csharp.Basics
{
	public class Runner
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

            /*
            //Delegate Example
            Calculate ops = DelegateExamples.Add;
            ops(20, 10);
            ops = DelegateExamples.Mul;
            ops(20, 10);
            ops = DelegateExamples.Sub;
            ops(20, 10);
            ops = DelegateExamples.Div;
            ops(20, 10);

            //Delegate using Lambda
            ConcatString cs = (str1, str2) => { Console.WriteLine("Concatinated String is " + str1 + str2); };
            cs("Hello", "C#");
            */

            /*

            //Call by Reference
            int a = 100;
            Console.WriteLine("Before making any calls " + a);
            methodVal(a);
            Console.WriteLine("After making a call to Method Val " + a);
            methodRef(ref a);
            Console.WriteLine("After making a call to Method " + a);

            */

            //Params example
            //Params.ParamExample(10, "Suro", true, 'M');


            /*
            //Understand Struct and Class difference
            //Class is call by reference
            //Struct is call by value
            StructExample c1 = new StructExample();
            c1.myData = 100;
            StructExample c2 = c1;
            Console.WriteLine(c1.myData);
            Console.WriteLine(c2.myData);
            c1.myData = 200;
            Console.WriteLine(c1.myData);
            Console.WriteLine(c2.myData);

            MyStruct s1 = new MyStruct();
            s1.Val = 300;
            MyStruct s2 = s1;
            Console.WriteLine(s1.Val);
            Console.WriteLine(s2.Val);
            s1.Val = 400;
            Console.WriteLine(s1.Val);
            Console.WriteLine(s2.Val);
            */

        }

        public static void methodRef(ref int x)
        {
            x = 400;
            Console.WriteLine("In Ref Method , Value is changed to " + x);
        }
        public static void methodVal(int x)
        {
            x = 300;
            Console.WriteLine("In Val Method , Value is changed to " + x);
        }

    }
}

