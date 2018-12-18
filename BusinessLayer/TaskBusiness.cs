using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccessLayer;

namespace BusinessLayer
{
   public class TaskBusiness : IBusiness<Entities.Task>
    {
        UnitOfWork _uof;
        bool _boolResult;

        public TaskBusiness()
        {
            _uof = new UnitOfWork();
        }
        public void Add(Entities.Task item)
        {
            if (item != null)
            {
                if (string.IsNullOrWhiteSpace(item.Status))
                    throw new Exception("Görev durumu boş geçilemez |Task #Add +02");

                if (item.BeginDate == null)
                    throw new Exception("Başlangıç tarihi boş geçilemez |Task #Add +02");

                if (item.FinalDate == null)
                    throw new Exception("Bitiş tarihi boş geçilemez |Task #Add +02");

                if (string.IsNullOrWhiteSpace(item.Description))
                    throw new Exception("Açıklama kısmı boş geçilemez |Task #Add +02 ");

                _uof.TaskRepository.Add(item);
                _boolResult = _uof.ApplyChanges();
                if (_boolResult == true)
                    throw new Exception("Kayıt işlemi başarıyla yapıldı");
                else
                    throw new Exception("Kayıt işlemi başarıyla yapılamadı");

            }

          
        }

        public List<Entities.Task> GetAll()
        {
            return _uof.TaskRepository.GetAll();
        }

        public Entities.Task GetById(int id)
        {
            if (id>0)
            {
                return _uof.TaskRepository.GetByID(id);
            }

            else
            {
                throw new Exception("Geçerli bir id değeri girmediniz");
            }
        }

        public void Remove(Entities.Task item)
        {
            if (item != null)
            {
                _uof.TaskRepository.Remove(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("Silme işlemi başarıyla yapıldı ");

                else
               
                    throw new Exception("Silme işlemi başarısız |Task #Delete +02");
 
            }

            else
           
                throw new Exception("Silme işlemi için seçim yapmalısınız  |Task #Delete +02");
            
        }

        public void Update(Entities.Task item)
        {
            if (item != null)
            {
                if (item.ID < 1)
                    throw new Exception("Geçerli bir seçim yapılamadı  |Task #Update +02");

                if (string.IsNullOrWhiteSpace(item.Status))
                    throw new Exception("Görev durumu boş geçilemez |Task #Update +02");

                if (item.BeginDate == null)
                    throw new Exception("Başlangıç tarihi |Task #Update +02");

                if (item.FinalDate == null)
                    throw new Exception("Başlangıç tarihi |Task #Update +02");

                if (string.IsNullOrWhiteSpace(item.Description))
                    throw new Exception("Açıklama kısmı boş geçilemez |Task #Update +02 ");

                _uof.TaskRepository.Update(item);
                _boolResult = _uof.ApplyChanges();
                if (_boolResult == true)
                    throw new Exception("Güncelleme işlemi başarıyla yapıldı");
                else
                    throw new Exception("Güncelleme işlemi başarıyla yapılamadı");

            }
        }
    }
}
