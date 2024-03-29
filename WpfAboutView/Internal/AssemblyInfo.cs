﻿using System;
using System.IO;
using System.Reflection;

namespace WpfAboutView
{
    internal static class AssemblyInfo
    {
        /// <summary>
        /// Returns the assembly's Company attribute, or <c>null</c> if one isn't supplied.
        /// </summary>
        internal static string GetCompany(this Assembly assembly) =>
           assembly.GetCustomAttribute<AssemblyCompanyAttribute>()?.Company;

        /// <summary>
        /// Returns the assembly's Copyright attribute, or <c>null</c> if one isn't supplied.
        /// </summary>
        internal static string GetCopyright(this Assembly assembly) =>
           assembly.GetCustomAttribute<AssemblyCopyrightAttribute>()?.Copyright;

        /// <summary>
        /// Returns the assembly's Description attribute, or <c>null</c> if one isn't supplied.
        /// </summary>
        internal static string GetDescription(this Assembly assembly) =>
           assembly.GetCustomAttribute<AssemblyDescriptionAttribute>()?.Description;

        /// <summary>
        /// Returns the assembly's Title attribute, or <c>null</c> if one isn't supplied.
        /// </summary>
        internal static string GetProduct(this Assembly assembly) =>
           assembly.GetCustomAttribute<AssemblyProductAttribute>()?.Product;

        /// <summary>
        /// Returns the assembly's Title attribute, or <c>null</c> if one isn't supplied.
        /// </summary>
        internal static string GetTitle(this Assembly assembly) =>
           assembly.GetCustomAttribute<AssemblyTitleAttribute>()?.Title;

        /// <summary>
        /// Returns the assembly's Version attribute, or <c>null</c> if one isn't supplied.
        /// </summary>
        internal static Version GetVersion(this Assembly assembly) =>
           assembly.GetName()?.Version;
    }
}