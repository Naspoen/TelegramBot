using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    /// <summary>
    ///  Основная сущность персоны
    /// </summary>
    public class Person : BaseEntity
    {
        // TODO: (До четверга) Максимально полно описать сущность персоны (др, возраст, пол, имя). Все поля добавляются через конструктор.
        public DateTime DateOfBirth { get; set; }
        public int Age => CalculateAge();
        /// <summary>
        /// Пол (true - мужской, false - женский)
        /// </summary>
        public bool Gender { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Telegram { get; set; }

        public Person(Guid id, DateTime createdDate, DateTime dateOfBirth, bool gender, string firstName, string secondName, string telegram) : base(id, createdDate)
        {
            DateOfBirth = dateOfBirth;
            Gender = gender;
            FirstName = firstName;
            SecondName = secondName;
            Telegram = telegram;
        }
        /// <summary>
        /// Метод для получения возраста
        /// </summary>
        private int CalculateAge()
        {
            DateTime now = DateTime.UtcNow;
            int age = now.Year - DateOfBirth.Year;
            if (now < DateOfBirth.AddYears(age)) 
                age--;
            return age;
        }
    }
}
