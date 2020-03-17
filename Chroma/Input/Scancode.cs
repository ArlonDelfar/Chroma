using Chroma.SDL2;

namespace Chroma.Input
{
    public enum Scancode
    {
        // --- Alphanumerics group
        Alpha0 = SDL.SDL_Scancode.SDL_SCANCODE_0,
        Alpha1 = SDL.SDL_Scancode.SDL_SCANCODE_1,
        Alpha2 = SDL.SDL_Scancode.SDL_SCANCODE_2,
        Alpha3 = SDL.SDL_Scancode.SDL_SCANCODE_3,
        Alpha4 = SDL.SDL_Scancode.SDL_SCANCODE_4,
        Alpha5 = SDL.SDL_Scancode.SDL_SCANCODE_5,
        Alpha6 = SDL.SDL_Scancode.SDL_SCANCODE_6,
        Alpha7 = SDL.SDL_Scancode.SDL_SCANCODE_7,
        Alpha8 = SDL.SDL_Scancode.SDL_SCANCODE_8,
        Alpha9 = SDL.SDL_Scancode.SDL_SCANCODE_9,
        A = SDL.SDL_Scancode.SDL_SCANCODE_A,
        B = SDL.SDL_Scancode.SDL_SCANCODE_B,
        C = SDL.SDL_Scancode.SDL_SCANCODE_C,
        D = SDL.SDL_Scancode.SDL_SCANCODE_D,
        E = SDL.SDL_Scancode.SDL_SCANCODE_E,
        F = SDL.SDL_Scancode.SDL_SCANCODE_F,
        G = SDL.SDL_Scancode.SDL_SCANCODE_G,
        H = SDL.SDL_Scancode.SDL_SCANCODE_H,
        I = SDL.SDL_Scancode.SDL_SCANCODE_I,
        J = SDL.SDL_Scancode.SDL_SCANCODE_J,
        K = SDL.SDL_Scancode.SDL_SCANCODE_K,
        L = SDL.SDL_Scancode.SDL_SCANCODE_L,
        M = SDL.SDL_Scancode.SDL_SCANCODE_M,
        N = SDL.SDL_Scancode.SDL_SCANCODE_N,
        O = SDL.SDL_Scancode.SDL_SCANCODE_O,
        P = SDL.SDL_Scancode.SDL_SCANCODE_P,
        Q = SDL.SDL_Scancode.SDL_SCANCODE_Q,
        R = SDL.SDL_Scancode.SDL_SCANCODE_R,
        S = SDL.SDL_Scancode.SDL_SCANCODE_S,
        T = SDL.SDL_Scancode.SDL_SCANCODE_T,
        U = SDL.SDL_Scancode.SDL_SCANCODE_U,
        V = SDL.SDL_Scancode.SDL_SCANCODE_V,
        W = SDL.SDL_Scancode.SDL_SCANCODE_W,
        X = SDL.SDL_Scancode.SDL_SCANCODE_X,
        Y = SDL.SDL_Scancode.SDL_SCANCODE_Y,
        Z = SDL.SDL_Scancode.SDL_SCANCODE_Z,
        
        // --- Function group.
        F1 = SDL.SDL_Scancode.SDL_SCANCODE_F1,
        F2 = SDL.SDL_Scancode.SDL_SCANCODE_F2,
        F3 = SDL.SDL_Scancode.SDL_SCANCODE_F3,
        F4 = SDL.SDL_Scancode.SDL_SCANCODE_F4,
        F5 = SDL.SDL_Scancode.SDL_SCANCODE_F5,
        F6 = SDL.SDL_Scancode.SDL_SCANCODE_F6,
        F7 = SDL.SDL_Scancode.SDL_SCANCODE_F7,
        F8 = SDL.SDL_Scancode.SDL_SCANCODE_F8,
        F9 = SDL.SDL_Scancode.SDL_SCANCODE_F9,
        F10 = SDL.SDL_Scancode.SDL_SCANCODE_F10,
        F11 = SDL.SDL_Scancode.SDL_SCANCODE_F11,
        F12 = SDL.SDL_Scancode.SDL_SCANCODE_F12,
        F13 = SDL.SDL_Scancode.SDL_SCANCODE_F13,
        F14 = SDL.SDL_Scancode.SDL_SCANCODE_F14,
        F15 = SDL.SDL_Scancode.SDL_SCANCODE_F15,
        F16 = SDL.SDL_Scancode.SDL_SCANCODE_F16,
        F17 = SDL.SDL_Scancode.SDL_SCANCODE_F17,
        F18 = SDL.SDL_Scancode.SDL_SCANCODE_F18,
        F19 = SDL.SDL_Scancode.SDL_SCANCODE_F19,
        F20 = SDL.SDL_Scancode.SDL_SCANCODE_F20,
        F21 = SDL.SDL_Scancode.SDL_SCANCODE_F21,
        F22 = SDL.SDL_Scancode.SDL_SCANCODE_F22,
        F23 = SDL.SDL_Scancode.SDL_SCANCODE_F23,
        F24 = SDL.SDL_Scancode.SDL_SCANCODE_F24,
        
        // --- Punctuation group.
        Comma = SDL.SDL_Scancode.SDL_SCANCODE_COMMA,
        Period = SDL.SDL_Scancode.SDL_SCANCODE_PERIOD,
        Slash = SDL.SDL_Scancode.SDL_SCANCODE_SLASH,
        Semicolon = SDL.SDL_Scancode.SDL_SCANCODE_SEMICOLON,
        Apostrophe = SDL.SDL_Scancode.SDL_SCANCODE_APOSTROPHE,
        Backslash = SDL.SDL_Scancode.SDL_SCANCODE_BACKSLASH,
        BackslashIso = SDL.SDL_Scancode.SDL_SCANCODE_NONUSBACKSLASH,
        Equals = SDL.SDL_Scancode.SDL_SCANCODE_EQUALS,
        Minus = SDL.SDL_Scancode.SDL_SCANCODE_MINUS,
        Tilde = SDL.SDL_Scancode.SDL_SCANCODE_GRAVE,
        LeftBracket = SDL.SDL_Scancode.SDL_SCANCODE_LEFTBRACKET,
        RightBracket = SDL.SDL_Scancode.SDL_SCANCODE_RIGHTBRACKET,
        
        // --- Text edition group.
        Home = SDL.SDL_Scancode.SDL_SCANCODE_HOME,
        End = SDL.SDL_Scancode.SDL_SCANCODE_END,
        Insert = SDL.SDL_Scancode.SDL_SCANCODE_INSERT,
        Delete = SDL.SDL_Scancode.SDL_SCANCODE_DELETE,
        PageUp = SDL.SDL_Scancode.SDL_SCANCODE_PAGEUP,
        PageDown = SDL.SDL_Scancode.SDL_SCANCODE_PAGEDOWN,
        Backspace = SDL.SDL_Scancode.SDL_SCANCODE_BACKSPACE,
        Tab = SDL.SDL_Scancode.SDL_SCANCODE_TAB,
        Left = SDL.SDL_Scancode.SDL_SCANCODE_LEFT,
        Right = SDL.SDL_Scancode.SDL_SCANCODE_RIGHT,
        Up = SDL.SDL_Scancode.SDL_SCANCODE_UP,
        Down = SDL.SDL_Scancode.SDL_SCANCODE_DOWN,
        
        // --- Keyboard state group.
        LeftShift = SDL.SDL_Scancode.SDL_SCANCODE_LSHIFT,
        RightShift = SDL.SDL_Scancode.SDL_SCANCODE_RSHIFT,
        LeftControl = SDL.SDL_Scancode.SDL_SCANCODE_LCTRL,
        RightControl = SDL.SDL_Scancode.SDL_SCANCODE_RCTRL,
        LeftSuper = SDL.SDL_Scancode.SDL_SCANCODE_LGUI,
        RightSuper = SDL.SDL_Scancode.SDL_SCANCODE_RGUI,
        LeftAlt = SDL.SDL_Scancode.SDL_SCANCODE_LALT,
        RightAlt = SDL.SDL_Scancode.SDL_SCANCODE_RALT,
        ApplicationMenu = SDL.SDL_Scancode.SDL_SCANCODE_APPLICATION,
        CapsLock = SDL.SDL_Scancode.SDL_SCANCODE_CAPSLOCK,
        
        // --- Application control group.
        ApplicationControlBack = SDL.SDL_Scancode.SDL_SCANCODE_AC_BACK,
        ApplicationControlBookmarks = SDL.SDL_Scancode.SDL_SCANCODE_AC_BOOKMARKS,
        ApplicationControlForward = SDL.SDL_Scancode.SDL_SCANCODE_AC_FORWARD,
        ApplicationControlHome = SDL.SDL_Scancode.SDL_SCANCODE_AC_HOME,
        ApplicationControlRefresh = SDL.SDL_Scancode.SDL_SCANCODE_AC_REFRESH,
        ApplicationControlSearch = SDL.SDL_Scancode.SDL_SCANCODE_AC_SEARCH,
        ApplicationControlStop = SDL.SDL_Scancode.SDL_SCANCODE_AC_STOP,
        ApplicationControlErase = SDL.SDL_Scancode.SDL_SCANCODE_ALTERASE,
        ApplicationControlComputer = SDL.SDL_Scancode.SDL_SCANCODE_COMPUTER,
        
        Clear = SDL.SDL_Scancode.SDL_SCANCODE_CLEAR,
        ClearAgain = SDL.SDL_Scancode.SDL_SCANCODE_CLEARAGAIN,
        Redo = SDL.SDL_Scancode.SDL_SCANCODE_AGAIN,
        Undo = SDL.SDL_Scancode.SDL_SCANCODE_UNDO,
        Cut = SDL.SDL_Scancode.SDL_SCANCODE_CUT,
        Copy = SDL.SDL_Scancode.SDL_SCANCODE_COPY,
        Paste = SDL.SDL_Scancode.SDL_SCANCODE_PASTE,
        
        // --- Audio control group.
        AudioMute = SDL.SDL_Scancode.SDL_SCANCODE_AUDIOMUTE,
        AudioNext = SDL.SDL_Scancode.SDL_SCANCODE_AUDIONEXT,
        AudioPlay = SDL.SDL_Scancode.SDL_SCANCODE_AUDIOPLAY,
        AudioPrev = SDL.SDL_Scancode.SDL_SCANCODE_AUDIOPREV,
        AudioStop = SDL.SDL_Scancode.SDL_SCANCODE_AUDIOSTOP,
        
        Mute = SDL.SDL_Scancode.SDL_SCANCODE_MUTE,
        VolumeUp = SDL.SDL_Scancode.SDL_SCANCODE_VOLUMEUP,
        VolumeDown = SDL.SDL_Scancode.SDL_SCANCODE_VOLUMEDOWN,
    }
}