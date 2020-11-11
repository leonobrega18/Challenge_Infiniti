using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infiniti
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.scf2.sebrae.com.br/portalcf/");
            IWebElement btnSearch = WebDriverExtensions.FindElement(driver, By.Name("ctl00$ContentPlaceHolder1$btnPesquisar"), 10);
            btnSearch.Click();

            IWebElement ResultOne = WebDriverExtensions.FindElement(driver, By.ClassName("form-searchresult"), 100);
            ResultOne.ToString();

            IList<IWebElement> allResult = driver.FindElements(By.ClassName("form-searchresult"));
            String[] allText = new String[allResult.Count];
            int i = 0;
            foreach (IWebElement element in allResult)
            {
                allText[i++] = element.Text; 
            }

            //a partir deste ponto, pode realizar um split na variavel, colocar em uma classe e assim extrair para o front-end ou para um arquivo

        }
    }

    public static class WebDriverExtensions
    {
        public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(by));
            }
            return driver.FindElement(by);
        }
    }

}
