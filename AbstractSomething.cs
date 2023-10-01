using DataTransformerGenericExercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransformerGenericExercise
{
    public class AbstractSomething : ITransformable
    {
        public string FirstValue { get; set; }
        public string SecondValue { get; set; }
        public AbstractSomething()
        {
            
        }

        public object TransformToObject()
        {
            throw new NotImplementedException();
        }
    }
}
