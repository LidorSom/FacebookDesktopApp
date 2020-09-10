using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookDesktopApp
{
    public enum eMenuChoice
    {
        profile = 1,
        friends = 2,
        oldFriends = 3,
        posts = 4,
        likeCounter = 5,
        checkIns = 6,
        photos = 7,
        privacy = 8,
    }

    public class FormFactory
    {

        public static Form GetForm(eMenuChoice i_MenuChoice, FacebookAppEngine i_AppEngine)
        {
            Form toReturnForm;

            switch (i_MenuChoice)
            {
                case eMenuChoice.profile:
                    toReturnForm = new MyProfileForm(i_AppEngine) ;
                    break;

                case eMenuChoice.friends:
                    toReturnForm = new FriendsForm(i_AppEngine);
                    break;
                case eMenuChoice.photos:
                    toReturnForm= new PhotosForm(i_AppEngine);
                    break;
                case eMenuChoice.oldFriends:
                    toReturnForm=new OldFriendsForm(i_AppEngine);
                    break;
                case eMenuChoice.likeCounter:
                    toReturnForm = new LikesCounterForm(i_AppEngine);
                    break;
                case eMenuChoice.checkIns:
                    toReturnForm= new CheckInForm(i_AppEngine);
                    break;
                case eMenuChoice.posts:
                    toReturnForm = new PostsForm(i_AppEngine);
                    break;
                case eMenuChoice.privacy:
                    toReturnForm = new PrivacyForm(i_AppEngine);
                    break;

                default:
                    throw new ArgumentException("not a valid choice");

            }

            return toReturnForm;
        }
    }
}
