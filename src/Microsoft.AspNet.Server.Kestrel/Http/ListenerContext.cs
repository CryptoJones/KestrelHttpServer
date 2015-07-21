// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Server.Kestrel.Infrastructure;

namespace Microsoft.AspNet.Server.Kestrel.Http
{
    public class ListenerContext
    {
        public ListenerContext() { }

        public ListenerContext(ListenerContext context)
        {
            Thread = context.Thread;
            Application = context.Application;
            Memory = context.Memory;
            WritePool = context.WritePool;
        }

        public UvWriteReqPool WritePool { get; set; }

        public KestrelThread Thread { get; set; }

        public Func<Frame, Task> Application { get; set; }

        public IMemoryPool Memory { get; set; }
    }
}