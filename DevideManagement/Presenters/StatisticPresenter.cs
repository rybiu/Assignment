using System.Collections.Generic;
using DeviceManagement.Views;

namespace DeviceManagement.Presenters
{
    /// <summary>
    /// Statictis Presenter class.
    /// </summary>
    /// <remarks>
    /// MV Patterns: MVP design pattern.
    /// </remarks>
    public class StatisticPresenter : Presenter<IStatisticView>
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="view">The view</param>
        public StatisticPresenter(IStatisticView view) : base(view)
        {
        }

        /// <summary>
        /// Perform statistic device. Gets data from view and calls model.
        /// </summary>
        /// 

        public List<dynamic> GetDeviceListByFixedTime()
        {
            return Model.GetDeviceListByFixedTime(View.MinTime, View.MaxTime);
        }

        public List<dynamic> GetDeviceListByStatus()
        {
            return Model.GetDeviceListByStatus(View.FromDate, View.ToDate, View.StatusDevice);
        }

    }
}
