namespace FacebookDesktopApp
{
    interface IFacebookEngine
    {
        void Login();

        void Connect();

        string AccessToken { get; set; }

    }
}
