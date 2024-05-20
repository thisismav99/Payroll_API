namespace Payroll_System_DAL.Repositories
{
    /**
     * <summary>
     *  A generic interface that accepts any class
     * </summary>
     * 
     * <remarks>
     *  Contains generic methods: <br></br>
     *      - Add() <br></br>
     *      - Update() <br></br>
     *      - Delete() <br></br>
     *      - GetAll() <br></br>
     *      - GetByID() <br></br>
     * </remarks>
     * **/
    public interface IPayrollRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<List<T>> GetAll();
        Task<T?> GetByID(int id);
    }
}
