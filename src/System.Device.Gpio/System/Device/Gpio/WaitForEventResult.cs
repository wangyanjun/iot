﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Device.Gpio
{
    /// <summary>
    /// Resulting object after waiting for an event to happen.
    /// </summary>
    public struct WaitForEventResult
    {
        /// <summary>
        /// The event type to wait for.
        /// </summary>
        public PinEventTypes EventType;
        /// <summary>
        /// True if waiting for the event timed out. False if an event was triggered before the time out expired.
        /// </summary>
        public bool TimedOut;
    }
}
