using System.Collections.Generic;

namespace DeviceManagement.Models
{
    // IPagination is a helper of Model

    public interface IPagination<T>
    {
        List<T> GetCurrentPage();

        void GoToPreviousPage();

        void GoToNextPage();

        void GoToFirstPage();

        void GoToLastPage();

        bool HasPreviousPage();

        bool HasNextPage();

    }
}
