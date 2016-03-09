// Author: Craig Verburgh
// Created: 02/19/2016, 1:20 PM
// Modified: 03/04/2016, 9:42 AM

namespace Comtek.Helpers
{
    public static class UserHelper
    {
        public static string ParseUserName(string domainLogin)
        {
            return domainLogin.Replace("COMTEK\\", "");
        }
    } 
}