using DataTransformerGenericExercise.Interfaces;
using DataTransformerGenericExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DataTransformerGenericExercise
{
    public static class DataTransformer<TInput, TOutput>   where TInput: ITransformable
                                                    where TOutput : ITransformable<TOutput>
    {
        public static TOutput ToTransformedType(TInput input)
        {
            return input.TransformToObject();
            
        }
    }
}
