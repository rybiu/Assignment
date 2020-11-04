using System;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace DeviceManagement.Utils
{
    /*class DBHelper
    {
        const string DATA_SOURCE = "SE141150";
        const string DATABASE_NAME = "management";

        public static SqlConnection connection;

        public static SqlConnection GetConnectionInstance()
        {
            if (connection == null)
            {
                string connetionString = @"Data Source=" + DATA_SOURCE + ";Initial Catalog=" + DATABASE_NAME + ";Integrated Security=True";
                connection = new SqlConnection(connetionString);
            }
            return connection;
        }

    }

    class Pagination
    {
        const int PageSize = 5;
        public int PageIndex { get; set; }
        public DataTable Data { get; set; }

        public Pagination()
        {
            PageIndex = 1;
        }

        public DataTable GetCurrentPage()
        {
            PageIndex = (int)Math.Min(PageIndex, Math.Ceiling((decimal)Data.Rows.Count / PageSize));
            DataTable dt = Data.Clone();
            for (int i = (PageIndex - 1) * PageSize; i < Math.Min(Data.Rows.Count, PageIndex * PageSize); i++)
            {
                dt.ImportRow(Data.Rows[i]);
            }
            return dt;
        }

        public void GoToPrePage()
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
            PageIndex = (int)Math.Ceiling((decimal)Data.Rows.Count / PageSize);
        }

        public bool HasPrePage()
        {
            return PageIndex > 1;
        }

        public bool HasNextPage()
        {
            return PageIndex < Math.Ceiling((decimal)Data.Rows.Count / PageSize);
        }

    }*/

    public class ImageHelper
    {
        public static byte[] ImageToByteArray(Image imageIn)
        {
            if (imageIn == null) return null;
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        public static Image ByteArrayToImage(byte[] bytes)
        {
            if (bytes == null) return null;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
