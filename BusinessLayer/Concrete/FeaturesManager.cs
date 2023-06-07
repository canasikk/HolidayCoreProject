using BusinessLayer.Abstracrt;
using DataAccessLayer.Abstract;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class FeaturesManager:IFeaturesService
    {
        IFeaturesDal _featuresDal;
        public FeaturesManager(IFeaturesDal featuresDal)
        {
            _featuresDal = featuresDal;
        }
        public void TAdd(Features t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Features t)
        {
            throw new NotImplementedException();
        }

        public Features TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Features> TGetList()
        {
            return _featuresDal.GetList();
        }

        public void TUpdate(Features t)
        {
            throw new NotImplementedException();
        }
    }
}
