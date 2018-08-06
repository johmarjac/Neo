using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Neo.Content;
using Neo.ECS;

namespace Neo
{
    public abstract class NeoCore : Game
    {
        public static GraphicsDeviceManager DeviceMgr;

        public static GraphicsDevice Device => DeviceMgr.GraphicsDevice;

        public static SpriteBatch Batch;

        public static Color ClearColor = Color.CornflowerBlue;

        public static NeoContentManager NeoContent;

        public static Scene Scene { get; set; }

        public static bool ExitOnEscape { get; set; } = true;
        
        public NeoCore()
        {
            DeviceMgr = new GraphicsDeviceManager(this);
            NeoContent = new NeoContentManager(Content.ServiceProvider, "Content");
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
            Batch = new SpriteBatch(DeviceMgr.GraphicsDevice);
        }

        protected override void Update(GameTime gameTime)
        {
            if (ExitOnEscape && Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            Scene?.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            DeviceMgr.GraphicsDevice.Clear(ClearColor);

            Scene?.Draw(gameTime);
        }
    }
}