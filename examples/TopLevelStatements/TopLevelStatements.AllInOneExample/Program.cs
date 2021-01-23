using System.Threading.Tasks;
using static System.Console;

WriteLine("Hello World!");

if (args.Length > 0)
{
    WriteLine("Args are provided.");
}
else
{
    WriteLine("Args are not provided.");
}

await Task.Delay(100);

UseSomeUsefulData(new SomeUsefulData());

var someObject = new SomeNamespace.SomeClass();

return 0;

void UseSomeUsefulData(SomeUsefulData someUsefulData)
{
}

record SomeUsefulData();

namespace SomeNamespace
{
    class SomeClass { }
}
