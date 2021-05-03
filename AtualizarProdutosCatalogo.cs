using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;
using TestProject1.Fixtures;
using TestProject1.Helpers;
using Xunit;

namespace TestProject1
{
    public class AtualizarProdutosCatalogo : IClassFixture<TestFixture>
    {
        private IWebDriver driver;

        public AtualizarProdutosCatalogo(TestFixture fixture)
        {
            driver = fixture.Driver;
        }

        
   

        [Fact]
        public void AtualizarProdutoCatalogoPorId()
        {

            driver.Navigate().GoToUrl("site");

            Assert.Contains("Login",driver.Title);

            //login
            var inputLogin = driver.FindElement(By.Id("login"));

            //senha
            var inputPassword = driver.FindElement(By.Id("password"));

            //insere informações do login
            inputLogin.SendKeys("login");
            inputPassword.SendKeys("Senha");

            //clica no botão de login
            driver.FindElement(By.Id("submit")).Click();

            var inputUser = driver.FindElement(By.CssSelector(".doEnterToSearch"));

            inputUser.SendKeys("qlc");

            driver.FindElement(By.CssSelector(".btn-info")).Click();

            var valores = LerCsv.Page_Load();

           //var valor = valores[1];

            foreach (var id in valores)
            {

                driver.Navigate().GoToUrl("site" + id);

                driver.FindElement(By.Id("submit")).Click();
            }
        }

        public void AtualizarProdutoCatalogoPorSku()
        {

            driver.Navigate().GoToUrl("site");

            Assert.Contains("Login", driver.Title);

            //login
            var inputLogin = driver.FindElement(By.Id("login"));

            //senha
            var inputPassword = driver.FindElement(By.Id("password"));

            //insere informações do login
            inputLogin.SendKeys("login");
            inputPassword.SendKeys("Senha");

            //clica no botão de login
            driver.FindElement(By.Id("submit")).Click();

            var inputUser = driver.FindElement(By.CssSelector(".doEnterToSearch"));

            inputUser.SendKeys("qlc");

            driver.FindElement(By.CssSelector(".btn-info")).Click();

            var valores = LerCsv.Page_Load();

            //var valor = valores[1];

            
            
        }

    }     
}


