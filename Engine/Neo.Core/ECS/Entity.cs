using Microsoft.Xna.Framework;
using Neo.ECS.Components;
using System.Collections.Generic;
using System.Linq;

namespace Neo.ECS
{
    public sealed class Entity : IEntity
    {
        public string Name { get; }

        public Scene Scene { get; set; }

        public Transform Transform => GetComponent<Transform>();

        public List<IComponent> Components { get; }

        internal Entity(Scene scene, string name)
        {
            Scene = scene;
            Name = name;
            Components = new List<IComponent>();
        }

        public void Update(GameTime gameTime)
        {
            Components.Where(x => x is IUpdatableComponent)
                .ToList()
                .ForEach(x => ((IUpdatableComponent)x).Update(gameTime));
        }

        public void Draw(GameTime gameTime)
        {
            Components.Where(x => x is IDrawableComponent)
                .ToList()
                .ForEach(x => ((IDrawableComponent)x).Draw(gameTime));
        }

        public T AddComponent<T>() where T : IComponent, new()
        {
            return AddComponent(new T());
        }

        public T AddComponent<T>(T component) where T : IComponent
        {
            component.Entity = this;
            component.Initialize();
            Components.Add(component);
            return component;
        }

        public T GetComponent<T>() where T : IComponent
        {
            return Components.OfType<T>().FirstOrDefault();
        }

        public void RemoveComponent<T>() where T : IComponent
        {
            var component = Components.OfType<T>().FirstOrDefault();
            if (component == default)
                return;

            Components.Remove(component);
        }

        public void RemoveComponent<T>(T component) where T : IComponent
        {
            if (!Components.Contains(component))
                return;

            Components.Remove(component);
        }
    }
}