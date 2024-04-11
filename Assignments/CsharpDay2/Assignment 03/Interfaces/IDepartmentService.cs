namespace Assignment_03.Interfaces;
using Assignment_03.Models;

public interface IDepartmentService
{
    void AddDepartment(Department department);
    void AssignHeadOfDepartment(Instructor instructor, Department department);
    public List<String> GetDepartmentList();
    public Instructor getHeadOfDepartment(Department department);
}