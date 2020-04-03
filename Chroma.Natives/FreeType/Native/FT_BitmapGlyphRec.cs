﻿using System.Runtime.InteropServices;

namespace Chroma.Natives.FreeType.Native
{
    [StructLayout(LayoutKind.Sequential)]
    public struct FT_BitmapGlyphRec
    {
        public FT_GlyphRec root;
        public int left;
        public int top;
        public FT_Bitmap bitmap;
    }
}
