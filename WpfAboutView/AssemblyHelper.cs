using System;
using System.IO;
using System.Reflection;

namespace WpfAboutView
{
    internal static class AssemblyHelper
    {
        internal static string GetCompany(this Assembly _assembly) => _assembly.GetCustomAttribute<AssemblyCompanyAttribute>().Company;

        internal static string GetCopyright(this Assembly _assembly) => _assembly.GetCustomAttribute<AssemblyCopyrightAttribute>().Copyright;

        internal static string GetDirectory(this Assembly _assembly) => Path.GetDirectoryName(_assembly.GetLocation());

        internal static string GetLocation(this Assembly _assembly) => _assembly.Location;

        internal static string GetTitle(this Assembly _assembly) => _assembly.GetCustomAttribute<AssemblyTitleAttribute>().Title;

        internal static Version GetVersion(this Assembly _assembly) => _assembly.GetName().Version;
    }
}