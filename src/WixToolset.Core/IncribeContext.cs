﻿// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Core
{
    using WixToolset.Data;
    using WixToolset.Extensibility;

    internal class InscribeContext : IInscribeContext
    {
        public Messaging Messaging { get; } = Messaging.Instance;

        public string IntermediateFolder { get; set; }

        public string InputFilePath { get; set; }

        public string SignedEngineFile { get; set; }

        public string OutputFile { get; set; }
    }
}