using Volo.Abp.DependencyInjection;

 namespace Chet.Template.GUI
{
    public class HelloWorldService : ITransientDependency
    {
        public string SayHello()
        {
            return "Hello world!";
        }
    }
}
