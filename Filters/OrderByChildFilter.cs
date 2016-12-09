using System.Linq;
using FirebaseDotNetCore.Subscriptions;
using Newtonsoft.Json.Linq;

namespace FirebaseDotNetCore.Filters
{
    internal class OrderByChildFilter : ISubscriptionFilter
    {
        private readonly string _child;

        public OrderByChildFilter(string child)
        {
            _child = child;
        }

        public JToken Apply(JToken filtered, IFilterContext context)
        {
            JObject result = new JObject();
            context.FilterColumn = _child;

            JObject obj = filtered as JObject;
            if (obj != null)
            {
                foreach (var ordered in filtered.Children().Cast<JProperty>().OrderBy(c =>
                {
                    if (c.Value.Type == JTokenType.Object)
                    {
                        return ((JObject) c.Value)[_child];
                    }

                    return (JObject) null;
                }, new FirebaseValueSorter()))
                {
                    result.Add(ordered);
                }
            }

            return result;
        }
    }
}