using System;

namespace CleanArchitecture.Core.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime DataApauracao { get; set; } = DateTime.Now;
    }
}
