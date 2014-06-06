namespace CohesionAndCoupling
{
    public static class FileUtilities
    {
        public static string GetFileExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".", System.StringComparison.Ordinal);
            if (indexOfLastDot == -1)
            {
                // not sure about this, it may be better to give exception, but there are files like ".gitignore" without
                // extension, if this throws exceptions on them it will became very annoying. 
                return string.Empty;
            }

            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        public static string GetFileNameWithoutExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".", System.StringComparison.Ordinal);
            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            string extension = fileName.Substring(0, indexOfLastDot);
            return extension;
        }
    }
}
