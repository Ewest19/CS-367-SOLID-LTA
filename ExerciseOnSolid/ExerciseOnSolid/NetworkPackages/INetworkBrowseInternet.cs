using ExerciseOnSolid.Networks;

namespace ExerciseOnSolid.NetworkPackages
{
    public interface INetworkBrowseInternet : INetwork, INetworkPlaceCall, INetworksendTextMessage, INetworkPlaceVideoCall
    {
        NetworkStatus BrowseInternet(string url);
    }
}