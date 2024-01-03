using ApiCallRecap.DAL;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ApiCallRecap.UI.Pages
{
    public class IndexModel : PageModel
    {
        public List<UserModel> Users { get; set; } = new();

        public async Task OnGet()
        {
            RootModel? root = await new ApiCaller().MakeCall();

            if (root != null && root.Users != null)
            {
                Users = root.Users;
            }
        }
    }
}
