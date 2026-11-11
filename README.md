# AaTurpin.Maui.MaterialIcons

Complete **Google Material Icons** library for **.NET MAUI** featuring all **2,235 icons** across all **4 official styles** (`Filled`, `Outlined`, `Rounded`, and `Sharp`), strongly-typed `Icons` constants generated via a C# Incremental Source Generator, and one-line `.UseMaterialIcons()` font registration.

---

## Features

- **All 2,235 Google Material Icons**: Strongly-typed constants in `Icons` matching Flutter's `Icons.*` naming (`Icons.Settings`, `Icons.DarkMode`, `Icons.AccountBalanceWallet`, etc.).
- **All 4 Official Styles Included**:
  - `IconStyle.Filled` *(default)* — `Icons.FontFamily` / `Icons.FontFamilyFilled`
  - `IconStyle.Outlined` — `Icons.FontFamilyOutlined`
  - `IconStyle.Rounded` — `Icons.FontFamilyRounded`
  - `IconStyle.Sharp` — `Icons.FontFamilySharp`
- **Zero Manual Font Copying**: All 4 font files are embedded inside the library and registered in a single `.UseMaterialIcons()` call.

---

## Quick Start

### 1. Register in `MauiProgram.cs`

Call `.UseMaterialIcons()` on your `MauiAppBuilder`:

```csharp
using AaTurpin.Maui.MaterialIcons;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMaterialIcons(); // Registers Filled, Outlined, Rounded & Sharp fonts

        return builder.Build();
    }
}
```

### 2. Add the XAML Namespace

```xml
xmlns:mi="clr-namespace:AaTurpin.Maui.MaterialIcons;assembly=AaTurpin.Maui.MaterialIcons"
```

### 3. Use `mi:Icons` in XAML

```xml
<!-- Using FontImageSource -->
<Image>
    <Image.Source>
        <FontImageSource Glyph="{x:Static mi:Icons.AccountBalance}"
                         FontFamily="{x:Static mi:Icons.FontFamilyOutlined}"
                         Size="24"
                         Color="{AppThemeBinding Light=#0F172A, Dark=#F8FAFC}" />
    </Image.Source>
</Image>

<!-- Using Label -->
<Label Text="{x:Static mi:Icons.Settings}"
       FontFamily="{x:Static mi:Icons.FontFamily}"
       FontSize="24" />
```
