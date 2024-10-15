using Email._0.Core.Abstract;
using Email._0.Core.Concrate;
using Email.MyModel.Contexts;
using Email.MyModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email._1.DataAcccess.Concrate
{
    public class HomelandSell : BaseRepository<Sell, MyDbContextMain>, IBaseRepository<Sell>
    {
    }
}
