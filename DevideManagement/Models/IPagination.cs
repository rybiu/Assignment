using AutoMapper;
using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeviceManagement.Models
{
    // IModel interface, part of MVP design pattern. 

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
