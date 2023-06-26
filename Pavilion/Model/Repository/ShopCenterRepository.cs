using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavilion.Model.Repository
{
    public class ShopCenterRepository : BaseRepository<shops_centers, int>
    {
        public string Update(shops_centers model)
        {
            try
            {
                if (model == null) return null;
                using (db_kingEntities db = new db_kingEntities())
                {
                    var entity = GetOne(model.shop_center_id);
                    entity = model;
                    db.SaveChanges();
                    return null;
                }

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
