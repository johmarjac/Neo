using Neo;
using NeoPlatformer.Scenes;

namespace NeoPlatformer
{
    public class NeoPlatformerGame : NeoCore
    {
        protected override void Initialize()
        {
            base.Initialize();

            Scene = new GameScene();
        }
    }
}