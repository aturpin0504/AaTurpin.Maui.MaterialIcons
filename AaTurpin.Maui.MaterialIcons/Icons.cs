using Microsoft.Maui.Hosting;

namespace AaTurpin.Maui.MaterialIcons;

/// <summary>
/// Google Material Icon visual styles.
/// <see cref="Filled"/> is the default style, matching Flutter's <c>Icons.*</c> default.
/// </summary>
public enum IconStyle
{
    /// <summary>Classic solid filled Material Icons (<c>MaterialIcons-Regular.ttf</c>). Default.</summary>
    Filled,

    /// <summary>Unfilled stroke outline Material Icons (<c>MaterialIconsOutlined-Regular.otf</c>).</summary>
    Outlined,

    /// <summary>Soft rounded-corner Material Icons (<c>MaterialIconsRound-Regular.otf</c>).</summary>
    Rounded,

    /// <summary>Crisp 90-degree sharp-corner Material Icons (<c>MaterialIconsSharp-Regular.otf</c>).</summary>
    Sharp
}

/// <summary>
/// <see cref="MauiAppBuilder"/> registration extensions for Google Material Icons.
/// </summary>
public static class MaterialIconsExtensions
{
    /// <summary>
    /// Registers all 4 Google Material Icon font styles (<c>Filled</c>, <c>Outlined</c>, <c>Rounded</c>, and <c>Sharp</c>)
    /// embedded in <c>AaTurpin.Maui.MaterialIcons</c>.
    /// </summary>
    public static MauiAppBuilder UseMaterialIcons(this MauiAppBuilder builder)
    {
        return builder.ConfigureFonts(fonts =>
        {
            fonts.AddEmbeddedResourceFont(typeof(Icons).Assembly, "MaterialIcons-Regular.ttf", Icons.FontFamilyFilled);
            fonts.AddEmbeddedResourceFont(typeof(Icons).Assembly, "MaterialIconsOutlined-Regular.otf", Icons.FontFamilyOutlined);
            fonts.AddEmbeddedResourceFont(typeof(Icons).Assembly, "MaterialIconsRound-Regular.otf", Icons.FontFamilyRounded);
            fonts.AddEmbeddedResourceFont(typeof(Icons).Assembly, "MaterialIconsSharp-Regular.otf", Icons.FontFamilySharp);
        });
    }
}

/// <summary>
/// Flutter-style Google Material Icons catalog.
/// All 2,235 icon glyph constants are generated at compile time into this partial class
/// by <c>MaterialIconsGenerator</c> from <c>Fonts/MaterialIcons-Regular.codepoints</c>.
/// </summary>
public static partial class Icons
{
    /// <summary>Default font family alias (<see cref="IconStyle.Filled"/>).</summary>
    public const string FontFamily = FontFamilyFilled;

    /// <summary>Filled Material Icons font family alias (<c>MaterialIcons-Regular.ttf</c>).</summary>
    public const string FontFamilyFilled = "MaterialIconsRegular";

    /// <summary>Outlined Material Icons font family alias (<c>MaterialIconsOutlined-Regular.otf</c>).</summary>
    public const string FontFamilyOutlined = "MaterialIconsOutlined";

    /// <summary>Rounded Material Icons font family alias (<c>MaterialIconsRound-Regular.otf</c>).</summary>
    public const string FontFamilyRounded = "MaterialIconsRounded";

    /// <summary>Sharp Material Icons font family alias (<c>MaterialIconsSharp-Regular.otf</c>).</summary>
    public const string FontFamilySharp = "MaterialIconsSharp";

    /// <summary>Resolves the registered MAUI font family alias for the specified <see cref="IconStyle"/>.</summary>
    public static string GetFontFamily(IconStyle style = IconStyle.Filled) => style switch
    {
        IconStyle.Outlined => FontFamilyOutlined,
        IconStyle.Rounded => FontFamilyRounded,
        IconStyle.Sharp => FontFamilySharp,
        _ => FontFamilyFilled
    };
}
