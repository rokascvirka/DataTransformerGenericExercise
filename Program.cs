using DataTransformerGenericExercise.Interfaces;
using DataTransformerGenericExercise.Models;
using System.Transactions;

namespace DataTransformerGenericExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee("1", "Rokas", "Trecias departamentas");
            var invoice = new Invoice(1, DateTime.Now, 4);


            var employeeTransformer = new DataTransformer<Employee, ITransformable<TransformedData>>();
            var transformedEmployee = employeeTransformer.Transform(employee);
            Console.WriteLine(transformedEmployee.Data);
        }
    }
}