using Microsoft.Xna.Framework.Graphics;
using Neo;
using Neo.ECS;
using Neo.ECS.Components;

namespace NeoPlatformer.Scenes
{
    public class GameScene : Scene
    {
        public override void Initialize()
        {
            base.Initialize();

            CreateEntity("player")
                .AddComponent(new Sprite(NeoCore.NeoContent.Load<Texture2D>("assets/elephant")));
        }
    }
}