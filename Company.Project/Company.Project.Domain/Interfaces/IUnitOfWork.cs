using Company.Project.Domain.Models;

namespace Company.Project.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IExampleClassRepository ExampleClassRepository { get; }
        Task Completeasync();
        void Dispose();
    }
}
