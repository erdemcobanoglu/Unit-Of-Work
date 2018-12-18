using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ReportBusiness : IBusiness<Report>
    {
        UnitOfWork _uof;
        bool _boolResult;
        public ReportBusiness()
        {
            _uof = new UnitOfWork();
        }


        public void Add(Report item)
        {
            if (item!=null)
            {
                if (string.IsNullOrWhiteSpace(item.Title))
                    throw new Exception("Rapor başlığı kısmı boş geçilemez |Report #Add +02");

                if (string.IsNullOrWhiteSpace(item.Description))
                    throw new Exception("Açıklama kısmı boş geçilemez|Report #Add +02");

                if (item.AnalystID < 1)
                    throw new Exception("Rapor vereni seçmelisiniz |Report #Add +02");

                _uof.ReportRepostor.Add(item);
               _boolResult= _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("Ekleme işlemi başarıyla yapıldı");
                else
                    throw new Exception("Ekleme işlemi yapılamadı");
            }
        }

        public List<Report> GetAll()
        {
            return _uof.ReportRepostor.GetAll();
        }

        public Report GetById(int id)
        {
            if (id > 0)
                return _uof.ReportRepostor.GetByID(id);
            else
                throw new Exception("Gelen id olmadığından işlem yapılamadı");
        }

        public void Remove(Report item)
        {
            if (item != null)
            {
                _uof.ReportRepostor.Remove(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("Silme işlemi Başarıyla Yapıldı");
                else
                    throw new Exception("Silme Yapılamadı");
            }
            else
                throw new Exception("Lütfen Seçim Yapın |Employee #Delete +02");
        }

        public void Update(Report item)
        {

            if (item != null)
            {
                if (item.ID < 1)
                    throw new Exception("Seçim yapmadan güncelleme işlemi yapılamaz Report #Update +02 ");

                if (string.IsNullOrWhiteSpace(item.Title))
                    throw new Exception("Rapor başlığı kısmı boş geçilemez |Report #Update +02");

                if (string.IsNullOrWhiteSpace(item.Description))
                    throw new Exception("Açıklama kısmı boş geçilemez|Report #Update +02");

                if (item.AnalystID < 1)
                    throw new Exception("Rapor vereni seçmelisiniz Report #Update +02");

                _uof.ReportRepostor.Update(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("Güncelleme işlemi başarıyla yapıldı");
                else
                    throw new Exception("Güncelleme işlemi yapılamadı");
            }
        }
    }
}
