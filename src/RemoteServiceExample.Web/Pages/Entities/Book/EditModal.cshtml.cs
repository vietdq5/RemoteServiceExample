using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RemoteServiceExample.Entities;
using RemoteServiceExample.Entities.Dtos;

namespace RemoteServiceExample.Web.Pages.Entities.Book
{
    public class EditModalModel : RemoteServiceExamplePageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateUpdateBookDto ViewModel { get; set; }

        private readonly IBookAppService _service;

        public EditModalModel(IBookAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<BookDto, CreateUpdateBookDto>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            await _service.UpdateAsync(Id, ViewModel);
            return NoContent();
        }
    }
}