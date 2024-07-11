using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CourseNest.Controllers
{
    [Authorize]
    public class EnrollmentCartController : Controller
    {
        private readonly IEnrollmentCartRepository _cartRepo;

        public EnrollmentCartController(IEnrollmentCartRepository cartRepo)
        {
            _cartRepo = cartRepo;
        }
        public async Task<IActionResult> AddItem(int courseId, int qty = 1, int redirect = 0)
        {
            var cartCount = await _cartRepo.AddItem(courseId, qty);
            if (redirect == 0)
                return Ok(cartCount);
            return RedirectToAction("GetUserEnrollmentCart");
        }

        public async Task<IActionResult> RemoveItem(int courseId)
        {
            var cartCount = await _cartRepo.RemoveItem(courseId);
            return RedirectToAction("GetUserEnrollmentCart");
        }
        public async Task<IActionResult> GetUserEnrollmentCart()
        {
            var cart = await _cartRepo.GetUserEnrollmentCart();
            return View(cart);
        }

        public  async Task<IActionResult> GetTotalItemInEnrollmentCart()
        {
            int cartItem = await _cartRepo.GetEnrollmentCartItemCount();
            return Ok(cartItem);
        }

        public  IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Checkout(CheckoutModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            bool isCheckedOut = await _cartRepo.DoCheckout(model);
            if (!isCheckedOut)
                return RedirectToAction(nameof(EnrollmentFailure));
            return RedirectToAction(nameof(EnrollmentSuccess));
        }

        public IActionResult EnrollmentSuccess()
        {
            return View();
        }

        public IActionResult EnrollmentFailure()
        {
            return View();
        }

    }
}
