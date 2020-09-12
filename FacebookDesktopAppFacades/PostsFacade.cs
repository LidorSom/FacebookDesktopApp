using FacebookWrapper.ObjectModel;

namespace FacebookDesktopAppFacades
{
    public delegate void UpdatePostDelegate(FacebookObjectCollection<Post> i_Post);

    public class PostsFacade
    {
        private readonly FacadesSharedData r_FacadesSharedData =
            FacadesSharedData.GetFacadesSharedDataInstance();

        public event UpdatePostDelegate UpdatingPosts;

        public void FetchPosts()
        {
            UpdatingPosts?.Invoke(r_FacadesSharedData.FacebookUser.Posts);
        }
    }
}
