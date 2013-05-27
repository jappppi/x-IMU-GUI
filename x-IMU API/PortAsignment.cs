﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace xIMU_API
{
    /// <summary>
    /// Port asignment class.
    /// </summary>
    public class PortAssignment
    {
        private string privPortName;
        private string privDeviceID;

        /// <summary>
        /// Gets the port name assigned the x-IMU.
        /// </summary>
        public string PortName
        {
            get
            {
                return privPortName;
            }
        }

        /// <summary>
        /// Gets the device ID of x-IMU.
        /// </summary>
        public string DeviceID
        {
            get
            {
                return privDeviceID;
            }
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="PortAssignment"/> class.
        /// </summary>
        /// <param name="portName">
        /// Port name assigned the x-IMU.
        /// </param>
        /// <param name="deviceID">
        /// Device ID of x-IMU.
        /// </param>
        public PortAssignment(string portName, string deviceID)
        {
            privPortName = portName;
            privDeviceID = deviceID;
        }
    }
}