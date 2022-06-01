using ExerciseOnSolid.Networks;

namespace ExerciseOnSolid.Devices
{
    public class SmartPhone
    {
        private readonly SkynetWireless _cellularNetwork;
        public SmartPhone(string phoneNumber) => _cellularNetwork = new SkynetWireless() { DevicePhoneNumber = phoneNumber };
        public NetworkStatus PlaceCall(string phoneNumber) => _cellularNetwork.PlaceCall(phoneNumber);
        public NetworkStatus PlaceVideoCall(string phoneNumber) => _cellularNetwork.PlaceVideoCall(phoneNumber);
        public NetworkStatus SendTextMessage(string phoneNumber, string message) => _cellularNetwork.SendTextMessage(phoneNumber, message);
        public NetworkStatus BrowseInternet(string url) => _cellularNetwork.BrowseInternet(url);
        public string PhoneNumber => _cellularNetwork.DevicePhoneNumber;
    }
}