namespace Bb.Models
{
    public class Packages : List<Package>
    {

        public static implicit operator Packages(Package[] packages)
        {
            var p = new Packages();
            p.AddRange(packages);
            return p;
        }

    }

}
