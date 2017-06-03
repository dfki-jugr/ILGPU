﻿// -----------------------------------------------------------------------------
//                                ILGPU Samples
//                   Copyright (c) 2017 ILGPU Samples Project
//                                www.ilgpu.net
//
// File: Program.cs
//
// This file is part of ILGPU and is distributed under the University of
// Illinois Open Source License. See LICENSE.txt for details.
// -----------------------------------------------------------------------------

using ILGPU;

namespace Empty
{
    class Program
    {
        /// <summary>
        /// Initializes an ILGPU context.
        /// </summary>
        static void Main(string[] args)
        {
            // Every application needs an instantiated global ILGPU context
            using (var context = new Context())
            {
                // Note that every other instantiated ILGPU object needs to be disposed before
                // disposing the global context.
            }
        }
    }
}
