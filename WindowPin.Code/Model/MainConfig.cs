namespace WindowPin.Code.Model
{
    public class MainConfig
    {
        /// <summary>
        /// 
        /// </summary>
        public List<WindowFormConfig> WindowForms { get; set; }
    }

    public class WindowFormConfig
    {
        /// <summary>
        /// 路径
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// 是否固定
        /// </summary>
        public bool IsFix { get; set; }

        private double opacity;
        /// <summary>
        /// 透明度
        /// </summary>
        public double Opacity { get => opacity == 0 ? 1 : opacity; set => opacity = value; }

        public int Top { get; set; }

        public int Left { get; set; }

        private int height;
        /// <summary>
        /// 
        /// </summary>
        public int Height { get => height == 0 ? 100 : height; set => height = value; }

        private int width;
        /// <summary>
        /// 
        /// </summary>
        public int Width { get => width == 0 ? 150 : width; set => width = value; }
    }
}