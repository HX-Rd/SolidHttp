﻿using System;
namespace Solid.Http.Abstractions
{
    /// <summary>
    /// The ISolidHttpOptions interface
    /// </summary>
    public interface ISolidHttpOptions
    {

        /// <summary>
        /// The global events to be triggered during SolidHttp events
        /// </summary>
        ISolidHttpEvents Events { get; }
    }
}
