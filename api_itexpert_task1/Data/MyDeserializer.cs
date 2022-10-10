using api_itexpert_task1.Models;
using Newtonsoft.Json;

namespace api_itexpert_task1.Data
{
    public static class MyDeserializer
    {
        internal static IEnumerable<CodeValueModel> GetPairOfCodeValueModel(string value)
        {
            List<CodeValueModel> result = new List<CodeValueModel>();
            var listValues = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(value);
            foreach (var val in listValues)
            {
                result.Add(new CodeValueModel { Code = int.Parse(val.Keys.FirstOrDefault()), Value = val.Values.FirstOrDefault() });
            }

            return result;
        }
    }
}
