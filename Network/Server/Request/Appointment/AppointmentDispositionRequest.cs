// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System.Text.Json.Serialization;

namespace PortableEHRNetSDK.Network.Server.Request.Appointment
{
    public class AppointmentDispositionRequest : FeedHubRequest
    {
        [JsonPropertyName("parameters")] public new AppointmentDispositionParameters parameters { get; set; }
    }
}