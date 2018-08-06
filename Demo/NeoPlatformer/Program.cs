using System;

namespace NeoPlatformer
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new NeoPlatformerGame())
                game.Run();
        }
    }
}