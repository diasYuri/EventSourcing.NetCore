﻿using System.Threading;
using System.Threading.Tasks;

namespace DataAnalytics.Core.Subscriptions
{
    public interface ISubscriptionCheckpointRepository
    {
        ValueTask<ulong?> Load(string subscriptionId, CancellationToken ct);

        ValueTask Store(string subscriptionId, ulong position, CancellationToken ct);
    }
}
