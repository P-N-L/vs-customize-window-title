﻿// Guids.cs
// MUST match guids.h
using System;

namespace ErwinMayerLabs.RenameVSWindowTitle
{
    static class GuidList {

        public const string guidCustomizeVSWindowTitle2PkgString = "5126c493-138a-46d7-a04d-ad772f6be159";
        public const string guidCustomizeVSWindowTitle2CmdSetString = "939a4ccc-55d2-4f90-8858-b7fce11bb09c";

        public static readonly Guid guidCustomizeVSWindowTitle2CmdSet = new Guid(guidCustomizeVSWindowTitle2CmdSetString);
    };
}