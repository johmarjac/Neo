using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Neo;
using Neo.ECS;
using Neo.ECS.Components;
using NeoPlatformer.Components;

namespace NeoPlatformer.Scenes
{
    public class GameScene : Scene
    {
        IEntity PlayerEntity;

        public override void Initialize()
        {
            base.Initialize();

            Camera.SetZoom(0.5f);

            PlayerEntity = CreateEntity("player")
                .AddComponent<PlayerComponent>()
                .AddComponent<FollowCamera>();

            CreateEntity("giraffe")
                .AddComponent(new Sprite(NeoCore.NeoContent.Load<Texture2D>("assets/giraffe")));
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            if(Keyboard.GetState().IsKeyDown(Keys.D))
            {
                PlayerEntity.Transform.Position += new Vector2(1.0f, 0.0f) * gameTime.ElapsedGameTime.Milliseconds;
            }
            else if(Keyboard.GetState().IsKeyDown(Keys.A))
            {
                PlayerEntity.Transform.Position += new Vector2(-1.0f, 0.0f) * gameTime.ElapsedGameTime.Milliseconds;
            }
        }
    }
}