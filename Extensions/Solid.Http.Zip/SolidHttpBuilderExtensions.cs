﻿using Microsoft.Extensions.DependencyInjection;
using Solid.Http.Zip.Abstraction;
using Solid.Http.Zip.Providers;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Text;

namespace Solid.Http.Zip
{
    public static class SolidHttpBuilderExtensions
    {
        /// <summary>
        /// Adds support for ZipArchive
        /// <para>Can create a deserializer for application/xml and text/xml</para>
        /// </summary>
        /// <param name="builder">The setup</param>
        /// <param name="settings">Supplied XmlSerializerSettings</param>
        /// <returns>ISolidHttpSetup</returns>
        public static TBuilder AddZip<TBuilder>(this TBuilder builder, ZipArchiveMode mode = ZipArchiveMode.Read)
            where TBuilder : class, ISolidHttpBuilder
        {
            var provider = new ZipArchiveSerializerSettingsProvider(mode);
            builder.Services.AddSingleton<IZipSerializerSettingsProvider>(provider);
            builder.Services.AddSolidHttpDeserializer<ZipArchiveResponseDeserializerFactory>("application/zip", "application/octet-stream");

            return builder as TBuilder;
        }
    }
}
