namespace ExerciseOnSolid.Networks
{
    public interface INetwork
    {
        string CarrierName { get; init; }
        string DevicePhoneNumber { get; init; }

        NetworkStatus PlaceCall(string phoneNumber);
        NetworkStatus PlaceVideoCall(string phoneNumber);
        NetworkStatus SendTextMessage(string phoneNumber, string message);
    }

    public interface INetworkBrowseInternet
    {
        NetworkStatus BrowseInternet(string url);
    }
}