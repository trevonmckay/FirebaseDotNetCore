using System.Linq;
using FirebaseDotNetCore.Subscriptions;
using Newtonsoft.Json.Linq;

namespace FirebaseDotNetCore.Filters
{
    internal class OrderByPriorityFilter : ISubscriptionFilter
    {
        public JToken Apply(JToken filtered, IFilterContext context)
        {
            JObject result = new JObject();

            JObject obj = filtered as JObject;
            if (obj != null)
            {
                foreach (var ordered in filtered.Children().Cast<JProperty>().OrderBy(c =>
                {
                    if (c.Value.Type == JTokenType.Object)
                    {
                        return ((JObject) c.Value);
                    }

                    return (JObject) null;
                }, new FirebasePrioritySorter()))
                {
                    result.Add(ordered);
                }
            }

            return result;
        }
    }
}