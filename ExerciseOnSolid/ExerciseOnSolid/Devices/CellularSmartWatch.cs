using ExerciseOnSolid.Networks;

namespace ExerciseOnSolid.Devices
{
    public class CellularSmartWatch
    {
        private readonly SkynetWireless _cellularNetwork;
        public CellularSmartWatch(string phoneNumber) => _cellularNetwork = new SkynetWireless() { DevicePhoneNumber = phoneNumber };
        public NetworkStatus PlaceCall(string phoneNumber) => _cellularNetwork.PlaceCall(phoneNumber);
        public NetworkStatus SendTextMessage(string phoneNumber, string message) => _cellularNetwork.SendTextMessage(phoneNumber, message);
        public string PhoneNumber => _cellularNetwork.DevicePhoneNumber;
    }
}