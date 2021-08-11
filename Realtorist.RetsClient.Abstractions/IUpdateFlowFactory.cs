using System;
using Realtorist.Models.Listings.Enums;

namespace Realtorist.RetsClient.Abstractions
{
    /// <summary>
    /// Describes factory which generates update flow
    /// </summary>
    public interface IUpdateFlowFactory
    {
        /// <summary>
        /// Gets listings update flow type based on listing source 
        /// </summary>
        /// <param name="listingSource">Listing source</param>
        /// <returns>Listings update flow type</returns>
        Type GetUpdateFlowType(ListingSource listingSource);
    }
}