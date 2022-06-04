using ExerciseOnSolid.Networks;
using ExerciseOnSolid.NetworkServices;
using ExerciseOnSolid.NetworkPackages;

namespace ExerciseOnSolid.Devices
{

    public class SmartPhone : ICall, ITextMessage, IPlaceVideoCall, IBrowseInternet
    {
        private readonly INetworkBrowseInternet _cellularNetwork;
        public SmartPhone(INetworkBrowseInternet network) => _cellularNetwork = network;
        public NetworkStatus PlaceCall(string phoneNumber) => _cellularNetwork.PlaceCall(phoneNumber);
        public NetworkStatus PlaceVideoCall(string phoneNumber) => _cellularNetwork.PlaceVideoCall(phoneNumber);
        public NetworkStatus SendTextMessage(string phoneNumber, string message) => _cellularNetwork.SendTextMessage(phoneNumber, message);
        public NetworkStatus BrowseInternet(string url) => _cellularNetwork.BrowseInternet(url);
        public string PhoneNumber => _cellularNetwork.DevicePhoneNumber;
    }
}