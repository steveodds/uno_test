using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace uno_test.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new uno_test.App(), args);
            host.Run();
        }
    }
}
