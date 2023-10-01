using DataTransformerGenericExercise.Models;

namespace DataTransformerGenericExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee(1, "Rokas", "Trecias departamentas");
            var invoice = new Invoice(1, DateTime.Now, 4);


            var newObj = DataTransformer<Employee, AbstractSomething>.ToTransformedType(employee);

            Console.WriteLine($"{newObj.});
        }
    }
}