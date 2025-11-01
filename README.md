# ColorMagic.cs
Web-API for [colormagic.app](https://colormagic.app/) a free and simple API you can use to integrate with their color palettes.

## Example
```cs
using ColorMagicApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new ColorMagic();
            string color = await api.SearchColor("red");
            Console.WriteLine(color);
        }
    }
}
