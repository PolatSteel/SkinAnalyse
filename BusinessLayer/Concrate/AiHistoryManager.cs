using BusinessLayer.Abstruct;
using DataAccessLayer.Abstruct;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
	public class AiHistoryManager : IAiHistoryService
	{
		private readonly IAIHistoryDal _aiHistoryDal;

		public AiHistoryManager(IAIHistoryDal aiHistoryDal)
		{
			_aiHistoryDal = aiHistoryDal;
		}

		public void TAdd(AIHistory entity)
		{
			_aiHistoryDal.Add(entity);
		}

		public void TDelete(int id)
		{
			_aiHistoryDal.Delete(id);
		}

		public List<AIHistory> TGetAll()
		{
			return _aiHistoryDal.GetAll();
		}

		public AIHistory TGetById(int id)
		{
			return _aiHistoryDal.GetById(id);
		}

		public void TUpdate(AIHistory entity)
		{
			_aiHistoryDal.Update(entity);
		}
	}
}
