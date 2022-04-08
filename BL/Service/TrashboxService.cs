using BL.Interfaces;
using DL.Entities;
using DL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Service
{
    public class TrashboxService : ITrashboxService
    {
        Dictionary<int, int> featuredProductInTrashbox = new Dictionary<int, int>();
        FeaturedProductRepository rep = new FeaturedProductRepository();
        public void AddToTrashbox(int productId, int userId)
        {
            foreach (var item in rep.featuredProducts)
            {
                featuredProductInTrashbox.Add(item.UserId, item.ProductId);
            }
        }

        public void ClearTrashbox()
        {
            featuredProductInTrashbox.Clear();
        }

        public void DeleteFromTrashbox(int userId, int productId)
        {
            foreach (var item in featuredProductInTrashbox)
            {
                if (item.Key == userId && item.Value == productId)
                {
                    featuredProductInTrashbox.Remove(userId);
                }
            }
        }
    }
}
