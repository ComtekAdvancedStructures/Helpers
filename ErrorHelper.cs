// Author: Craig Verburgh
// Created: 03/08/2016, 11:28 AM
// Modified: 03/09/2016, 10:48 AM

using System;

namespace Comtek.Helpers
{
    public static class ErrorHelper
    {
        public static string GetExceptionMessage(Exception ex)
        {
            while (true)
            {
                if (ex.InnerException != null)
                {
                    return GetExceptionMessage(ex.InnerException);
                }

                var msg = ex.Message;

                return msg;
            }
        }
    }
}