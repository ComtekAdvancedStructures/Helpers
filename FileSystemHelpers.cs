using System.Collections.Generic;
using System.IO;

namespace Comtek.Helpers
{
    public static class FileSystemHelpers
    {
        /// <summary>
        /// Search a folder and optionally all subfolders for files matching the supplied pattern
        /// </summary>
        /// <param name="root">UNC File Location</param>
        /// <param name="fileSearchPattern">File search pattern</param>
        /// <param name="searchOption">Search Option</param>
        /// <returns>List of files, including full UNC path</returns>
        public static List<string> GetAllFilesInFolder(string root, string fileSearchPattern, SearchOption searchOption)
        {
            var result = new List<string>();

            if (!Directory.Exists(root))
            {
                return result;
            }

            result.AddRange(Directory.EnumerateFiles(root, fileSearchPattern, searchOption));

            return result;
        }

        public static string[] SplitFilePathToPathAndFile(string path)
        {
            var model = new string[2];

            if (string.IsNullOrEmpty(path)) return model;

            model[0] = GetPathFromFullPath(path);
            model[1] = GetFileNameFromFullPath(path);

            return model;
        }

        public static string GetFileNameFromFullPath(string path)
        {
            if (string.IsNullOrEmpty(path)) return "You must enter a path";

            var lastSlash = path.LastIndexOf('\\');

            return path.Substring(lastSlash+1, (path.Length - lastSlash-1));
        }

        public static string GetPathFromFullPath(string path)
        {
            if (string.IsNullOrEmpty(path)) return "You must enter a path";

            var lastSlash = path.LastIndexOf('\\');

            return path.Substring(0, (lastSlash + 1));
        }
    }
}
