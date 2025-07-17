using Company.Project.Domain.Interfaces;
using Company.Project.Domain.Models;
using Company.Project.Infrastructure.Repositories;
using Company.Project.theDbcontext;

namespace Company.Project.Infrastructure.UnitOfWork
{
    public class UnitOfWork :IUnitOfWork
    {
        private readonly Context _context;
        public IExampleClassRepository _exampleClassRepository;
        public UnitOfWork(Context context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public IExampleClassRepository ExampleClassRepository
        {
            get
            {
                return _exampleClassRepository ??= new ExampleClassRepository(_context);
            }
        }        

        public async Task Completeasync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}