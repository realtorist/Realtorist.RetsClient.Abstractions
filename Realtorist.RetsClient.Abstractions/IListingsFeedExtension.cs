using System;
using Realtorist.Models.Listings;

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

        /// <summary>
        /// Url to the image 'Powered By' to be displayed on listing details if present
        /// </summary>
        string? PoweredByImageUrl { get; }

        /// <summary>
        /// Gets link to the original listing view (i.e. realtor.ca) if needed
        /// </summary>
        /// <param name="listing">Listing</param>
        /// <returns>External listing link</returns>
        string GetExternalLink(Listing listing);
    }
}