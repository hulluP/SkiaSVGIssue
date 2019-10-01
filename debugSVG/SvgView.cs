using System;
using System.IO;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace debugSVG
{
    public class SvgView : ContentPage
    {
        private readonly SKCanvasView _canvasView = new SKCanvasView();

        public SvgView()
        {
        }
        public Page GetMainPage()
        {

            _canvasView.PaintSurface += CanvasViewOnPaintSurface;
            Content = _canvasView;
            return this;
        }
        private void CanvasViewOnPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            SKCanvas canvas = args.Surface.Canvas;
            canvas.Clear();
            using (Stream stream = GetType().Assembly.GetManifestResourceStream("debugSVG.demo.svg"))
            {
                SKSvg svg = new SKSvg();
                svg.Load(stream);
                canvas.DrawPicture(svg.Picture);
            }

        }
    }
}
