using Microsoft.Xna.Framework;
using Neo.ECS.Components;
using System.Collections.Generic;

namespace Neo.ECS
{
    public interface IEntity
    {
        string Name { get; }

        Scene Scene { get; }

        Transform Transform { get; }

        List<IComponent> Components { get; }
        
        void Update(GameTime gameTime);
        void Draw(GameTime gameTime);

        IEntity AddComponent<T>() where T : IComponent, new();
        IEntity AddComponent<T>(T component) where T : IComponent;

        T GetComponent<T>() where T : IComponent;

        void RemoveComponent<T>() where T : IComponent;
        void RemoveComponent<T>(T component) where T : IComponent;
    }
}