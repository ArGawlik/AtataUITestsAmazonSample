using Atata;
using AtataUITestsAmazon.Enums;
using AtataUITestsAmazon.Pages;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace AtataUITestsAmazon
{
    public class SampleTests : UITestFixture
    {
        MainPage mainPage;
        SearchingPage searchingPage;
        ProductPage productPage;

        [SetUp]
        public void GoToMainPage()
        {
            mainPage = Go.To<MainPage>()
                .PageTitle.Should.Contain("Amazon");
        }

        [Test]
        public void SampleTest()
        {
            searchingPage = mainPage.Headsets.ClickAndGo()
                .PageTitle.Should.Contain("gaming headsets");
            string ExpectedProductName = searchingPage.Products[3].ProductName.Get();
            string ExpectedPrice = searchingPage.Products[3].Price.Get();
            productPage = searchingPage.Products[3].ProductLink.ClickAndGo();

            System.Console.WriteLine(ExpectedPrice);

            productPage.ProductName.Should.Equal(ExpectedProductName);
            productPage.Price.Should.Equal(ExpectedPrice);
        }

        [Test]
        public void SearchingTest()
        {
            searchingPage = mainPage.SearchBar.Set("laptop asus").SearchButton.ClickAndGo();

            List<string> names = searchingPage.Products.SelectData(x => x.ProductName.Get()).ToList();
            names.ForEach(x => StringAssert.Contains("laptop", x.ToLower()));
        }

        [Test]
        public void ChangeDeliveryLocation()
        {
            CountrySelector country = CountrySelector.Canada;
            LocationWindow location = mainPage.LocationButton.ClickAndGo();
            location.SelectCountry.Set(country).Done.ClickAndGo();

            mainPage.DeliveryLocationName.Should.Equal("Canada");
        }
    }
}
