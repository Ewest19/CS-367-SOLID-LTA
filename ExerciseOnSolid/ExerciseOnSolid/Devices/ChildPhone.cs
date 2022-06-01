using ExerciseOnSolid.Networks;

namespace ExerciseOnSolid.Devices
{
    public class ChildPhone
    {
        private readonly LegionWireless _cellularNetwork;
        public ChildPhone(string phoneNumber) => _cellularNetwork = new LegionWireless() { DevicePhoneNumber = phoneNumber };
        public NetworkStatus PlaceCall(string phoneNumber) => _cellularNetwork.PlaceCall(phoneNumber);
        public string PhoneNumber => _cellularNetwork.DevicePhoneNumber;
    }
}