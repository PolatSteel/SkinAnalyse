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
	public class LoginManager : ILoginService
	{
		private readonly ILoginDal _loginDal;

		public LoginManager(ILoginDal loginDal)
		{
			_loginDal = loginDal;
		}

		public void TAdd(Login entity)
		{
			_loginDal.Add(entity);
		}

		public void TDelete(int id)
		{
			_loginDal.Delete(id);
		}

		public List<Login> TGetAll()
		{
			return _loginDal.GetAll();
		}

		public Login TGetById(int id)
		{
			return _loginDal.GetById(id);
		}

		public void TUpdate(Login entity)
		{
			_loginDal.Update(entity);
		}
	}
}
