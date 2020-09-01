using System;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Drawing;

namespace FacebookDesktopApp
{
    public class ApplicationSettings
    {
        private static readonly string sr_FileName;
        private static readonly object sr_ToLockObject;
        private static ApplicationSettings s_ApplicationSettingInstance;

        public static ApplicationSettings ApplicationSettingsInstance
        {
            get
            {
                if (s_ApplicationSettingInstance == null)
                {
                    lock (sr_ToLockObject)
                    {
                        if (s_ApplicationSettingInstance == null)
                        {
                            s_ApplicationSettingInstance = LoadFromFileOrDefault();
                        }
                    }
                }

                return s_ApplicationSettingInstance;
            }
        }

        public bool AutoLogin { get; set; }

        public Size LastWindowSize { get; set; }

        public FormWindowState LastWindowState { get; set; }

        public Point LastWindowLocation { get; set; }

        public string AccessToken { get; set; }

        static ApplicationSettings()
        {
            sr_FileName = Application.ExecutablePath + ".settings.xml";
            sr_ToLockObject = new object();
        }

        public static ApplicationSettings LoadFromFileOrDefault()
        {
            ApplicationSettings loadedThis = null;

            if (File.Exists(sr_FileName))
            {
                using (FileStream stream = new FileStream(sr_FileName, FileMode.OpenOrCreate))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(ApplicationSettings));
                    loadedThis = (ApplicationSettings)serializer.Deserialize(stream);
                }
            }
            else
            {
                loadedThis = new ApplicationSettings()
                {
                    AutoLogin = false,
                    LastWindowSize = new Size(800, 500),
                    LastWindowState = FormWindowState.Normal,
                    LastWindowLocation = new Point(500, 250)
                };
            }

            return loadedThis;
        }

        private ApplicationSettings()
        {
        }

        public void SaveToFile()
        {
            FileStream stream;

            if (File.Exists(sr_FileName))
            {
                using (stream = new FileStream(sr_FileName, FileMode.Truncate))
                {
                    createAndRunSerializer(stream, typeof(ApplicationSettings), this);
                }
            }
            else
            {
                using (stream = new FileStream(sr_FileName, FileMode.Create))
                {
                    createAndRunSerializer(stream, typeof(ApplicationSettings), this);
                }
            }
        }

        private void createAndRunSerializer(Stream i_Stream, Type i_TypeToSerialize, object i_ToSerialize)
        {
            XmlSerializer serializer = new XmlSerializer(i_TypeToSerialize);
            serializer.Serialize(i_Stream, i_ToSerialize);
        }
    }
}