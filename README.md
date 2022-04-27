# WpfAboutView

WPF About controls with app info and credits.

[![NuGet](https://img.shields.io/nuget/v/WpfAboutView.svg)](https://www.nuget.org/packages/WpfAboutView)

## Usage

```xaml
<wpfAboutView:AboutView AppIconSource="pack://application:,,,/ExampleApp.ico">
    <wpfAboutView:AboutView.Credits>

        <wpfAboutView:Credit Name="WpfAboutView"
                             Author="Daniel Chalmers"
                             Website="https://github.com/danielchalmers/WpfAboutView"
                             LicenseText="{x:Static properties:Resources.WpfAboutView_License}" />

        <wpfAboutView:Credit Name="Example Credit"
                             Author="Example Author"
                             Website="http://example.com"
                             LicenseText="{x:Static properties:Resources.WpfAboutView_License}" />

        <wpfAboutView:Credit Name="Credit without website"
                             Author="Another Author"
                             LicenseText="{x:Static properties:Resources.WpfAboutView_License}" />

        <wpfAboutView:Credit Name="Credit without license"
                             Author="Test Author"
                             Website="http://test.com" />

        <wpfAboutView:Credit Name="No website or license" Author="Test Author" />

    </wpfAboutView:AboutView.Credits>
</wpfAboutView:AboutView>
```

See the ExampleApp folder for a full example.

## License

MIT
