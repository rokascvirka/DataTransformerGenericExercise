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
    public class DataTransformer<TInput, TOutput>   where TInput: ITransformable
                                                    where TOutput : ITransformable
    {
        public TOutput Transform(TInput inputData)
        {
            return (TOutput)inputData.ToTransformedType();
        }
    }
}
