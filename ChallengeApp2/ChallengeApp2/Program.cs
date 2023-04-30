using ChallengeApp2;

Employee employee1 = new Employee("Adam", "Kowalski", "21");
Employee employee2 = new Employee("Monika", "Nowak", "30");
Employee employee3 = new Employee("Dawid", "Kukiz", "25");

employee1.AddScore(5);
employee1.AddScore(2);
employee1.AddScore(10);
employee1.AddScore(1);
employee1.AddScore(3);

employee2.AddScore(3);
employee2.AddScore(7);
employee2.AddScore(6);
employee2.AddScore(1);
employee2.AddScore(10);

employee3.AddScore(2);
employee3.AddScore(10);
employee3.AddScore(9);
employee3.AddScore(7);
employee3.AddScore(2);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach ( var employee in employees )
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine("Najlepszym pracownikiem jest: " + employeeWithMaxResult.FirstName + " " + employeeWithMaxResult.SecondName + " " + "lat" + " " + employeeWithMaxResult.Age);
Console.WriteLine("z wynikiem " +  maxResult);