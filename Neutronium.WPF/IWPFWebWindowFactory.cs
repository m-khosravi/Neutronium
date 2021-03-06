﻿using System;
using Neutronium.Core;

namespace Neutronium.WPF
{
    /// <summary>
    /// IWPFWebWindow factory: abstraction of a WPF implementation of an HTML Browser
    /// </summary>
    public interface IWPFWebWindowFactory : IDisposable
    {
        /// <summary>
        /// Get the name and version of unferlying javascript engine
        /// </summary>
        string EngineName { get; }

        /// <summary>
        /// value of the .Net glue framework to javascript engine
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Create a new IWPFWebWindow 
        /// </summary>
        /// <returns>
        /// a new IWPFWebWindow
        ///</returns>
        IWPFWebWindow Create();

        /// <summary>
        /// get or set WebSessionLogger
        /// </summary>
        IWebSessionLogger WebSessionLogger { get; set; }
    }
}
