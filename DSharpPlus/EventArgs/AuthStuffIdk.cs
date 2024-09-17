// This file is part of the DSharpPlus project.
//
// Copyright (c) 2015 Mike Santiago
// Copyright (c) 2016-2023 DSharpPlus Contributors
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DSharpPlus.EventArgs
{
    public class AuthStuffIdk
    {
        [JsonProperty("backup", NullValueHandling = NullValueHandling.Ignore)]
        public bool Backup { get; internal set; }

        [JsonProperty("mfa", NullValueHandling = NullValueHandling.Ignore)]
        public bool Mfa { get; internal set; }

        [JsonProperty("sms", NullValueHandling = NullValueHandling.Ignore)]
        public bool Sms { get; internal set; }

        [JsonProperty("ticket", NullValueHandling = NullValueHandling.Ignore)]
        public string Ticket { get; internal set; }

        [JsonProperty("totp", NullValueHandling = NullValueHandling.Ignore)]
        public bool Totp { get; internal set; }

        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public ulong UserId { get; internal set; }

        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; internal set; }
    }
}
