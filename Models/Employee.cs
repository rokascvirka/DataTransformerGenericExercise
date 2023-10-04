using DataTransformerGenericExercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransformerGenericExercise.Models
{
    public class Employee : ITransformable<TransformedData>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Departament { get; set; }

        public Employee(string id, string name, string departament)
        {
            Id = id;
            Name = name;
            Departament = departament;
        }

        public TransformedData ToTransformedType()
        {
            return new TransformedData { Data = $"{Id} - {Name}" };
        }
    }
}
