using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ActiveDirectoryLookup;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Security.Server;
namespace LightSwitchApplication
{
    public partial class ApplicationDataService
    {
        // Enter your own LDAP directory path you wish to search on
        string domain = @"LDAP://OU=EUsers,DC=ww007,DC=siemens,DC=net";

        partial void DistributionLists_Inserting(Customer entity)
        {
            List<Tuple<string, string>> members = ActiveDirectoryInfo.GetDistributionListUsers(entity.Name, domain);
            if (members != null)
            {
                CreateMembers(members, entity);
            }
        }

        private void CreateMembers(List<Tuple<string, string>> members, DistributionList entity)
        {
            foreach (var m in members)
            {
                string[] props = { ActiveDirectoryInfo.strings.DISPLAYNAME,
                                        ActiveDirectoryInfo.strings.EMAIL,
                                        ActiveDirectoryInfo.strings.PHONE,
                                        ActiveDirectoryInfo.strings.TITLE,
                                        ActiveDirectoryInfo.strings.REPORTSTO };
                var propResults = ActiveDirectoryInfo.UserPropertySearchByName(m.Item1, domain, props);
                Member mem = entity.Members.AddNew();
                mem.DistributionList = entity;
                mem.Name = propResults[ActiveDirectoryInfo.strings.DISPLAYNAME];
                mem.Email = propResults[ActiveDirectoryInfo.strings.EMAIL];
                mem.Phone = propResults[ActiveDirectoryInfo.strings.PHONE];
                mem.Title = propResults[ActiveDirectoryInfo.strings.TITLE];

                // Parse the manager name out of the Active Directory path that is returned
                Tuple<string, string> managerKey = ActiveDirectoryInfo.ParseUserAndDomain(propResults[ActiveDirectoryInfo.strings.REPORTSTO]);
                string managerDisplayName = string.Empty;
                if (managerKey.Item2 != "")
                {
                    var managerName = ActiveDirectoryInfo.UserPropertySearchByName(managerKey.Item1, domain, ActiveDirectoryInfo.strings.DISPLAYNAME);
                    managerDisplayName = managerName[ActiveDirectoryInfo.strings.DISPLAYNAME];
                }
                mem.Manager = managerDisplayName;
            }
        }
    }
}
