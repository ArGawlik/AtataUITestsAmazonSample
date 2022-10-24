using Atata;
using AtataUITestsAmazon.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtataUITestsAmazon
{
    using _ = SearchingPage;
    public class SearchingPage : Page<_>
    {
        
        public ControlList<Product, _> Products { get; private set; }

        [ControlDefinition("div", ContainingClasses = new string[] { "s-result-item", "s-asin" })]
        public class Product : Control<_>
        { 
            public H2<_> ProductName{ get; private set; }
            [FindByClass("s-link-style")]
            public Link<ProductPage, _> ProductLink { get; private set; }

            [FindByClass("a-offscreen")]
            public Text<_> Price { get; private set; }
        }
    }
}
