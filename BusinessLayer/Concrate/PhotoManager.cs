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
	public class PhotoManager : IPhotoService
	{
		private readonly IPhotoDal _photoDal;

		public PhotoManager(IPhotoDal photoDal)
		{
			_photoDal = photoDal;
		}

		public void TAdd(Photo entity)
		{
			_photoDal.Add(entity);
		}

		public void TDelete(int id)
		{
			_photoDal.Delete(id);
		}

		public List<Photo> TGetAll()
		{
		   return _photoDal.GetAll();
		}

		public Photo TGetById(int id)
		{
			return _photoDal.GetById(id);
		}

		public void TUpdate(Photo entity)
		{
			_photoDal.Update(entity);
		}
	}
}
