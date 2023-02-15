using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .Build();

host.Run();

//System.Threading.Thread.Sleep(4000);
while (true)
{
    Console.WriteLine("Geronimo");

}
