using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccessLayer;

namespace BusinessLayer
{
    public class CustomerMessageBusiness : IBusiness<CustomerMessage>
    {
        UnitOfWork _uof;
        bool _boolResult;

        public CustomerMessageBusiness()
        {
            _uof = new UnitOfWork();
        }


        public void Add(CustomerMessage item)
        {
            if (item!=null)
            {
                if (string.IsNullOrWhiteSpace(item.Name))
                    throw new Exception("Konu boş geçilemez |CustomerMessage #Add +02");

                if (string.IsNullOrWhiteSpace(item.Status))
                    throw new Exception("Proje durumu |CustomerMessage #Add +02");

                if (string.IsNullOrWhiteSpace(item.Description))
                    throw new Exception("Aciklama kismi |CustomerMessage #Add +02");

                _uof.CustomerMessageRepository.Add(item);
                _boolResult = _uof.ApplyChanges();


                if (_boolResult == true)
                    throw new Exception("Kayıt işlemi başarıyla yapıldı");

                else
                    throw new Exception("Kayıt işlemi yapılamadı");

            }
         
        }

        public List<CustomerMessage> GetAll()
        {
            return _uof.CustomerMessageRepository.GetAll();
        }

        public CustomerMessage GetById(int id)
        {
            if (id>0)
            {
                return _uof.CustomerMessageRepository.GetByID(id);

            }


            else
            {
                throw new Exception("Geçerli bir ID değeri girmediniz");
            }
        }

        public void Remove(CustomerMessage item)
        {
            if (item != null)
            {

                _uof.CustomerMessageRepository.Remove(item);
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

        public void Update(CustomerMessage item)
        {
            if (item != null)
            {
                if (item.ID < 1)
                    throw new Exception("Geçerli bir ID değeri girilmedi  |CustomerMessage #Add +02");

                if (string.IsNullOrWhiteSpace(item.Name))
                    throw new Exception("Konu boş geçilemez |CustomerMessage #Add +02");

                if (string.IsNullOrWhiteSpace(item.Status))
                    throw new Exception("Proje durumu |CustomerMessage #Add +02");

                if (string.IsNullOrWhiteSpace(item.Description))
                    throw new Exception("Aciklama kismi |CustomerMessage #Add +02");

                _uof.CustomerMessageRepository.Update(item);
                _boolResult = _uof.ApplyChanges();


                if (_boolResult == true)
                    throw new Exception("Güncelleme işlemi başarıyla yapıldı");

                else
                    throw new Exception("Güncelleme işlemi yapılamadı");

            }
        }
    }
}
