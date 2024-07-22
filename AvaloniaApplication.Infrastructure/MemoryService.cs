using AvaloinaApplication.Domain;
using System.ComponentModel;

namespace AvaloniaApplication.Domain
{
    public class MemoryService : IService
    {
        private Entity entity = new Entity();
        public Entity Entity { get => entity; }
        public void UpdateEntity(Entity entity)
        {
            this.entity = entity;
            OnEntityUpdated();
        }
        public void OnEntityUpdated()
        {
            EntityUpdated += OnEntityUpdated;
            //EntityUpdated(this, entity);
        }

        public EventHandler<Entity>? EntityUpdated;

        private void OnEntityUpdated(object sender, Entity entity)
        {
            this.entity.value = entity.value;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
