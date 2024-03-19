using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    /// <summary>
    /// Базовый класс для всех сущностей
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Уникальный идентификатор сущностей
        /// </summary>
        protected Guid Id { get; set; }
        /// <summary>
        /// Дата создания сущности
        /// </summary>
        protected DateTime CreatedDate { get; set; }
        /// <summary>
        /// Конструктор класса BaseEntity
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="createdDate">Дата создания</param>
        protected BaseEntity(Guid id, DateTime createdDate)
        {
            Id = id;
            CreatedDate = createdDate;
        }
        /// <summary>
        /// Метод для сравнения двух сущностей по ID
        /// </summary>
        public override bool Equals(object? obj)
        {
            if (obj == null) 
                return false;
            if (obj is not BaseEntity entity)
                return false;
            if (Id != ((BaseEntity)obj).Id)
                return false;
            return true;
        }
        /// <summary>
        /// TODO: Домашнее задание (понять почему надо переписать). Сделать*
        /// </summary>
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
