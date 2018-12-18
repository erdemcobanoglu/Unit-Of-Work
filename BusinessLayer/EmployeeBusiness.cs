using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
  public  class EmployeeBusiness : IBusiness<Employee>
    {
        UnitOfWork _uof;
        bool _Result;


        public EmployeeBusiness()
        {
            _uof = new UnitOfWork();
        }

        public void Add(Employee item)
        {
            if (item != null)
            {
                if (string.IsNullOrWhiteSpace(item.Password))
                    throw new Exception("Password kısmı boş geçilemez |Employee #Add +02");

                if (string.IsNullOrWhiteSpace(item.UserName))
                    throw new Exception("KullanıcıAdı kısmı boş geçilemez |Employee #Add +02");

                if (string.IsNullOrWhiteSpace(item.FirstName))
                    throw new Exception("isim null geçilmez |Employee #Add +02");

                if (string.IsNullOrWhiteSpace(item.LastName))
                    throw new Exception("soyisim null geçilmez |Employee #Add +02");

                if (string.IsNullOrWhiteSpace(item.Country))
                    throw new Exception("country null geçilmez |Employee #Add +02");
                
                if (string.IsNullOrWhiteSpace(item.Email))
                    throw new Exception("Email null geçilmez |Employee #Add +02");

                if (string.IsNullOrWhiteSpace(item.Address))
                    throw new Exception("Address null geçilmez |Employee #Add +02");

                //if (item.GenderId <= 0 || item.GenderId == null)
                //    throw new Exception("GenderId null geçilmez |Employee #Add +02");

                //if (item.TaskId <= 0|| item.TaskId == null)
                //    throw new Exception("TaskId null geçilmez |Employee #Add +02");

                //if (item.TitleId <= 0 ||item.TitleId == null)
                //    throw new Exception("TitleId null geçilmez |Employee #Add +02");

                if (string.IsNullOrWhiteSpace(item.Status))
                    throw new Exception("Status null geçilmez |Employee #Add +02");

                if (string.IsNullOrWhiteSpace(item.SocialNumber))
                    throw new Exception("SocialNumber null geçilmez |Employee #Add +02");

                if (string.IsNullOrWhiteSpace(item.Status))
                    throw new Exception("country null geçilmez |Employee #Add +02");

                if (item.BirthDate == null)
                    throw new Exception("DateTime null geçilmez |Employee #Add +02");

                _uof.EmployeeRepostory.Add(item);
                _Result = _uof.ApplyChanges();

                if (_Result == true)
                    throw new Exception("Kayıt işlemi Başarıyla Yapıldı");
                else
                    throw new Exception("Kayıt Yapılamadı");
            }
           
        }

        public List<Employee> GetAll()
        {
            return _uof.EmployeeRepostory.GetAll();
        }

        public Employee GetById(int id)
        {
            if (id < 0)
                throw new Exception("GeçerliBir ID girmediniz.");

            return _uof.EmployeeRepostory.GetByID(id);
        }

        public void Remove(Employee item)
        {
            if (item != null)
            {
                _uof.EmployeeRepostory.Remove(item);
                _Result = _uof.ApplyChanges();

                if (_Result == true)
                    throw new Exception("Silme işlemi Başarıyla Yapıldı");
                else
                    throw new Exception("Silme Yapılamadı");
            }
            else
                throw new Exception("Lütfen Seçim Yapın |Employee #Delete +02");

           
        }

        public void Update(Employee item)
        {
           if(item != null)
            {

                if (string.IsNullOrWhiteSpace(item.FirstName))
                    throw new Exception("isim null geçilmez |Employee #Update +02");

                if (string.IsNullOrWhiteSpace(item.LastName))
                    throw new Exception("soyisim null geçilmez |Employee #Update +02");

                if (string.IsNullOrWhiteSpace(item.Country))
                    throw new Exception("country null geçilmez |Employee #Update +02");

                if (string.IsNullOrWhiteSpace(item.Email))
                    throw new Exception("Email null geçilmez |Employee #Update +02");

                if (string.IsNullOrWhiteSpace(item.Address))
                    throw new Exception("Address null geçilmez |Employee #Update +02");

                //if (item.GenderId <= 0 || item.GenderId == null)
                //    throw new Exception("GenderId null geçilmez |Employee #Update +02");

                //if (item.TaskId <= 0 || item.TaskId == null)
                //    throw new Exception("TaskId null geçilmez |Employee #Update +02");

                //if (item.TitleId <= 0 || item.TitleId == null)
                //    throw new Exception("TitleId null geçilmez|Employee #Update +02");

                if (string.IsNullOrWhiteSpace(item.Status))  
                    throw new Exception("Status null geçilmez |Employee #Update +02");

                if (string.IsNullOrWhiteSpace(item.SocialNumber))
                    throw new Exception("SocialNumber null geçilmez |Employee #Update +02");

                if (string.IsNullOrWhiteSpace(item.Status))
                    throw new Exception("country null geçilmez |Employee #Update +02");

                if (item.BirthDate == null)
                    throw new Exception("DateTime null geçilmez |Employee #Update +02");

                if (string.IsNullOrWhiteSpace(item.Password))
                    throw new Exception("Password kısmı boş geçilemez |Employee #Update +02");

                if (string.IsNullOrWhiteSpace(item.UserName))
                    throw new Exception("KullanıcıAdı kısmı boş geçilemez |Employee #Update +02");

                _uof.EmployeeRepostory.Update(item);
                _Result = _uof.ApplyChanges();

                if (_Result == true)
                    throw new Exception("Güncelleme işlemi Başarıyla Yapıldı");
                else                   
                    throw new Exception("Güncelleme Yapılamadı");
            }
        }

        public Employee GetTitleIdByUserName(string userName ,string password)
        {
            List<Employee> employeeList = new List<Employee>();
            employeeList = GetAll();

            Employee employee = (from e in employeeList
                           where e.UserName == userName && e.Password==password
                           select e).SingleOrDefault();

            return employee;

        }
    }
}
