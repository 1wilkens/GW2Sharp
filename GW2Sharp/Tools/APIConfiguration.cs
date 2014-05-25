using System;

namespace MrFloya.GW2Sharp.Tools
{
    internal class APIConfiguration : IEquatable<APIConfiguration>
    {
        internal APIVersion Version { get; set; }
        internal APILanguage Language { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as APIConfiguration);
        }

        public bool Equals(APIConfiguration other)
        {
            if (other == null)
                return false;

            return other.Version == Version && other.Language == Language;
        }

        public static bool operator ==(APIConfiguration a, APIConfiguration b)
        {
            return !ReferenceEquals(a, null) ? a.Equals(b) : ReferenceEquals(b, null);  // null == null = true per convention
        }

        public static bool operator !=(APIConfiguration a, APIConfiguration b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return (int)Version;
        }
    }
}