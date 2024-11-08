using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac9
{
    /// <summary>
    /// Структура для хранения информации о студенте
    /// </summary>
    internal struct Student
    {
        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Нуждается в общежитии
        /// </summary>
        public bool NeedsDormitory { get; set; }
        /// <summary>
        /// Стаж
        /// </summary>
        public int ExperienceYears { get; set; }
        /// <summary>
        /// Работал ли
        /// </summary>
        public bool HasWorked { get; set; }
        /// <summary>
        /// Образование
        /// </summary>
        public string Education { get; set; }
        /// <summary>
        /// Изучаемый язык
        /// </summary>
        public string LanguageLearned { get; set; }

        /// <summary>
        /// Конструктор для инициализации информации о студенте
        /// </summary>
        public Student(string lastName, bool needsDormitory, int experienceYears, bool hasWorked, string education, string languageLearned)
        {
            LastName = lastName;
            NeedsDormitory = needsDormitory;
            ExperienceYears = experienceYears;
            HasWorked = hasWorked;
            Education = education;
            LanguageLearned = languageLearned;
        }

        /// <summary>
        /// Вывод информации о студенте
        /// </summary>
        public string GetInfo()
        {
            return $"Фамилия: {LastName}, Нуждается в общежитии: {NeedsDormitory}, Стаж: {ExperienceYears} лет, Работал: {HasWorked}, Образование: {Education}, Язык: {LanguageLearned}";
        }
    }
}
