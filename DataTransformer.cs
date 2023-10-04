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
    public class DataTransformer<TInput, TOutput>   where TInput: ITransformable<TransformedData>
                                                    where TOutput : ITransformable<TransformedData>
    {
        public TransformedData Transform(TInput inputData)
        {
            return inputData.ToTransformedType();
        }
    }
}
