**Description**

skia does not render [svg](https://github.com/hulluP/SkiaSVGIssue/blob/master/debugSVG/demo.svg) correctly. 

**Code**

            SKCanvas canvas = args.Surface.Canvas;
            canvas.Clear();
            using (Stream stream = GetType().Assembly.GetManifestResourceStream("debugSVG.demo.svg"))
            {
                SKSvg svg = new SKSvg();
                svg.Load(stream);
                canvas.DrawPicture(svg.Picture);
            }
**Expected Behavior**

expected would be that following [https://github.com/hulluP/SkiaSVGIssue/blob/master/debugSVG/demo.svg](https://github.com/hulluP/SkiaSVGIssue/blob/master/debugSVG/demo.svg)

**Actual Behavior**

when the image loads it is missing the last path 
![Screenshot 2019-10-01 at 10 23 06](https://user-images.githubusercontent.com/46395952/65950560-962abf80-e43e-11e9-9af8-954df23f32ec.png)

**Basic Information**

- Version with issue:  1.68
- Last known good version: --
- IDE:  Visual Studio for Mac 
- Platform Target Frameworks: 
  - Android: 28
  - iOS:  13
 
**Screenshots**

see above

**Reproduction Link**

git: https://github.com/hulluP/SkiaSVGIssue

