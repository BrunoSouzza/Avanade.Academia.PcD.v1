﻿namespace Avanade.Academia.PcD.Domain.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity(
            DateTime dataAtualizacao)
        {
            Id =  Guid.NewGuid();
            DataCriacao = DateTime.Now;//new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            DataAtualizacao = dataAtualizacao;
        }

        public Guid Id { get; set; }

        public /*DateOnly*/ DateTime DataCriacao { get; set; }

        public DateTime DataAtualizacao { get; set; }
    }
}
