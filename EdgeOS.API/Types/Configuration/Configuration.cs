﻿using Newtonsoft.Json;

namespace EdgeOS.API.Types.Configuration
{
    /// <summary>A class representing an EdgeOS configuration tree.</summary>
    public class Configuration
    {
        /// <summary>Custom attribute name</summary>
        [JsonProperty(PropertyName = "custom-attribute")]
        public string[] CustomAttribute;

        /// <summary>Firewall</summary>
        [JsonProperty(PropertyName = "firewall")]
        public Firewall Firewall;

        /// <summary>Network interfaces</summary>
        [JsonProperty(PropertyName = "interfaces")]
        public object Interfaces;

        /// <summary>Load Balance</summary>
        [JsonProperty(PropertyName = "load-balance")]
        public object LoadBalance;

        /// <summary>Routing policy</summary>
        [JsonProperty(PropertyName = "policy")]
        public object Policy;

        /// <summary>Port forwarding</summary>
        [JsonProperty(PropertyName = "port-forward")]
        public object PortForward;

        /// <summary>Routing protocol parameters</summary>
        [JsonProperty(PropertyName = "protocols")]
        public object Protocols;

        /// <summary>Services</summary>
        [JsonProperty(PropertyName = "service")]
        public object Service;

        /// <summary>System parameters</summary>
        [JsonProperty(PropertyName = "system")]
        public object System;

        /// <summary>Traffic control (QOS) type</summary>
        [JsonProperty(PropertyName = "traffic-control")]
        public object TrafficControl;

        /// <summary>Quality of Service (QOS) policy type</summary>
        [JsonProperty(PropertyName = "traffic-policy")]
        public object TrafficPolicy;

        /// <summary>Virtual Private Network (VPN)</summary>
        [JsonProperty(PropertyName = "vpn")]
        public object VPN;

        /// <summary>Configure zone-policy</summary>
        [JsonProperty(PropertyName = "zone-policy")]
        public object ZonePolicy;
    }
}