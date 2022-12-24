using Domain.Models;
using System.Data;

namespace Infrastructure.Services;

public class DepartmentService
{
    private List<Department> _departments;
    public DepartmentService()
    {
        _departments = new List<Department>();
    }
public  List<Department> GetDepartments()
    {
      return _departments;
    }
public void Add(Department department)
    {
        _departments.Add(department);
    }
 public void Update(Department department, int id)
    {
        var existing = _departments.Find(e => e.Id == department.Id);
        if (existing == null) return;
        existing.Id = department.Id;
        existing.Name = department.Name;
        existing.Description = department.Description;
    }
 public Department GetDepartmentById(int id)
    {
        
    }
 public void Delete(int id)
    {
        var existing = _departments.Find(e => e.Id == id);
        if (existing == null) return;
        _departments.Remove(existing);
    }
 public int Count()
    {
        return _departments.Count;
    }
}
