using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<IOrderItem> items { get; protected set; };

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IEnumerable<IOrderItem> Entrees
        {
            get
            {
                return Menu.Entrees();
            }
        }

        public IEnumerable<IOrderItem> Sides
        {
            get
            {
                return Menu.Sides();
            }
        }

        public IEnumerable<IOrderItem> Drinks
        {
            get
            {
                return Menu.Drinks();
            }
        }

        public void OnGet(string Terms, string[] types, double priceMin, double priceMax, uint calorieMin, uint calorieMax)
        {
            items = Menu.FullMenu();

            if(Terms != null)
            {
                items = items.Where(item => item.ToString() != null && item.ToString().Contains(Terms));
            }
        }
    }
}
