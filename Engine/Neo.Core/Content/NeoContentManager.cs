using System;
using Microsoft.Xna.Framework.Content;

namespace Neo.Content
{
    public class NeoContentManager : ContentManager
    {
        public NeoContentManager(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public NeoContentManager(IServiceProvider serviceProvider, string rootDirectory) : base(serviceProvider, rootDirectory)
        {
        }
    }
}