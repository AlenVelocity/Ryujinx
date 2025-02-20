using Ryujinx.Graphics.OpenGL.Image;
using System;

namespace Ryujinx.Graphics.OpenGL.Effects
{
    internal interface IPostProcessingEffect :  IDisposable
    {
        const int LocalGroupSize = 64;
        void Initialize();
        TextureView Run(TextureView view, int width, int height);
    }
}