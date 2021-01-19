using System.Threading.Tasks;

namespace RemoteServiceExample.Web.Pages.Entities.Book
{
    public class IndexModel : RemoteServiceExamplePageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
