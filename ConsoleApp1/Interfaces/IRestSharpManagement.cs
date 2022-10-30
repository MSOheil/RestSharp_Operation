using RestSharp;
using System.Threading.Tasks;

namespace RestShar_Sample.Interfaces
{
    public interface IRestSharpManagement
    {
        RestClient GetConnection(string serverAddress);
        Task<TResult> PostMethod<TResult, TBody>(string serverUrl, TBody body, object? queryString);
        Task<TResult> GetMethod<TResult, TQuery>(string serverUrl, TQuery queryString);
        Task Getsdf();
    }
}
