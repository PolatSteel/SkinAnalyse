using BusinessLayer.Abstruct;
using DataAccessLayer.Abstruct;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
	public class AnalyseResultManager : IAnalyseResultService
	{
		private readonly IAnalyseResultDal _analyseResultDal;

		public AnalyseResultManager(IAnalyseResultDal analyseResultDal)
		{
			_analyseResultDal = analyseResultDal;
		}

		public void TAdd(AnalyseResult entity)
		{
			_analyseResultDal.Add(entity);
		}

		public void TDelete(int id)
		{
			_analyseResultDal.Delete(id);
		}

		public List<AnalyseResult> TGetAll()
		{
			return _analyseResultDal.GetAll();
		}

		public AnalyseResult TGetById(int id)
		{
			return _analyseResultDal.GetById(id);
		}

		public void TUpdate(AnalyseResult entity)
		{
			_analyseResultDal.Update(entity);
		}
	}
}
