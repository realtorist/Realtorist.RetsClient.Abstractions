using System.Threading.Tasks;

namespace Realtorist.RetsClient.Abstractions
{
    /// <summary>
    /// Describes flow to update listings in database
    /// </summary>
    public interface IUpdateFlow
    {
        /// <summary>
        /// Launches update
        /// </summary>
        /// <returns>Numbers of total processed records</returns>
        Task<int> LaunchAsync();
    }
}
