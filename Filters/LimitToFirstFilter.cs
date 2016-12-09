using System.Linq;
using FirebaseDotNetCore.Subscriptions;
using Newtonsoft.Json.Linq;

namespace FirebaseDotNetCore.Filters
{
    internal class LimitToFirstFilter : ISubscriptionFilter
    {
        private readonly int _limit;

        public LimitToFirstFilter(int limit)
        {
            _limit = limit;
        }

        public JToken Apply(JToken filtered, IFilterContext context)
        {
            foreach (var child in filtered.Children().Skip(_limit).ToList())
            {
                child.Remove();
            }

            return filtered;
        }
    }
}