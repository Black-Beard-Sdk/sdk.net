namespace Bb.Models
{
    public class Package
    {

        public Package()
        {

        }

        public string Id { get; set; }

        public string Version { get; set; }


        public static implicit operator Package(string value)
        {
            return new Package() { Id = value };
        }

    }

}
