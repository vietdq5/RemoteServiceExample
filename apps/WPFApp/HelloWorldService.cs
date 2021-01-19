using Volo.Abp.DependencyInjection;

 namespace WPFApp
{
    public class HelloWorldService : ITransientDependency
    {
        public string SayHello()
        {
            return "Hello world!";
        }
    }
}
