using SuperMarket.Web.Models;

namespace SuperMarket.Web.Services.IServices
{
    public interface IBaseService : IDisposable
    {       
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}
