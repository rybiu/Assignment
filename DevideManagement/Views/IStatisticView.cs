namespace DeviceManagement.Views
{

    // respresents statistic view with credentials.
    public interface IStatisticView : IView
    {
        int MinTime { get; }
        int MaxTime { get; }
        string FromDate { get; }
        string ToDate { get; }
        bool StatusDevice { get;  }
        
    }
}
