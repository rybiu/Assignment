using System;
using System.Collections.Generic;

namespace DeviceManagement.Models
{
    // An implement of IPagination

    public class PaginationImp<T> : IPagination<T>
    {
        Func<int, int, List<T>> GetListFunc;
        Func<int> GetListCountFunc;

        public PaginationImp(Func<int, int, List<T>> getListFunc, Func<int> getListCountFunc, int pageSize = 5)
        {
            GetListFunc = getListFunc;
            GetListCountFunc = getListCountFunc;
            PageSize = pageSize;
            PageIndex = 1;
        }

        public int PageSize { get; }

        public int PageIndex { get; private set; }

        public List<T> GetCurrentPage()
        {
            int count = GetListCountFunc();
            if (PageIndex > (int)Math.Ceiling((decimal)count / PageSize) && PageIndex > 1) PageIndex--;
            return GetListFunc(PageIndex, PageSize);
        }

        public void GoToPreviousPage()
        {
            PageIndex--;
        }

        public void GoToNextPage()
        {
            PageIndex++;
        }

        public void GoToFirstPage()
        {
            PageIndex = 1;
        }

        public void GoToLastPage()
        {
            int count = GetListCountFunc();
            PageIndex = (int)Math.Ceiling((decimal)count / PageSize);
        }

        public bool HasPreviousPage()
        {
            return PageIndex > 1;
        }

        public bool HasNextPage()
        {
            int count = GetListCountFunc();
            return PageIndex < (int)Math.Ceiling((decimal)count / PageSize);
        }

    }
}
