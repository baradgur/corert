// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.InteropServices;

internal partial class Interop
{
    internal partial class Kernel32
    {
        internal const int ProcessLeapSecondInfo = 8;

        internal struct PROCESS_LEAP_SECOND_INFO
        {
            public uint Flags;
            public uint Reserved;
        }

        internal const uint PROCESS_LEAP_SECOND_INFO_FLAG_ENABLE_SIXTY_SECOND = 0x1;

        [DllImport(Libraries.Kernel32)]
        internal static unsafe extern bool GetProcessInformation(IntPtr hProcess, int ProcessInformationClass, void* ProcessInformation, int ProcessInformationSize);
    }
}