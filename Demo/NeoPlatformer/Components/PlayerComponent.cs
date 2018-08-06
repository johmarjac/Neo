using Microsoft.Xna.Framework.Graphics;
using Neo;
using Neo.ECS;
using Neo.ECS.Components;

namespace NeoPlatformer.Components
{
    public class PlayerComponent : Component
    {
        public override void Initialize()
        {
            base.Initialize();

            Entity
                .AddComponent(new Sprite(NeoCore.NeoContent.Load<Texture2D>("assets/elephant")));
        }
    }
}