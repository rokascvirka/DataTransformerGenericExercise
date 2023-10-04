using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransformerGenericExercise.Interfaces
{
    public interface ITransformable<T>
    {
        T ToTransformedType();
    }
}
