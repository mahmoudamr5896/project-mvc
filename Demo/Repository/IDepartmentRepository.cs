using Demo.Models;

namespace Demo.Repository
{
      interface IDepartmentRepository
    {
          List<Department> Getall();

          Department GetBY_ID(int id);

          void Delete(int id);

          void Update(int id, Department department);

          Department Add(Department department);
   
    }
}
