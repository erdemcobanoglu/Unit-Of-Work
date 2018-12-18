using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccessLayer;

namespace BusinessLayer
{
    public class TitleBusiness :IBusiness<Title>
    {
        UnitOfWork _uof;
        bool _boolResult;

        public TitleBusiness()
        {
            _uof = new UnitOfWork();
        }

        public void Add(Title item)
        {
            if ( item != null)
            {
                if (string.IsNullOrWhiteSpace(item.TitleName))
                    throw new Exception("TitleName BoşGeçilemez |Title #Add +02");

                _uof.TitleRepository.Add(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("Kayıt işlemi Başarıyla Yapıldı");
                else
                    throw new Exception("Kayıt Yapılamadı");
            }
        }

        public void Remove(Title item)
        {
            if (item != null)
            {
                _uof.TitleRepository.Remove(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("Silme işlemi Başarıyla Yapıldı");
                else
                    throw new Exception("Silme işlemi Yapılamadı");
            }
            else
                throw new Exception("Lütfen bir seçim yapınız |Title #delete +02 ");
        }

        public void Update(Title item)
        {
            if (item != null)
            {
                if (item.ID < 0)
                    throw new Exception("Id degeri Boş geçilemez #TitleBusiness +02");
                if (string.IsNullOrWhiteSpace(item.TitleName))
                    throw new Exception("TitleName boş geçilemez #TitleBusiness +02");

                _uof.TitleRepository.Update(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("Güncelleme işlemi Başarıyla Yapıldı");
                else
                    throw new Exception("Güncelleme Yapılamadı");


            }
        }

        public List<Title> GetAll()
        {
            return _uof.TitleRepository.GetAll();
        }

        public Title GetById(int id)
        {
            if (id < 0)
                throw new Exception("Geçerli bir ID giriniz");

            return _uof.TitleRepository.GetByID(id);
        }


        //public int GetTitleIdByUserName(string Username)
        //{
        //    #region Parola islemleri 1
        //    //Employee useEmployee =new Employee();

        //    //List<Employee> titlelist = new List<Employee>();

        //    //foreach (var item in titlelist)
        //    //{
        //    //    item.UserName = Username;

        //    //} 
        //    #endregion


      
        //}
    }
}
