using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktopAppFacades
{

    public delegate void UpdateLikesDataDelegate(Dictionary<User, int> i_LikesDictionary);
    public class LikeCounterFacade
    {
        private FacadesShardData mFacadesShardData = FacadesShardData.GetFacadesShardDataInstance();
        public event UpdateLikesDataDelegate UpdateLikesData;
        public void FetchLikesData()
        {
        
        Dictionary<User, int> likesDictionary = new Dictionary<User, int>(mFacadesShardData.FacebookUser.Friends.Count);

            foreach (User friend in mFacadesShardData.FacebookUser.Friends)
            {
                likesDictionary.Add(friend, 0);
            }

            try
            {
                updateDictionaryWithPosts(likesDictionary);
                updateDictionaryWithPhotos(likesDictionary);
            }
            catch (Exception exception) //// we catch general exception in order to display something in this feature
            {
            }
            finally
            {
                UpdateLikesData(likesDictionary); //// In Finally because we want to display Something
            }
        }

        private void updateDictionaryWithPhotos(Dictionary<User, int> i_LikesDictionary)
        {
            foreach (Album album in mFacadesShardData.FacebookUser.Albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    foreach (User likeUser in photo.LikedBy)
                    {
                        updateDictionaryWithLikeUser(i_LikesDictionary, likeUser);
                    }
                }
            }
        }

        private void updateDictionaryWithPosts(Dictionary<User, int> i_LikesDictionary)
        {
            foreach (var post in mFacadesShardData.FacebookUser.Posts)
            {
                foreach (User likedUser in post.LikedBy)
                {
                    updateDictionaryWithLikeUser(i_LikesDictionary, likedUser);
                }
            }
        }

        private void updateDictionaryWithLikeUser(Dictionary<User, int> i_LikesDictionary, User i_LikeUser)
        {
            if (i_LikesDictionary.ContainsKey(i_LikeUser))
            {
                i_LikesDictionary[i_LikeUser]++;
            }
            else
            {
                i_LikesDictionary.Add(i_LikeUser, 1);
            }
        }
    }
}
