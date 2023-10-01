using DataTransformerGenericExercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransformerGenericExercise.Models
{
    public class Employee : ITransformable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Departament { get; set; }

        public Employee(int id, string name, string department)
        {
            Id = id;
            Name = name;
            Departament = department;
        }

        public object TransformToObject()
        {
            return new
            {
                objName = Name,
                objDepartament = Departament
            };
        }
    }
}
