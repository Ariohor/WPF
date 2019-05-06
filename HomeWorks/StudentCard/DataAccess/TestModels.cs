using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class TestModels
    {
        public static Student GetStudent()
        {
            return new Student
            {
                Name = "Иванов Иван Иванович",
                Birthday = DateTime.MinValue,
                Address = "улица Бассейная",
                Course = 2,
                GroupName = "OT-19",
                PhoneNumber = "9 (999) 999 99 99",
                StudyForm = "Очная"
            };
        }
    }
}
