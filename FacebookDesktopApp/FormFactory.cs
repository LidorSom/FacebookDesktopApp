using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookDesktopApp
{
    public enum eMenuChoice
    {
        Menu = 0,
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
        public static Form GetForm(eMenuChoice i_MenuChoice)
        {
            Form toReturnForm;

            switch (i_MenuChoice)
            {
                case eMenuChoice.Menu:
                    toReturnForm = new AppMenuForm();
                    break;
                case eMenuChoice.profile:
                    toReturnForm = new MyProfileForm();
                    break;
                case eMenuChoice.friends:
                    toReturnForm = new FriendsForm();
                    break;
                case eMenuChoice.photos:
                    toReturnForm = new PhotosForm();
                    break;
                case eMenuChoice.oldFriends:
                    toReturnForm = new OldFriendsForm();
                    break;
                case eMenuChoice.likeCounter:
                    toReturnForm = new LikesCounterForm();
                    break;
                case eMenuChoice.checkIns:
                    toReturnForm = new CheckInForm();
                    break;
                case eMenuChoice.posts:
                    toReturnForm = new PostsForm();
                    break;
                case eMenuChoice.privacy:
                    toReturnForm = new PrivacyForm();

                    break;

                default:
                    throw new ArgumentException("not a valid choice");
            }

            return toReturnForm;
        }
    }
}
