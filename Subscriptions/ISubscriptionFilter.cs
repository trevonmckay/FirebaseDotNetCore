using FirebaseDotNetCore.Filters;
using Newtonsoft.Json.Linq;

namespace FirebaseDotNetCore.Subscriptions
{
    internal interface ISubscriptionFilter
    {
        JToken Apply(JToken filtered, IFilterContext context);
    }
}