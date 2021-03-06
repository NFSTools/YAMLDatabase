﻿using System;
using System.Collections.Generic;
using Attribulator.API.Plugin;

namespace Attribulator.API.Services
{
    /// <summary>
    /// Exposes an interface for registering and retrieving commands.
    /// </summary>
    public interface ICommandService
    {
        /// <summary>
        /// Registers a new command type.
        /// </summary>
        /// <typeparam name="TCommand">The command type.</typeparam>
        void RegisterCommand<TCommand>() where TCommand : BaseCommand;
        
        /// <summary>
        /// Registers a new command type.
        /// </summary>
        void RegisterCommand(Type type);

        /// <summary>
        /// Gets the registered command types.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/> that produces the command types.</returns>
        IEnumerable<Type> GetCommandTypes();
    }
}