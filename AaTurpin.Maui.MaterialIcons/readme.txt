===============================================================================
  AaTurpin.Maui.MaterialIcons — Quick Start Guide
===============================================================================

Thank you for installing AaTurpin.Maui.MaterialIcons!
All 2,235 Google Material Icons (Filled, Outlined, Rounded, and Sharp) are now
bundled into your .NET MAUI project.

-------------------------------------------------------------------------------
STEP 1: Register the Material Icon fonts in MauiProgram.cs
-------------------------------------------------------------------------------
Open MauiProgram.cs, add the namespace, and call .UseMaterialIcons() on your
MauiAppBuilder:

    using AaTurpin.Maui.MaterialIcons;

    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMaterialIcons(); // <-- Registers Filled, Outlined, Rounded & Sharp fonts

            return builder.Build();
        }
    }

-------------------------------------------------------------------------------
STEP 2: Add the XML Namespace in your XAML page or shell
-------------------------------------------------------------------------------
Add the xmlns declaration to the root of your ContentPage or Shell:

    xmlns:mi="clr-namespace:AaTurpin.Maui.MaterialIcons;assembly=AaTurpin.Maui.MaterialIcons"

-------------------------------------------------------------------------------
STEP 3: Use mi:Icons in XAML or C#
-------------------------------------------------------------------------------
1. With <FontImageSource> (on Image, Button, ImageButton, ToolbarItem, etc.):

    <Image>
        <Image.Source>
            <FontImageSource Glyph="{x:Static mi:Icons.Notifications}"
                             FontFamily="{x:Static mi:Icons.FontFamilyOutlined}"
                             Size="24"
                             Color="{AppThemeBinding Light=#0F172A, Dark=#F8FAFC}" />
        </Image.Source>
    </Image>

2. With <Label>:

    <Label Text="{x:Static mi:Icons.Settings}"
           FontFamily="{x:Static mi:Icons.FontFamily}"
           FontSize="24" />

3. Available FontFamily constants on mi:Icons:
   - mi:Icons.FontFamily         ("MaterialIconsRegular" - Filled default)
   - mi:Icons.FontFamilyFilled   ("MaterialIconsRegular")
   - mi:Icons.FontFamilyOutlined ("MaterialIconsOutlined")
   - mi:Icons.FontFamilyRounded  ("MaterialIconsRounded")
   - mi:Icons.FontFamilySharp    ("MaterialIconsSharp")
===============================================================================
