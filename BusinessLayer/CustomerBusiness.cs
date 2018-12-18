using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccessLayer;


namespace BusinessLayer
{
    public class CustomerBusiness : IBusiness<Customer>
    {
        UnitOfWork _uof;
        bool _boolResult;
        public CustomerBusiness()
        {
            _uof = new UnitOfWork();
        }

        public void Add(Customer item)
        {
            if (item != null)
            {
                if (string.IsNullOrWhiteSpace(item.ContactPerson))
                    throw new Exception("Şirket yetkilisi adı boş geçilemez |Customer #Add +02");

                if (string.IsNullOrWhiteSpace(item.CompanyName))
                    throw new Exception("Şirket adı boş geçilemez |Customer #Add +02");

                if (string.IsNullOrWhiteSpace(item.Email))
                    throw new Exception("E-mail kısmı boş geçilemez |Customer #Add +02");

                if (string.IsNullOrWhiteSpace(item.Phone))
                    throw new Exception("Telefon numarası kısmı boş geçilemez  |Customer #Add +02");

                if (string.IsNullOrWhiteSpace(item.UserName))
                    throw new Exception("USerName boş geçilemez |Customer #Add +02");

                if (string.IsNullOrWhiteSpace(item.Password))
                    throw new Exception("Parola Alanı boş Geçilemez |Customer #Add +02");

                if (string.IsNullOrWhiteSpace(item.ProjectStatus))
                    throw new Exception("Proje durumu kısmı boş geçilemez  |Customer #Add +02");

                _uof.CustomerRepository.Add(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("Kayıt işlemi başarıyla yapıldı");
                else
                    throw new Exception("Kayıt işlemi  yapılamadı");


            }

        }

        public List<Customer> GetAll()
        {
            return _uof.CustomerRepository.GetAll();
        }

        public Customer GetById(int id)
        {
            if (id < 0)
                throw new Exception("GeçerliBir ID girmediniz.");

            return _uof.CustomerRepository.GetByID(id);
           
        }

        public void Remove(Customer item)
        {
            if (item != null)
            {

                _uof.CustomerRepository.Remove(item);
                _boolResult = _uof.ApplyChanges();
                if (_boolResult == true)
                {
                    throw new Exception("Silme işlemi başarıyla yapıldı");
                }
                else
                {
                    throw new Exception("Silme işlemi yapılamadı");
                }
            }

            else
            {
                throw new Exception("Silmek için seçim yapmalısınız");
            }
        }

        public void Update(Customer item)
        {
            if (item != null)
            {

                if (item.ID < 1)
                    throw new Exception("Geçerli bir değer girmediniz |Customer #Update +02");

                if (string.IsNullOrEmpty(item.ContactPerson))
                    throw new Exception("Şirket yetkili adı boş geçilemez  |Customer #Update +02");

                if (string.IsNullOrEmpty(item.Email))
                    throw new Exception("E-mail kısmı boş geçilemez   |Customer #Update +02");

                if (string.IsNullOrEmpty(item.Phone))
                    throw new Exception("Telefon numarası boş geçilemez   |Customer #Update +02");

                if (string.IsNullOrEmpty(item.CompanyName))
                    throw new Exception("Şirket adı boş geçilemez  |Customer #Update +02");

                if (string.IsNullOrWhiteSpace(item.UserName))
                    throw new Exception("USerName Boş geçilemez |Customer #Update +02");

                if (string.IsNullOrWhiteSpace(item.Password))
                    throw new Exception("Parola Alanı BOş Geçilemez |Customer #Update +02");

                if (string.IsNullOrWhiteSpace(item.ProjectStatus))
                    throw new Exception("Proje durumu kısmı boş geçilemez  |Customer #Update +02");

                _uof.CustomerRepository.Update(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("Güncelleme işlemi başarıyla yapıldı");

                else
                    throw new Exception("Güncelleme işlemi başarıyla yapılamadi");



            }
        }

        public Customer GetCustomerByPassword(string userName,string password)
        {
            List<Customer> customerList = GetAll();

            Customer customer = (from c in customerList
                                 where userName == c.UserName && password == c.Password
                                 select c).SingleOrDefault();
            return customer;

        }
    }
}
