using Phone_Ev3_RSTORM_JoyStick.Resources;

namespace Phone_Ev3_RSTORM_JoyStick
{
    /// <summary>
    /// Provides access to string resources.
    /// </summary>
    public class LocalizedStrings
    {
        private static AppResources _localizedResources = new AppResources();

        public AppResources LocalizedResources { get { return _localizedResources; } }
    }
}