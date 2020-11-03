﻿using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Periscope.Core.Extensions
{
    public static class TaskExtensions
    {
        [DebuggerStepThrough]
        public static ConfiguredTaskAwaitable<TResult> AnyContext<TResult>(this Task<TResult> task)
        {
            return task.ConfigureAwait(false);
        }

        [DebuggerStepThrough]
        public static ConfiguredTaskAwaitable AnyContext(this Task task)
        {
            return task.ConfigureAwait(false);
        }
    }
}
