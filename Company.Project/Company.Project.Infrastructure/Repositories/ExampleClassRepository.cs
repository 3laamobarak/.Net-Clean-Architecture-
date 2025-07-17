using Company.Project.Domain.Interfaces;
using Company.Project.Domain.Models;
using Company.Project.theDbcontext;
using Microsoft.EntityFrameworkCore;

namespace Company.Project.Infrastructure.Repositories
{
    public class ExampleClassRepository : BaseRepository<ExampleClass>, IExampleClassRepository
    {
        public ExampleClassRepository(Context context) : base(context)
        {
            
        }
        
    }
}
