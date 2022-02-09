using System.Reflection;
using WindowPin.Code.Model;

namespace WindowPin.Code.Service
{
    public class MainConfigService
    {
        private string ConfigPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public MainConfig MainConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        private static MainConfigService minConfigService;
        public static MainConfigService CreateInstance()
        {
            if (minConfigService == null)
            {
                minConfigService = new MainConfigService();
            }
            return minConfigService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="configPath"></param>
        public MainConfigService()
        {
            ConfigPath = CommonConst.MAINCONFIG_PATH;
            Re();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public MainConfig Re()
        {
            MainConfig = Newtonsoft.Json.JsonConvert.DeserializeObject<MainConfig>(GetConfigContent());
            if (MainConfig == null)
                MainConfig = new MainConfig();
            if (MainConfig.WindowForms == null)
                MainConfig.WindowForms = new List<WindowFormConfig>();

            return MainConfig;
        }

        public void Update()
        {
            SaveConfigContent(Newtonsoft.Json.JsonConvert.SerializeObject(MainConfig,Newtonsoft.Json.Formatting.Indented));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string GetConfigContent()
        {
            return File.ReadAllText(ConfigPath);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        private void SaveConfigContent(string s)
        {
            File.WriteAllText(ConfigPath, s);
        }
    }
}