﻿using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;

namespace LightSwitchApplication
{
    public partial class CreateNewDeviceStatus
    {
        partial void CreateNewDeviceStatus_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Write your code here.
            this.DeviceStatusProperty = new DeviceStatus();
        }

        partial void CreateNewDeviceStatus_Saved()
        {
            // Write your code here.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.DeviceStatusProperty);
        }
    }
}