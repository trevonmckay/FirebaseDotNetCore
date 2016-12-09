using System.Linq;
using FirebaseDotNetCore.Subscriptions;
using Newtonsoft.Json.Linq;

namespace FirebaseDotNetCore.Filters
{
    internal class OrderByKeyFilter : ISubscriptionFilter
    {
        public JToken Apply(JToken filtered, IFilterContext context)
        {
            JObject result = new JObject();

            foreach (var child in filtered.Children().OrderBy(t => t.Path, new FirebaseKeySorter()))
            {
                result.Add(child);
            }

            return result;
        }
    }
}