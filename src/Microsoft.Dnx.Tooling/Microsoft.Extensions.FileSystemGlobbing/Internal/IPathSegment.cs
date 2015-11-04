// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.Extensions.FileSystemGlobbing.Internal
{
    internal interface IPathSegment
    {
        bool CanProduceStem { get; }

        bool Match(string value);
    }
}