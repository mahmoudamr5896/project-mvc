using Demo.Models;

namespace Demo.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        // crud operation 
        ITI_ENTITY context = new ITI_ENTITY();
        public List<Department> Getall()
        {
            List<Department> list = context.Departments.ToList();
            return list;
        }
        public Department GetBY_ID(int id) 
        {
            Department Dept = context.Departments.FirstOrDefault(d => d.Id==id);
            return Dept;
        }
        public void Delete(int id)
        {
            Department Dept = context.Departments.FirstOrDefault(d => d.Id == id);
            context.Departments.Remove(Dept);
        }
        public void Update(int id ,Department department)
        {
            Department Dept = context.Departments.FirstOrDefault(d => d.Id == id);
            Dept.Name = department.Name;
            Dept.Manger = department.Manger;
            context.SaveChanges();
        }
        public Department Add(Department department) 
        { 
            context.Departments.Add(department);
            context.SaveChanges();
            return department;
        }
    }
}
