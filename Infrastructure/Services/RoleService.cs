using Domain.Models;

namespace Infrastructure.Services;

public class RoleService
{
    private List<Role> _roles;
	public RoleService()
	{
		_roles = new List<Role>();
    }

    public List<Role> GetRoles()
    {
        return _roles;
    }
    public void Add(Role employee)
    {
        _roles.Add(employee);
    }
    public void Update(Role role, int id)
    {
        var existing = _roles.Find(e => e.Id == role.Id);
        if (existing == null) return;
        existing.Id = role.Id;
        existing.Name = role.Name;
        existing.Description = role.Description;
        existing.EmployeeId = role.EmployeeId;
    }
    public Role GetRoleById(int id)
    {

    }
    public List<Role> GetRolesByUserId(int id)
    {

    }
    public void Delete(int id)
    {
        var existing = _roles.Find(e => e.Id == id);
        if (existing == null) return;
        _roles.Remove(existing);
    }
    public int Count()
    {
        return _roles.Count;
    }
}
