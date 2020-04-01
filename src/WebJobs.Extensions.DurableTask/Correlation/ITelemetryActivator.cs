﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Azure.WebJobs.Extensions.DurableTask.Correlation
{
    /// <summary>
    /// ITelemetryActivator is an interface.
    /// </summary>
    public interface ITelemetryActivator
    {
        /// <summary>
        /// Initialize is initialize the telemetry client.
        /// </summary>
        void Initialize();
    }
}
