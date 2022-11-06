using Microsoft.Extensions.Caching.Memory;

namespace DataAccessLibrary
{
    public class SampleDataAccess
    {
        private readonly IMemoryCache _memoryCache;

        public SampleDataAccess(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }
        public List<EmployeeModel> GetEmployees() 
        { 
            List<EmployeeModel> output = new ();
            output.Add(new() { FirstName = "Zakaria", LastName = "Bijoy" });
            output.Add(new() { FirstName = "Sue", LastName = "Strom" });
            output.Add(new() { FirstName = "Jane", LastName = "Jones" });

            Thread.Sleep(3000);

            return output;
        }

        public async Task<List<EmployeeModel>> GetEmployeesAsync()
        {
            List<EmployeeModel> output = new();
            output.Add(new() { FirstName = "Zakaria", LastName = "Bijoy" });
            output.Add(new() { FirstName = "Sue", LastName = "Strom" });
            output.Add(new() { FirstName = "Jane", LastName = "Jones" });

            await Task.Delay(3000);

            return output;
        }

        public async Task<List<EmployeeModel>> GetEmployeesCache()
        {
            List<EmployeeModel> output;

            output = _memoryCache.Get<List<EmployeeModel>>("employees");

            if(output is null)
            {
                output = await GetEmployeesAsync();

                _memoryCache.Set("employees",output, TimeSpan.FromMinutes(1));
            }

            return output;
        }
    }
}
