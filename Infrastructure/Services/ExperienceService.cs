using Domain.Models;

namespace Infrastructure.Services;

public class ExperienceService
{
    private List<Experience> _experiences;
	public ExperienceService()
	{
		_experiences = new List<Experience>();
	}
    public List<Experience> GetExperiences()
    {
        return _experiences;
    }
    public void Add(Experience experience)
    {
        _experiences.Add(experience);
    }
    public void Update(Experience experience, int id)
    {
        var existing = _experiences.Find(e => e.Id == experience.Id);
        if (existing == null) return;
        existing.Id = experience.Id;
        existing.Name = experience.Name;
        existing.Description = experience.Description;
        existing.Company = experience.Company;
        existing.EmployeeId = experience.EmployeeId;
    }
    public Experience GetExperienceById(int id)
    {
        
    }
    public List<Experience> GetExperiencesByUserId(int id)
    {

    }
    public void Delete(int id)
    {
        var existing = _experiences.Find(e => e.Id == id);
        if (existing == null) return;
        _experiences.Remove(existing);
    }
    public int Count()
    {
        return _experiences.Count;
    }

}
