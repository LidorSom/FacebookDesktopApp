using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookDesktopApp
{
    enum eMenuChoice
    {
        profile=1,
        friends=2,
        posts=3,
        pokes=4,
        checkIns=5,
        photos=6,
        privacy=7,
        likeCounter=8
    }
    public class FormFactory
    {


        public static Form GetForm(eMenuChoice i_MenuChoice)
        {
            Form toReturnForm;
            switch (i_MenuChoice)
            {
                //case eMenuChoice.profile:
                //    toReturnForm = ;
                //    break;
                //case eMenuChoice.friends:
                //    toReturnForm=;
                //    break;
                //case eMenuChoice.photos:
                //    toReturnForm=;
                //    break;
                //case eMenuChoice.pokes:
                //    toReturnForm=;
                //    break;
                //case eMenuChoice.checkIns:
                //    toReturnForm=;
                //    break;
                //case eMenuChoice.posts:
                //    toReturnForm=;
                //    break;
                //case eMenuChoice.privacy:
                //    toReturnForm=;
                //    break;
                //case eMenuChoice.likeCounter:
                //    toReturnForm=;
                //    break;

                default:
                    throw new ArgumentException("not a valid choice");

            }

            return toReturnForm;
        }
    }
}
