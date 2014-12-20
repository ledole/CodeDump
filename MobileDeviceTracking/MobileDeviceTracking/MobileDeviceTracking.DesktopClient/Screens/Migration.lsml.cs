using System;
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
    public partial class Migration
    {
        partial void Migrations_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Migrations);
        }

        partial void Migrations_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Migrations);
        }

        partial void Migration_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Migrations);
        }
    }
}