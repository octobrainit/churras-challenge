using System;

namespace Churras.Project.Shared.Domain.Classes
{
    public class Entity
    {
        Guid CorrelationId;

        public Entity()
        {
            if (Guid.Empty == Id)
                Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public Guid GetCorrelationId() => Guid.Empty == CorrelationId ? Guid.NewGuid() : CorrelationId;
    }
}
