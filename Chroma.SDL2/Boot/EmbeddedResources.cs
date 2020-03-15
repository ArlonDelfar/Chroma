﻿using System.IO;
using System.Reflection;

namespace Chroma.SDL2.Boot
{
    internal static class EmbeddedResources
    {
        private static readonly Assembly ThisAssembly = Assembly.GetExecutingAssembly();

        public static string[] GetResourceNames()
            => ThisAssembly.GetManifestResourceNames();

        public static Stream GetResourceStream(string fullyQualifiedName)
            => ThisAssembly.GetManifestResourceStream(fullyQualifiedName);
    }
}
