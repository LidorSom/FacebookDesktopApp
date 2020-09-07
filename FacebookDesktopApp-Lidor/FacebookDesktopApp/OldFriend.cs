namespace FacebookDesktopApp
{
    public class OldFriend
    {
        public string Id { get; }

        public string Name { get; }

        public string ProfilePictureUrl { get; }

        public OldFriend(string i_Id, string i_Name, string i_ProfilePictureUrl)
        {
            Id = i_Id;
            Name = i_Name;
            ProfilePictureUrl = i_ProfilePictureUrl;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
