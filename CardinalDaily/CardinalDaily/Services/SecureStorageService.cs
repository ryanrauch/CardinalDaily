using CardinalDaily.Services.Interfaces;
using System;
using System.Threading.Tasks;
using Xamarin.Essentials;

//https-://docs.microsoft.com/en-us/xamarin/essentials/secure-storage?context=xamarin%2Fxamarin-forms&tabs=ios

namespace CardinalDaily.Services
{
    public class SecureStorageService : ISecureStorageService
    {
        public async Task<bool> WriteDataAsync(string key, string val)
        {
            try
            {
                await SecureStorage.SetAsync(key, val);
                return true;
            }
            catch (Exception ex)
            {
                // Possible that device doesn't support secure storage on device.
                return false;
            }
        }

        public async Task<string> ReadDataAsync(string key)
        {
            try
            {
                return await SecureStorage.GetAsync(key);
            }
            catch (Exception ex)
            {
                // Possible that device doesn't support secure storage on device.
                return ex.Message;
            }
        }
    }
}
