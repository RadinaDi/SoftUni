using OpenQA.Selenium;
using System;
using Xunit;

namespace test
{
    public class MassimoSiteShould : BaseTest
    {
        [Fact]
        public void VerifyThatASelectedProductsIsInTheShoppingBasket()
        {
            this.Driver.Navigate().GoToUrl("https://www.massimodutti.com/bg/");

            var menu = this.Wait.Until(d => d.FindElement(By.XPath("/html/body/home-manager/home-content/div/itx-header/div/div[2]/header/menu/nav/ul/li[1]/div[1]/a")));
            var coats = this.Wait.Until(d => d.FindElement(By.XPath("/html/body/home-manager/home-content/div/itx-header/div/div[2]/header/menu/nav/ul/li[1]/div[2]/div/div/ul[3]/li/ul/li[2]/a")));
            
            this.Builder
                .MoveToElement(menu)
                .Click(coats)
                .Perform();

            var termsAccept = this.Wait.Until(d => d.FindElement(By.XPath("/html/body/itx-catalog/section/itx-footer/footer/itx-banners/div/itx-cookies/div/div/button")));
            termsAccept.Click();

            var product = this.Wait.Until(d => d.FindElement(By.XPath("/html/body/itx-catalog/section/div/category-page/section[1]/div[1]/category-grid/div/div/div/div[1]/itx-product-view/div/div/div/a/img")));
            product.Click();

            var random = new Random();
            var buttonId = random.Next(1, 4);
            var selectRandomSize = this.Wait.Until(d => d.FindElement(By.XPath($"/html/body/itx-catalog/section/div/itx-product-page/div/itx-product/section/div[3]/div/div[4]/div/div/div[1]/itx-product-sizes/ul/li/button[{buttonId}]")));
            selectRandomSize.Click();

            var addToBasket = this.Wait.Until(d => d.FindElement(By.XPath("/html/body/itx-catalog/section/div/itx-product-page/div/itx-product/section/div[3]/div/div[5]/div/div/button")));
            addToBasket.Click();

            var continueShopping = this.Wait.Until(d => d.FindElement(By.XPath("/html/body/div[3]/div[2]/itx-related-product-dialog/div/div[2]/div/div[2]/div/button[2]")));
            continueShopping.Click();

            var code = this.Wait.Until(d => d.FindElement(By.XPath("/html/body/itx-shop-cart-page/div/section[1]/div/article/itx-shop-cart/div[2]/product-item-cart/div/div[2]/div[1]/div/p[2]/span")));
            Assert.Equal("6721/653/906", code.Text);
        }
    }
}
