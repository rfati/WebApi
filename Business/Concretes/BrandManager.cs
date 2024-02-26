using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using DataAccess.Abstracts;
using Entities.Concretes;


namespace Business.Concretes
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public CreatedBrandResponse Add(CreatedBrandRequest createdBrandRequest)
        {
            //Business Rules

            //mapping  -->> automapper
            Brand brand = new();
            brand.Name = createdBrandRequest.Name;

            _brandDal.Add(brand);

            //Mapping
            CreatedBrandResponse createdBrandResponse = new CreatedBrandResponse();
            createdBrandResponse.Name = createdBrandRequest.Name;
            createdBrandResponse.Id = 4;
            createdBrandResponse.CreatedDate = brand.CreatedDate;

            return createdBrandResponse;

        }

        public List<GetAllBrandResponse> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
