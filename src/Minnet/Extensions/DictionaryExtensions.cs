using System.Diagnostics;
using System.Globalization;

namespace Minnet.Extensions
{
    public static class DictionaryExtensions
    {
        public static void StripValue<T>(this IDictionary<string, T> dict, string key)
        {
            if(dict == null)
                return;

            key = key.ToLower(CultureInfo.InvariantCulture);

            var keyActual = dict.Keys.FirstOrDefault(x => x.ToLower(CultureInfo.InvariantCulture) == key);

            if(keyActual != null)
            {
                var result = dict.Remove(keyActual);
                Debug.Assert(result);
            }
        }
    }
}
