# WpfAboutView [![NuGet](https://img.shields.io/nuget/v/WpfAboutView.svg)](https://www.nuget.org/packages/WpfAboutView)

About controls for WPF with app info and credits.

```xaml
<wpfAboutView:AboutView AppIconSource="pack://application:,,,/ExampleApp.ico">
    <wpfAboutView:AboutView.Credits>

        <wpfAboutView:Credit Name="WpfAboutView"
                             Author="Daniel Chalmers"
                             Website="https://github.com/danielchalmers/WpfAboutView"
                             LicenseText="{x:Static properties:Resources.MyLicense}" />

        <wpfAboutView:Credit Name="Example Credit"
                             Author="Example Author"
                             Website="http://example.com"
                             LicenseText="{x:Static properties:Resources.MyLicense}" />

        <wpfAboutView:Credit Name="Credit without website"
                             Author="Another Author"
                             LicenseText="{x:Static properties:Resources.MyLicense}" />

        <wpfAboutView:Credit Name="Credit without license"
                             Author="Test Author"
                             Website="http://test.com" />

        <wpfAboutView:Credit Name="No website or license" Author="Test Author" />

    </wpfAboutView:AboutView.Credits>
</wpfAboutView:AboutView>
```

![Example screenshot](https://user-images.githubusercontent.com/7112040/165429932-00d7512c-655c-4071-bce7-9eb81d1a8fb7.png)

See the ExampleApp folder for full demo.
