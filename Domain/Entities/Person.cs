using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Primitivies;
using Domain.ValueObjects;

namespace Domain.Entities
{
    /// <summary>
    ///  Основная сущность персоны
    /// </summary>
    public class Person : BaseEntity
    {
        // TODO: Сделать валидацию для всех полей (DateTime до 150 лет, по гендеру (не null И не выбивается из допустимых), Telegram не больше 20 символов, телефон(+, 373, 77, 456789(дальше из них 5), 
        public Person(Guid id, DateTime createdDate, FullName fullName) : base(id, createdDate)
        {
            fullName = ValidateFullName(fullName);
            
            // TODO: * FluentValidator
        }
        public FullName fullName { get; private set; }
        public DateTime BirthDay { get; private set; }
        public int Age => DateTime.Now.Year - BirthDay.Year;
        public Gender Gender { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Telegram { get; private set; }

        private FullName ValidateFullName(FullName fullName)
        {
            // TODO: добавить валидацию, допускающую только русские и английские буквы
            if (string.IsNullOrEmpty(fullName.FirstName) ||
                string.IsNullOrEmpty(fullName.LastName))
            {
                throw new ValidationException(ValidationMessages.NullOrEmpty);
            }

            if (fullName.MiddleName != null)
            {
                if (fullName.MiddleName == String.Empty)
                {
                    throw new ValidationException(message: "Объект не может быть Empty");
                }
            }

            return fullName;
        }
    }
}
