using System;
using System.Collections.Generic;

namespace WpfAboutView
{
    public struct Credit : IEquatable<Credit>
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public Uri Website { get; set; }
        public string LicenseText { get; set; }

        public override bool Equals(object obj) =>
            obj is Credit && Equals((Credit)obj);

        public bool Equals(Credit other) =>
            Name == other.Name &&
            Author == other.Author &&
            EqualityComparer<Uri>.Default.Equals(Website, other.Website) &&
            LicenseText == other.LicenseText;

        public override int GetHashCode()
        {
            var hashCode = 2101635641;
            hashCode = (hashCode * -1521134295) + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = (hashCode * -1521134295) + EqualityComparer<string>.Default.GetHashCode(Author);
            hashCode = (hashCode * -1521134295) + EqualityComparer<Uri>.Default.GetHashCode(Website);
            hashCode = (hashCode * -1521134295) + EqualityComparer<string>.Default.GetHashCode(LicenseText);
            return hashCode;
        }

        public static bool operator ==(Credit left, Credit right) => left.Equals(right);

        public static bool operator !=(Credit left, Credit right) => !(left == right);
    }
}