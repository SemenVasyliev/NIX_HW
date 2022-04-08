using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface ITrashboxService
    {
        void AddToTrashbox(int productId, int userId);
        void DeleteFromTrashbox (int userId, int productId);
        void ClearTrashbox ();
    }
}
