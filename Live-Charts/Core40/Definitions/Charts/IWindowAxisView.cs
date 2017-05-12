namespace LiveCharts.Definitions.Charts
{
    /// <summary>
    /// 
    /// </summary>
    public interface IWindowAxisView : IAxisView
    {
        /// <summary>
        /// set Selected windows
        /// </summary>
        /// <param name="window"></param>
        void SetSelectedWindow(IAxisWindow window);
    }
}