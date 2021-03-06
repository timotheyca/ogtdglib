﻿using System;
using DuckGame;
using JetBrains.Annotations;

namespace OgtDgLib
{
    /// <inheritdoc />
    /// <summary>
    ///     Empty thing with GetPath
    /// </summary>
    [PublicAPI]
    [Obsolete]
    public sealed class Nothing <T> : Thing where T : Mod
    {
        /// <summary>
        /// reimplementation of GetPath
        /// </summary>
        /// <param name="asset"></param>
        /// <returns></returns>
        public new string GetPath(string asset)
        {
            return Mod.GetPath<T>(asset);
        }
    }
    /// <summary>
    /// Empty Thing for some purposes
    /// </summary>
    [PublicAPI]
    public sealed class Nothing : Thing
    {

    }
}