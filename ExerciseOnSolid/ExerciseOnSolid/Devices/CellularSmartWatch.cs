using ExerciseOnSolid.Networks;
using ExerciseOnSolid.NetworkServices;
using ExerciseOnSolid.NetworkPackages;


namespace ExerciseOnSolid.Devices
{
    public class CellularSmartWatch : ICall, ITextMessage
    {
        private readonly INetworksendTextMessage _cellularNetwork;
        public CellularSmartWatch(INetworksendTextMessage network) => _cellularNetwork = network;
        public NetworkStatus PlaceCall(string phoneNumber) => _cellularNetwork.PlaceCall(phoneNumber);
        public NetworkStatus SendTextMessage(string phoneNumber, string message) => _cellularNetwork.SendTextMessage(phoneNumber, message);
        public string PhoneNumber => _cellularNetwork.DevicePhoneNumber;
    }
}