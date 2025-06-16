using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ImplementaciónAlgoritmos.UI.Forms
{
    public static class TaskExtensions
    {
        public static async Task WithCancellation(this Task task, CancellationToken token)
        {
            var tcs = new TaskCompletionSource<bool>();
            using (token.Register(s => ((TaskCompletionSource<bool>)s).TrySetResult(true), tcs))
            {
                if (task != await Task.WhenAny(task, tcs.Task))
                    throw new OperationCanceledException(token);
            }
            await task;
        }
    }
}
