using DataAccess.Model;

namespace DataAccess.DataAccessMethod
{
    public interface ICarEnrollService
    {
        Task AddCarAsync(DetailCarsEnroll detailCarsEnroll);
        Task EditCarAsync(string carId, string Model, int year);
        Task<IEnumerable<CarDetail>> GetCarDetailsAsync();
        Task RemoveCarAsync(string carId);
    }
}