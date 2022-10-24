using Atata;
using AtataUITestsAmazon.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtataUITestsAmazon
{
    using _ = MainPage;

    public class MainPage : Page<_>
    {
        public Link<SearchingPage, _> Headsets { get; private set; }

        [FindById("twotabsearchtextbox")]
        public TextInput<_> SearchBar { get; private set; }

        [FindById("nav-search-submit-button")]
        public Button<SearchingPage, _> SearchButton { get; private set; }

        [FindById("nav-global-location-popover-link")]
        public Link<LocationWindow, _> LocationButton { get; private set; }

        [FindById("glow-ingress-line2")]

        public Text<_> DeliveryLocationName { get; private set; }
    }
}
