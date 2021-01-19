using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RemoteServiceExample.Entities;
using RemoteServiceExample.Entities.Dtos;

namespace RemoteServiceExample.Web.Pages.Entities.Book
{
    public class CreateModalModel : RemoteServiceExamplePageModel
    {
        [BindProperty]
        public CreateUpdateBookDto ViewModel { get; set; }

        private readonly IBookAppService _service;

        public CreateModalModel(IBookAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            await _service.CreateAsync(ViewModel);
            return NoContent();
        }
    }
}