﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SolidHttp.Extensions.Testing.Assertions
{
    public class Assertion
    {
        internal Assertion(SolidHttpRequest request)
        {
            Request = request;

        }

        public SolidHttpRequest Request { get; private set; }

        /// <summary>
        /// The awaiter that enables a SolidHttpTestingAssertion to be awaited
        /// </summary>
        /// <returns>A TaskAwaiter</returns>
        public TaskAwaiter GetAwaiter()
        {
            Func<Assertion, Task> waiter = (async r =>
            { 
                await Request;
            });
            return waiter(this).GetAwaiter();
        }
    }
}