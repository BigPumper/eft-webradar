using SkiaSharp;

namespace AncientMountain.Managed.Skia
{
    internal static class SKPaints
    {
        #region Radar Paints

        public static SKPaint PaintLocalPlayer { get; } = new()
        {
            Color = SKColors.Green,
            StrokeWidth = 3,
            Style = SKPaintStyle.Stroke,
            IsAntialias = true,
            FilterQuality = SKFilterQuality.Medium
        };

        public static SKPaint TextLocalPlayer { get; } = new()
        {
            SubpixelText = true,
            Color = SKColors.Green,
            IsStroke = false,
            TextSize = 12,
            TextEncoding = SKTextEncoding.Utf8,
            IsAntialias = true,
            Typeface = CustomFonts.SKFontFamilyRegular,
            FilterQuality = SKFilterQuality.Medium
        };

        public static SKPaint PaintBoss { get; } = new()
        {
            Color = SKColors.Fuchsia,
            StrokeWidth = 3,
            Style = SKPaintStyle.Stroke,
            IsAntialias = true,
            FilterQuality = SKFilterQuality.High
        };

        public static SKPaint TextBoss { get; } = new()
        {
            SubpixelText = true,
            Color = SKColors.Fuchsia,
            IsStroke = false,
            TextSize = 12,
            TextEncoding = SKTextEncoding.Utf8,
            IsAntialias = true,
            Typeface = CustomFonts.SKFontFamilyRegular,
            FilterQuality = SKFilterQuality.High
        };

        public static SKPaint PaintBTR { get; } = new()
        {
            Color = SKColors.Orange,
            StrokeWidth = 3,
            Style = SKPaintStyle.Stroke,
            IsAntialias = true,
            FilterQuality = SKFilterQuality.High
        };

        public static SKPaint TextBTR { get; } = new()
        {
            SubpixelText = true,
            Color = SKColors.Orange,
            IsStroke = false,
            TextSize = 12,
            TextEncoding = SKTextEncoding.Utf8,
            IsAntialias = true,
            Typeface = CustomFonts.SKFontFamilyRegular,
            FilterQuality = SKFilterQuality.High
        };

        public static SKPaint PaintUSEC { get; } = new()
        {
            Color = SKColors.CadetBlue,
            StrokeWidth = 3,
            Style = SKPaintStyle.Stroke,
            IsAntialias = true,
            FilterQuality = SKFilterQuality.High
        };

        public static SKPaint TextUSEC { get; } = new()
        {
            SubpixelText = true,
            Color = SKColors.CadetBlue,
            IsStroke = false,
            TextSize = 12,
            TextEncoding = SKTextEncoding.Utf8,
            IsAntialias = true,
            Typeface = CustomFonts.SKFontFamilyRegular,
            FilterQuality = SKFilterQuality.High
        };

        public static SKPaint PaintTeammate { get; } = new()
        {
            Color = SKColors.LimeGreen,
            StrokeWidth = 3,
            Style = SKPaintStyle.Stroke,
            IsAntialias = true,
            FilterQuality = SKFilterQuality.Medium
        };

        public static SKPaint TextTeammate { get; } = new()
        {
            SubpixelText = true,
            Color = SKColors.LimeGreen,
            IsStroke = false,
            TextSize = 12,
            TextEncoding = SKTextEncoding.Utf8,
            IsAntialias = true,
            Typeface = CustomFonts.SKFontFamilyRegular,
            FilterQuality = SKFilterQuality.Medium
        };

        public static SKPaint PaintPlayer { get; } = new()
        {
            Color = SKColors.Red,
            StrokeWidth = 3,
            Style = SKPaintStyle.Stroke,
            IsAntialias = true,
            FilterQuality = SKFilterQuality.Medium
        };

        public static SKPaint TextPlayer { get; } = new()
        {
            SubpixelText = true,
            Color = SKColors.Red,
            IsStroke = false,
            TextSize = 12,
            TextEncoding = SKTextEncoding.Utf8,
            IsAntialias = true,
            Typeface = CustomFonts.SKFontFamilyRegular,
            FilterQuality = SKFilterQuality.Medium
        };
        public static SKPaint PaintPlayerScav { get; } = new()
        {
            Color = SKColors.White,
            StrokeWidth = 3,
            Style = SKPaintStyle.Stroke,
            IsAntialias = true,
            FilterQuality = SKFilterQuality.Medium
        };

        public static SKPaint TextPlayerScav { get; } = new()
        {
            SubpixelText = true,
            Color = SKColors.White,
            IsStroke = false,
            TextSize = 12,
            TextEncoding = SKTextEncoding.Utf8,
            IsAntialias = true,
            Typeface = CustomFonts.SKFontFamilyRegular,
            FilterQuality = SKFilterQuality.Medium
        };
        public static SKPaint PaintBot { get; } = new()
        {
            Color = SKColors.Yellow,
            StrokeWidth = 3,
            Style = SKPaintStyle.Stroke,
            IsAntialias = true,
            FilterQuality = SKFilterQuality.Medium
        };

        public static SKPaint TextBot { get; } = new()
        {
            SubpixelText = true,
            Color = SKColors.Yellow,
            IsStroke = false,
            TextSize = 12,
            TextEncoding = SKTextEncoding.Utf8,
            IsAntialias = true,
            Typeface = CustomFonts.SKFontFamilyRegular,
            FilterQuality = SKFilterQuality.Medium
        };

        public static SKPaint PaintDeathMarker { get; } = new()
        {
            Color = SKColors.Black,
            StrokeWidth = 3,
            Style = SKPaintStyle.Stroke,
            IsAntialias = true,
            FilterQuality = SKFilterQuality.Medium
        };

        #endregion

        #region Misc Paints

        public static SKPaint PaintBitmap { get; } = new()
        {
            IsAntialias = true,
            FilterQuality = SKFilterQuality.Medium
        };

        public static SKPaint TextRadarStatus { get; } = new()
        {
            SubpixelText = true,
            Color = SKColors.Red,
            IsStroke = false,
            TextSize = 48,
            TextEncoding = SKTextEncoding.Utf8,
            IsAntialias = true,
            Typeface = CustomFonts.SKFontFamilyRegular,
            TextAlign = SKTextAlign.Left
        };

        public static SKPaint TextOutline { get; } = new()
        {
            SubpixelText = true,
            IsAntialias = true,
            Color = SKColors.Black,
            TextSize = 12f,
            IsStroke = true,
            StrokeWidth = 2f,
            Style = SKPaintStyle.Stroke,
            Typeface = CustomFonts.SKFontFamilyRegular
        };

        /// <summary>
        /// Only utilize this paint on the Radar UI Thread. StrokeWidth is modified prior to each draw call.
        /// *NOT* Thread safe to use!
        /// </summary>
        public static SKPaint ShapeOutline { get; } = new()
        {
            Color = SKColors.Black,
            /*StrokeWidth = ??,*/ // Compute before use
            Style = SKPaintStyle.Stroke,
            IsAntialias = true,
            FilterQuality = SKFilterQuality.Medium
        };

        #endregion
    }
}