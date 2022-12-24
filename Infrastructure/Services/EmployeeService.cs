using Domain.Models;

namespace Infrastructure.Services;

public class EmployeeService
{
    private List<Employee> _employees;
	public EmployeeService()
	{
	    _employees = new List<Employee>();
	}
   public List<Employee> GetEmployees()
	{
		return _employees;
	}
   public void Add(Employee employee)
	{
		_employees.Add(employee);
	}
   public void Update(Employee employee, int id)
	{
        var existing = _employees.Find(e => e.Id == employee.Id);
        if (existing == null) return;
		existing.Id = employee.Id;
        existing.FirstName = employee.FirstName;
		existing.LastName = employee.LastName;
		existing.BirthDate = employee.BirthDate;
        existing.Address = employee.Address;
		existing.Phone = employee.Phone;
		existing.Department = employee.Department;
		existing.Roles = employee.Roles;
		existing.Experiences = employee.Experiences;
		

    }
   public Employee GetEmployeetById(int id)
	{

	}
	public void Delete(int id)
	{
        var existing = _employees.Find(e => e.Id == id);
        if (existing== null) return;
        _employees.Remove(existing); 
    }
   public int Count()
	{
		return _employees.Count;
	}

}
