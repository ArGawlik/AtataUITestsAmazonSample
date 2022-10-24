using Atata;
using NUnit.Framework;

namespace AtataUITestsAmazon
{
    [SetUpFixture]
    public class SetUpFixture
    {
        [OneTimeSetUp]
        public void GlobalSetUp()
        {
            // Find information about AtataContext set-up on https://atata.io/getting-started/#set-up
            AtataContext.GlobalConfiguration
                .UseChrome()
                    .WithArguments("start-maximized")
                .UseBaseUrl("https://amazon.com/")
                .UseCulture("en-US")
                .UseAllNUnitFeatures()
                .ScreenshotConsumers.AddFile();

            AtataContext.GlobalConfiguration.AutoSetUpDriverToUse();
        }
    }
}
