using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Identity;

namespace WindowsFormsApp1
{
    public class HelloWorldService : ITransientDependency
    {
        private readonly IProfileAppService _profileAppService;

        public HelloWorldService(IProfileAppService profileAppService)
        {
            _profileAppService = profileAppService;
        }

        public string SayHello()
        {
            return "Hello world!";
        }

        public async Task<Demads> GetDemadsfas()
        {
            var output = await _profileAppService.GetAsync();
            var dasd = new Demads()
            {
                name1 = output.UserName,
                name2 = output.Email,
                name3 = output.Name
            };
            return dasd;
        }
    }

    public class Demads
    {
        public string name1 { get; set; }
        public string name2 { get; set; }
        public string name3 { get; set; }
    }
}