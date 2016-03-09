// Author: Craig Verburgh
// Created: 02/19/2016, 1:20 PM
// Modified: 03/04/2016, 9:37 AM

using System;
using System.Collections.Generic;
using System.Linq;

namespace Comtek.Helpers
{
    public static class EnumUtil
    {
        public static IEnumerable<string> ConvertEnumToStringList<T>()
        {
            return Enum.GetValues(typeof (T)).Cast<string>().ToList();
        }

        public static IEnumerable<string> EnumToStringList<T>()
        {
            return Enum.GetNames(typeof (T)).ToList();
        }
    }
}