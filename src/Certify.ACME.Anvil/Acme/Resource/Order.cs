﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Certify.ACME.Anvil.Acme.Resource
{
    /// <summary>
    /// Represents the ACME Order resource.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        /// <remarks>
        /// See <see cref="OrderStatus"/> for possible values.
        /// </remarks>
        [JsonProperty("status")]
        public OrderStatus? Status { get; set; }

        /// <summary>
        /// Gets or sets the expires.
        /// </summary>
        /// <value>
        /// The expires.
        /// </value>
        [JsonProperty("expires")]
        public DateTimeOffset? Expires { get; set; }

        /// <summary>
        /// Gets or sets the identifiers.
        /// </summary>
        /// <value>
        /// The identifiers.
        /// </value>
        public IList<Identifier> Identifiers { get; set; }

        /// <summary>
        /// Gets or sets the not before.
        /// </summary>
        /// <value>
        /// The not before.
        /// </value>
        [JsonProperty("notBefore")]
        public DateTimeOffset? NotBefore { get; set; }

        /// <summary>
        /// Gets or sets the not after.
        /// </summary>
        /// <value>
        /// The not after.
        /// </value>
        [JsonProperty("notAfter")]
        public DateTimeOffset? NotAfter { get; set; }

        /// <summary>
        /// The ARI Certificate ID of the certificate being replaced by the order. Should not be serialized if null. ARI is an optional extension to ACME.
        /// </summary>
        [JsonProperty("replaces", NullValueHandling = NullValueHandling.Ignore)]
        public string Replaces { get; set; }

        /// <summary>
        /// The ACME (https://datatracker.ietf.org/doc/draft-aaron-acme-profiles/) profile selection. Should not be serialized if null. Profiles are a WIP optional extension to ACME.
        /// </summary>
        [JsonProperty("profile", NullValueHandling = NullValueHandling.Ignore)]
        public string Profile { get; set; }

        /// <summary>
        /// Gets or sets the error.
        /// </summary>
        /// <value>
        /// The error.
        /// </value>
        /// <remarks>
        /// TODO: model https://tools.ietf.org/html/rfc7807
        /// </remarks>
        [JsonProperty("error")]
        public object Error { get; set; }

        /// <summary>
        /// Gets or sets the authorizations.
        /// </summary>
        /// <value>
        /// The authorizations.
        /// </value>
        [JsonProperty("authorizations")]
        public IList<Uri> Authorizations { get; set; }

        /// <summary>
        /// Gets or sets the finalize.
        /// </summary>
        /// <value>
        /// The finalize.
        /// </value>
        [JsonProperty("finalize")]
        public Uri Finalize { get; set; }

        /// <summary>
        /// Gets or sets the certificate.
        /// </summary>
        /// <value>
        /// The certificate.
        /// </value>
        [JsonProperty("certificate")]
        public Uri Certificate { get; set; }

        /// <summary>
        /// Represents the payload to finalize an order.
        /// </summary>
        /// <seealso cref="Certify.ACME.Anvil.Acme.Resource.Order" />
        internal class Payload : Order
        {
            /// <summary>
            /// Gets or sets the CSR.
            /// </summary>
            /// <value>
            /// The CSR.
            /// </value>
            [JsonProperty("csr")]
            internal string Csr { get; set; }
        }
    }
}
