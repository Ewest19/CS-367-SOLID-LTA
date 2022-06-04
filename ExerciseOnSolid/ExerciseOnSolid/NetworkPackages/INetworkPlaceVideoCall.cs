using ExerciseOnSolid.Networks;

namespace ExerciseOnSolid.NetworkPackages
{
    public interface INetworkPlaceVideoCall: INetwork
    {
        NetworkStatus PlaceVideoCall(string phoneNumber);
    }
}