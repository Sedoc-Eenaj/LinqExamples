namespace LinqExamples
{
    public class EmployeeInfo
    {
        // This method should take the IEnumerable of employees,
        // returning the employees with a salary > 100K.
        public static IEnumerable<Employee> EmployeesWithSalaryGreaterThan100K(IEnumerable<Employee> employees)
        {
            IEnumerable<Employee> result =
                from employee in employees
                where employee.Salary > 100000
                select employee;
            
            return result;
            
        }

        public static double AverageConsultantSalaryInBrisbane(IEnumerable<Employee> employees)
        {
            IEnumerable<Employee> brisSalary =
                from employee in employees
                where employee.City == "Brisbane"
                select employee;

            return EmployeeInfoHelper.AverageSalary(brisSalary);

            
        }
    }
}