// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System.Text.Json.Serialization;

namespace PortableEHRNetSDK.Network.Server.Request.Patient
{
    public class PatientPullSingleParameters : PatientPullParameters
    {
        [JsonPropertyName("feedItemId")] public string feedItemId { get; set; }
    }
}