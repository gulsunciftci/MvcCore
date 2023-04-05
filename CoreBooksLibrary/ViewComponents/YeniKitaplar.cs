using CoreBooksLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreBooksLibrary.ViewComponents
{
    public class YeniKitaplar: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var kitaplistesi = new List<Kitaplar>
            {
                new Kitaplar
                {
                    ID=4,
                    KitapAd="Korku",
                    Yazar="Zweigh"
                },
                new Kitaplar
                {
                    ID=5,
                    KitapAd="Anna Karanina",
                    Yazar="Tolstoy"
                }

            };
            return View(kitaplistesi);
        }
    }
}
