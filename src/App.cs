// Copyright (c) Arctium.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

IHost app = builder.Build();

await app.RunAsync();
