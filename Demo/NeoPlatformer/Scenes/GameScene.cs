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

            Camera.SetZoom(0.5f);

            CreateEntity("player")
                .AddComponent(new Sprite(NeoCore.NeoContent.Load<Texture2D>("assets/elephant")));
        }
    }
}