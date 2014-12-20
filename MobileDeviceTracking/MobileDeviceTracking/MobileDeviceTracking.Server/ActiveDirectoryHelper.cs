using System;
using System.Collections.Generic;
using System.DirectoryServices;


namespace ActiveDirectoryLookup
{
    public static class ActiveDirectoryInfo
    {
        #region "String Constants"
        /// <summary>
        /// Contains most commonly used User Properties by LDAP.
        /// Also an error string for properties not found in LDAP.
        /// </summary>
        public sealed class strings
        {
            private strings() { }
            public const string DISPLAYNAME = "displayName";
            public const string UserName = "sAMAccountName";
            public const string FName = "givenName";
            public const string LName = "sn";
            public const string EMAIL = "mail";
            public const string GID = "siemens-gid";
            public const string TITLE = "personalTitle";
            public const string DEPARTMENT = "department";
            public const string REPORTSTO = "manager";
            public const string VALUENOTFOUND = "Value not found in Active Directory!";
        }

        #endregion

        #region "Public Helper Methods"
        /// <summary>
        /// Gets the members of a Distribution List.
        /// </summary>
        /// <param name="containerTerm">Container term which maps to the name of the Distribution List.</param>
        /// <param name="domain">LDAP domain controller path to search for the Distribution List.</param>
        /// <returns>List of users and their domain in the Distribution List</returns>
        public static List<Tuple<string, string>> GetDistributionListUsers(string containerTerm, string domain)
        {
            List<Tuple<string, string>> userNames = new List<Tuple<string, string>>();
            DirectoryEntry ent = new DirectoryEntry(domain);
            DirectorySearcher searcher = new DirectorySearcher(ent);
            searcher.Filter = String.Format("CN={0}", containerTerm);
            SearchResult result = CreateSearcherFindOne(searcher);
            if (result != null)
            {
                foreach (string name in result.GetDirectoryEntry().Properties["member"])
                {
                    userNames.Add(ParseUserAndDomain(name));
                }
            }
            return userNames;
        }

        /// <summary>
        /// Gets properties for a LDAP user using user name and domain to search.
        /// </summary>
        /// <param name="user">User name</param>
        /// <param name="domain">LDAP domain controller path to search in.</param>
        /// <param name="properties">Array of LDAP properties to return for the user.</param>
        /// <returns>Dictionary of Properties for the User.</returns>
        public static IDictionary<string, string> UserPropertySearchByName(string user, string domain, params string[] properties)
        {
            try
            {
                DirectoryEntry ent = new DirectoryEntry(domain);
                DirectorySearcher searcher = new DirectorySearcher(ent);
                searcher.Filter = String.Format("CN={0}", user);
                SearchResult result = CreateSearcherFindOne(searcher);
                return UserProperties(result, properties);

            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Gets properties for a LDAP user using a GUID of the object and the domain to search.
        /// </summary>
        /// <param name="objectGuid">String representation of the object GUID to search</param>
        /// <param name="domain">LDAP domain controller path to search in.</param>
        /// <param name="properties">Array of LDAP properties to return for the user.<</param>
        /// <returns>Dictionary of Properties for the User.</returns>
        public static IDictionary<string, string> UserPropertySearchbyGuid(string objectGuid, string domain, params string[] properties)
        {
            try
            {
                DirectoryEntry ent = new DirectoryEntry(domain);
                DirectorySearcher searcher = new DirectorySearcher(ent);
                searcher.Filter = String.Format("objectGUID={0}", objectGuid);
                SearchResult result = CreateSearcherFindOne(searcher);
                return UserProperties(result, properties);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Parses the User and the Domain name from the full LDAP path (obtained
        /// from the Distribution List).
        /// </summary>
        /// <param name="ldapPath">LDAP Path of the user</param>
        /// <returns>User and Domain names.</returns>
        public static Tuple<string, string> ParseUserAndDomain(string ldapPath)
        {
            if ((ldapPath.Contains("CN=")) && (ldapPath.Contains("DC=")))
            {
                // Parse the manager name out of the Active Directory path
                int nameIndex = ldapPath.IndexOf("CN=") + 3;
                int nameEnd = ldapPath.IndexOf(",OU") - 3;
                string user = ldapPath.Substring(nameIndex, nameEnd).Replace("\\", "");
                // Parse the manager domain out of the Active Directory path
                int domainIndex = ldapPath.IndexOf("DC=") + 3;
                int domainEnd = ldapPath.Substring(domainIndex).IndexOf(",DC=");
                string domain = ldapPath.Substring(domainIndex, domainEnd);
                return new Tuple<string, string>(user, domain);
            }
            else
            {
                return new Tuple<string, string>("", "");
            }
        }

        #endregion

        #region "Private Methods"

        /// <summary>
        /// Returns a dictionary of the User Properties searched using the SearchResult object.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="properties"></param>
        /// <returns>String dictionary key and string value.</returns>
        private static Dictionary<string, string> UserProperties(SearchResult result, params string[] properties)
        {
            Dictionary<string, string> propertyValues = new Dictionary<string, string>(properties.Length);
            foreach (string property in properties)
            {
                string propertyValue = "";

                if (result != null)
                {
                    var results = result.Properties[property];
                    if (results.Count > 0)
                    {
                        object temp = result.Properties[property][0];
                        // If a byte array is used (normally GUIDs are stored), convert to a string representation
                        if (temp is byte[])
                        {
                            try
                            {
                                propertyValue = ByteArrayToOctetString((byte[])temp);
                            }
                            catch { }
                        }
                        else if (temp != null)
                        {
                            propertyValue = temp.ToString();
                        }
                    }
                }
                else
                {
                    // Error case that the property was not available
                    propertyValue = strings.VALUENOTFOUND;
                }
                propertyValues.Add(property, propertyValue);
            }
            return propertyValues;
        }

        private static SearchResult CreateSearcherFindOne(DirectorySearcher searcher)
        {
            SearchResult result;
            try
            {
                result = searcher.FindOne();
                return result;
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                result = null;
                return result;
            }
        }

        private static string ByteArrayToOctetString(byte[] byteGuid)
        {
            string queryGuid = string.Empty;
            foreach (byte b in byteGuid)
            {
                queryGuid += @"\" + b.ToString("x2");
            }
            return queryGuid;
        }

        #endregion
    }
}
