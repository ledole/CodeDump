using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Security.Server;
using System.Configuration;
using ActiveDirectoryLookup;
using System.Collections;
namespace LightSwitchApplication
{
    public partial class ApplicationDataService
    {
        string domain = ConfigurationManager.AppSettings["LDAPDirectory"];

        Boolean ActiveDirectoryAvailable = Convert.ToBoolean(ConfigurationManager.AppSettings["LDAPAVAILABLE"]);

        string DisplayName = string.Empty;
        string EmailAddress = string.Empty;
        string FName = string.Empty;
        string Title = string.Empty;
        string LName = string.Empty;
        string Department = string.Empty;
        string UserName = string.Empty;
        string GID = string.Empty;
        string Manager = string.Empty; 

        partial void Customers_Inserting(Customer entity)
        {
            PopulateADUserInfo(entity);
        }

        private void PopulateADUserInfo(Customer entity)
        {
            if (entity.UserName != "" && entity.UserName != null && ActiveDirectoryAvailable)
            {

                SearchEmployeeRecord(entity.UserName);
                if (this.GID != "")
                {
                    entity.GID = this.GID;
                }
                if (this.DisplayName != "")
                {
                    entity.DisplayName = this.DisplayName;
                }
                if (this.FName != "")
                {
                    entity.FName = this.FName;
                }
                if (this.LName != "")
                {
                    entity.LName = this.LName;
                }
                if (this.EmailAddress != "")
                {
                    entity.Email = this.EmailAddress;
                }
                if (this.UserName != "")
                {
                    entity.UserName = this.UserName;
                }
            }
        }

        private void SearchEmployeeRecord(string UserName)
        {
            string[] props = {  
                                    ActiveDirectoryInfo.strings.DISPLAYNAME,
                                    ActiveDirectoryInfo.strings.GID,
                                    ActiveDirectoryInfo.strings.EMAIL,
                                    ActiveDirectoryInfo.strings.TITLE,
                                    ActiveDirectoryInfo.strings.REPORTSTO,
                                    ActiveDirectoryInfo.strings.DEPARTMENT,
                                    ActiveDirectoryInfo.strings.UserName,
                                    ActiveDirectoryInfo.strings.FName,
                                    ActiveDirectoryInfo.strings.LName
                             };

            var propResults = ActiveDirectoryInfo.UserPropertySearchByName(UserName, domain, props);
            string usrGid = propResults[ActiveDirectoryInfo.strings.GID];
            if (usrGid != ActiveDirectoryInfo.strings.VALUENOTFOUND)
            {
                DisplayName = propResults[ActiveDirectoryInfo.strings.DISPLAYNAME];
                EmailAddress = propResults[ActiveDirectoryInfo.strings.EMAIL];
                FName = propResults[ActiveDirectoryInfo.strings.FName];
                Title = propResults[ActiveDirectoryInfo.strings.TITLE];
                LName = propResults[ActiveDirectoryInfo.strings.LName];
                UserName = propResults[ActiveDirectoryInfo.strings.UserName];
                Department = propResults[ActiveDirectoryInfo.strings.DEPARTMENT];
                GID = propResults[ActiveDirectoryInfo.strings.GID];
                Manager = propResults[ActiveDirectoryInfo.strings.REPORTSTO];
            }
        }
    }
}
