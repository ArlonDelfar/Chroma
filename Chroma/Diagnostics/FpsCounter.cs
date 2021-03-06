﻿using Chroma.Natives.SDL;

namespace Chroma.Diagnostics
{
    internal class FpsCounter
    {
        private uint _lastTime;
        private uint _frameCount;

        public float FPS { get; private set; }

        internal FpsCounter()
        {
            _lastTime = SDL2.SDL_GetTicks();
        }

        internal void Update()
        {
            var currentTime = SDL2.SDL_GetTicks();

            if (currentTime - _lastTime > 1000)
            {
                FPS = _frameCount;

                _lastTime = currentTime;
                _frameCount = 0;
            }

            _frameCount++;
        }
    }
}
