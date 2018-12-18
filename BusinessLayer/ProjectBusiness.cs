using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccessLayer;

namespace BusinessLayer
{
    public class ProjectBusiness : IBusiness<Project>
    {
        UnitOfWork _uof;
        bool _boolResult;


        public ProjectBusiness()
        {
            _uof = new UnitOfWork();
        }

        public void Add(Project item)
        {
            if (item != null)
            {
                if (string.IsNullOrWhiteSpace(item.Name))
                    throw new Exception("Proje adi boş geçilemez |Project #Add +02");

                #region Null Gecilebilsin deneme
                //if (item.StartDate == null)
                //    throw new Exception("Başlangıç tarihi boş geçilemez |Project #Add +02");

                //if (item.EndDate == null)
                //    throw new Exception("Bitiş tarihi boş geçilemez |Project #Add +02"); 
                #endregion

                if (item.PlanningStartDate == null)
                    throw new Exception("Plan başlangıç tarihi boş geçilemez |Project #Add +02");

                if (item.PlanningStartDate == null)
                    throw new Exception("Plan bitiş tarihi boş geçilemez |Project #Add +02");

                _uof.ProjectRepository.Add(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("Kayıt işlemi başarıyla yapıldı");
                else
                    throw new Exception("Kayıt işlemi  yapılamadı");

            }

        }

        public List<Project> GetAll()
        {
            return _uof.ProjectRepository.GetAll();
        }

        public Project GetById(int id)
        {
            if (id>0)
            
                return _uof.ProjectRepository.GetByID(id);
  
            else
            
                throw new Exception("Geçerli bir ID değerli girmediniz ");
            
        }

        public void Remove(Project item)
        {
            if (item != null)
            {

                _uof.ProjectRepository.Remove(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("Silme işlemi başarıyla yapıldı");
                else
                    throw new Exception("Silme işlemi  yapılamadı |Project #Delete +02");

            }

            else
          
                throw new Exception("Silme işlemi için seçim yapmalısınız");
           
        }

        public void Update(Project item)
        {
            if (item != null)
            {
                if (item.ID < 1)
                    throw new Exception("Geçerli bir değer girmediniz |Project #Update +02");

                if (string.IsNullOrWhiteSpace(item.Name))
                    throw new Exception("Proje adi boş geçilemez |Project #Update +02");

                if (item.StartDate == null)
                    throw new Exception("Başlangıç tarihi boş geçilemez |Project #Update +02");

                if (item.EndDate == null)
                    throw new Exception("Bitiş tarihi boş geçilemez |Project #Update +02");

                if (item.PlanningStartDate == null)
                    throw new Exception("Plan başlangıç tarihi boş geçilemez |Project #Update +02");

                if (item.PlanningStartDate == null)
                    throw new Exception("Plan bitiş tarihi boş geçilemez |Project #Update +02");

                _uof.ProjectRepository.Add(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("Güncelleme işlemi başarıyla yapıldı");
                else
                    throw new Exception("Güncelleme işlemi yapılamadı");

            }
        }


        public List<Project> GetProjectByCustomerID(int id)
        {
            List<Project> projectList = new List<Project>();
            projectList = GetAll();

            var projects = (from p in projectList
                           where p.CustomerID == id

                           select p).ToList();
            return projects;
        }
    }
}
