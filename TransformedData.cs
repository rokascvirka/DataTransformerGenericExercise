﻿using DataTransformerGenericExercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataTransformerGenericExercise
{
    public class TransformedData
    {
        public string Data { get; set; }
        public TransformedData ToTransformedType()
        {
            return this;
        }
    }
}
