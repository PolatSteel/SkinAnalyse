using DataAccessLayer.Abstruct;
using DataAccessLayer.Context;
using DataAccessLayer.Repository;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFrameWork
{
	public class EfLoginDal : GenericRepository<Login>, ILoginDal
	{
		public EfLoginDal(SkinAnalyseContext context) : base(context)
		{
		}
	}
}
