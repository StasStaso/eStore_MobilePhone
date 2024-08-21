using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Shopping.Web.Pages;

public class CartModel(IBasketService basketService,
    ILogger<CartModel> logger) 
    : PageModel
{
    public ShoppingCartModel Cart { get; set; } = new ShoppingCartModel();

    public async Task<IActionResult> OnGetAsync()
    {
        Cart = await basketService.LoadUserBasket();

        return Page();
    }

    public async Task<IActionResult> OnPostRemoveToCartAsync(Guid productId) 
    {
        return Page();
    }
}
