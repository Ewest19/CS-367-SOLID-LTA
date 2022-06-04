using ExerciseOnSolid.Networks;

namespace ExerciseOnSolid.NetworkPackages
{
    public interface INetworksendTextMessage : INetwork, INetworkPlaceCall
    {
        NetworkStatus SendTextMessage(string phoneNumber, string message);
    }
}