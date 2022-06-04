using ExerciseOnSolid.Networks;

namespace ExerciseOnSolid.NetworkPackages
{
    public interface INetworkPlaceCall : INetwork
    {
        NetworkStatus PlaceCall(string phoneNumber);
    }
}