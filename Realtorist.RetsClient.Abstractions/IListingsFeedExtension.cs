using System;
using Realtorist.Models.Listings.Enums;

namespace Realtorist.RetsClient.Abstractions
{
    /// <summary>
    /// Describes extension which provides listings feed
    /// </summary>
    public interface IListingsFeedExtension
    {
        /// <summary>
        /// Unique name identifying feed type
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Type of the update flow to perform. Should implement <see cref="IUpdateFlow"/>
        /// </summary>
        Type UpdateFlowType { get; }
    }
}