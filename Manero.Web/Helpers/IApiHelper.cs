﻿
namespace Manero.Web.Helpers
{
    public interface IApiHelper
    {
        Task<T> GetAsync<T>(string url);
        Task<HttpResponseMessage> PostAsync<T>(string url, T model);
        Task<HttpResponseMessage> PostFormData(string url, MultipartFormDataContent file);
        T DeserializeJson<T>(string json);
    }
}