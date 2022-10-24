using Atata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtataUITestsAmazon.Pages
{
    using _ = ProductPage;
    public class ProductPage : Page<_>
    {
        [FindByCss("div#corePrice_feature_div .a-offscreen")]
        public Text<_> Price { get; private set; }

        public H1<_> ProductName { get; private set; }
    }
}
