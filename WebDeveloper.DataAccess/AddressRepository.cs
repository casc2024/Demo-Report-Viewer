using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;
using WebDeveloper.Model.DTO;

namespace WebDeveloper.DataAccess
{
    public class AddressRepository : BaseDataAccess<Address> // tiene que ser address xq tenemos seteado el address
    {
        public List<AddressModelView> GetListDto() {
            using (var db = new WebContextDb()) {
                return Automapper.GetGeneric<IEnumerable<Address>, List<AddressModelView>>(db.Address.ToList().Take(10));
            }
        }
    }
}
