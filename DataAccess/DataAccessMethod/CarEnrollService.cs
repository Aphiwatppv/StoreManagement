using DataAccess.Model;
using DataAccess.SqlAccess;

namespace DataAccess.DataAccessMethod
{
    public class CarEnrollService : ICarEnrollService
    {
        ISqlDataAccessInternal _SqlDataAccessInternal;

        public CarEnrollService(ISqlDataAccessInternal sqlDataAccessInternal)
        {
            _SqlDataAccessInternal = sqlDataAccessInternal;
        }

        public async Task<IEnumerable<CarDetail>> GetCarDetailsAsync()
            => await _SqlDataAccessInternal.LoadDataAsync<CarDetail, dynamic>(storedProcedure: "dbo.spGetAllCarDetails", new { });

        public async Task AddCarAsync(DetailCarsEnroll detailCarsEnroll)
        {
            await _SqlDataAccessInternal.SaveDataAsync(storedProcedure: "dbo.spEnrollCar", new

            {
                CarID = detailCarsEnroll.CarID,
                Model = detailCarsEnroll.Model,
                Year = detailCarsEnroll.Year
            });
        }

        public async Task EditCarAsync(string carId, string Model, int year)
        {
            await _SqlDataAccessInternal.SaveDataAsync(storedProcedure: "dbo.spEditCarDetails", new

            {
                CarID = carId,
                newModel = Model,
                newYear = year
            });
        }

        public async Task RemoveCarAsync(string carId)
        {
            await _SqlDataAccessInternal.SaveDataAsync(storedProcedure: "dbo.spDeleteCar", new

            {
                CarID = carId,

            });
        }

    }
}
