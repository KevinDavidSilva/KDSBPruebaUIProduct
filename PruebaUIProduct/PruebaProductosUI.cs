using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaUIProduct
{
    [TestClass]
    public class PruebaProductosUI : IDisposable
    {
        private IWebDriver driver;

        public PruebaProductosUI()
        {
            driver = new ChromeDriver();
        }

        [TestMethod]
        public void Blazor()
        {
            driver.Navigate().GoToUrl("https://localhost:7159/product-list");

            System.Threading.Thread.Sleep(1000);

            var btn = driver.FindElement(By.Name("crear"));

            btn.Click();

            System.Threading.Thread.Sleep(1000);

            var nombre = driver.FindElement(By.Id("Nombre"));

            nombre.SendKeys("PruebaN");

            var descripcion = driver.FindElement(By.Id("Descripcion"));

            descripcion.SendKeys("PruebaD");

            var precio = driver.FindElement(By.Id("Precio"));

            precio.SendKeys("100");

            var guardar = driver.FindElement(By.Name("guardar"));

            guardar.Click();

            System.Threading.Thread.Sleep(1000);

            var regresar = driver.FindElement(By.Name("regresar"));

            regresar.Click();

            System.Threading.Thread.Sleep(1000);

            
        }
        public void Dispose()
        {

            driver.Quit();
        }
    }
}
