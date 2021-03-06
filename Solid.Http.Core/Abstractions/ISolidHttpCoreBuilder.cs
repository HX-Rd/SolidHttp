﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.Http.Abstractions
{
    /// <summary>
    /// The ISolidHttpBuilder interface
    /// </summary>
    public interface ISolidHttpCoreBuilder
    {
        /// <summary>
        /// Configure SolidHttp
        /// </summary>
        /// <param name="configure">The method used to configure SolidHttp</param>
        /// <returns>ISolidHttpSetup</returns>
        ISolidHttpCoreBuilder AddSolidHttpCoreOptions(Action<ISolidHttpOptions> configure);

        IServiceCollection Services { get; }
    }
}
