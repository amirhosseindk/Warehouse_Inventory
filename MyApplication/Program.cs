using DevExpress.LookAndFeel.Design;
using DevExpress.XtraRichEdit.Model;
using System.Globalization;                  // ADD \\

namespace MyApplication
{
    internal static class Program
    {
        public static bool CheckLogin = false;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            #region For One Language

            //CultureInfo.CurrentCulture = new CultureInfo("fa-IR", false);

            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("fa-IR");

            //Application.CurrentInputLanguage = InputLanguage
            //    .FromCulture(CultureInfo.CreateSpecificCulture("fa-IR"));

            #endregion /For One Language


            #region For Multi Language

            int CurrentCulture = Properties.Settings.Default.CurrentCulture;

            switch ((ApplicationSettings.Languages)CurrentCulture)
            {
                case ApplicationSettings.Languages.English:
                    {
                        ApplicationSettings.CurrentCulture =
                            ApplicationSettings.Languages.English;

                        Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

                        Application.CurrentInputLanguage = InputLanguage
                            .FromCulture(CultureInfo.CreateSpecificCulture("en-US"));

                        break;
                    }
                case ApplicationSettings.Languages.Farsi:
                    {
                        ApplicationSettings.CurrentCulture =
                            ApplicationSettings.Languages.Farsi;

                        Thread.CurrentThread.CurrentUICulture = new CultureInfo("fa-IR");

                        Application.CurrentInputLanguage = InputLanguage
                            .FromCulture(CultureInfo.CreateSpecificCulture("fa-IR"));

                        break;
                    }
            }

            #endregion / For Multi Language


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());

            if (CheckLogin)
            {
                Application.Run(new MainForm());
            }

        }
    }
}