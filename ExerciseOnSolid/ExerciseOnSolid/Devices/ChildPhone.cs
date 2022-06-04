using ExerciseOnSolid.Networks;
using ExerciseOnSolid.NetworkServices;
using ExerciseOnSolid.NetworkPackages;


namespace ExerciseOnSolid.Devices
{
    public class ChildPhone : ICall
    {
        private readonly INetworkPlaceCall _cellularNetwork;
        public ChildPhone(INetworkPlaceCall network) => _cellularNetwork = network;
        public NetworkStatus PlaceCall(string phoneNumber) => _cellularNetwork.PlaceCall(phoneNumber);
        public string PhoneNumber => _cellularNetwork.DevicePhoneNumber;
    }
}