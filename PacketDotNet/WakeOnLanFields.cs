﻿
/*
This file is part of PacketDotNet

This Source Code Form is subject to the terms of the Mozilla Public
License, v. 2.0. If a copy of the MPL was not distributed with this
file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/
/*
 *  Copyright 2019 George Rahul<georgerahul143@gmail.com>
 */

namespace PacketDotNet
{
    /// <summary>
    /// Wake-On-Lan protocol field encoding information.
    /// </summary>
    public struct WakeOnLanFields
    {
        /// <summary>Position of the Sync Sequence within the Wake-On-Lan header.</summary>
        public static readonly int SyncSequencePosition = 0;

        /// <summary>Size of an Sync Sequence in bytes.</summary>
        public static readonly int SyncSequenceLength = 6;

        /// <summary>Position of the Destination Address within the Wake-On-Lan header.</summary>
        public static readonly int DestinationAddressPosition;

        /// <summary>Size of an Destination Address in bytes.</summary>
        public static readonly int DestinationAddressLength;

        /// <summary>Number of times Destination Address is repeated in Wake-On-Lan.</summary>
        public static readonly int MacAddressRepetition = 16;

        /// <summary>Position of the Password within the Wake-On-Lan header.</summary>
        public static readonly int PasswordPosition;

        static WakeOnLanFields()
        {
            DestinationAddressPosition = SyncSequenceLength;
            DestinationAddressLength = MacAddressRepetition * EthernetFields.MacAddressLength;
            PasswordPosition = DestinationAddressPosition + DestinationAddressLength;
        }
    }
}