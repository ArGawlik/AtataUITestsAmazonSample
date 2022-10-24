using Atata;
using Atata.Bootstrap;
using AtataUITestsAmazon.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtataUITestsAmazon.Pages
{
    using _ = LocationWindow;
    public class LocationWindow : Page<_>
    {
        [FindById("GLUXCountryList")]
        public Select<CountrySelector?, _> SelectCountry { get; private set; }
        public Button<MainPage, _> Done { get; private set; }
    }
}
