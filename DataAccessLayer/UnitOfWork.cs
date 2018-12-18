using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class UnitOfWork
    {
        SqlContext _sqlContext;
        DbContextTransaction _transaction;

        public UnitOfWork()
        {
            _sqlContext = new SqlContext();
        }


        private ReportRepository _reportRepostory;

        private EmployeeRepository _employeeRepostory;

        private CustomerRepository _customerRepository;

        private TitleRepository _titleRepository;

        private ProjectRepository _projectRepository;

        private CustomerMessageRepository _customerMessageRepository;

        private TaskRepository _taskRepository;

        private GenderRepository _genderRepository;

        public GenderRepository GenderRepository
        {
            get
            {
                if (_genderRepository==null)
                {
                    _genderRepository = new GenderRepository(this._sqlContext);
                }

                return _genderRepository;
            }

        }

        public TaskRepository TaskRepository
        {
            get
            {

                if (_taskRepository==null)
                {
                    _taskRepository = new TaskRepository(this._sqlContext); 
                }

                return _taskRepository;
            }

        }
        public CustomerMessageRepository CustomerMessageRepository
        {

            get
            {
                if (_customerMessageRepository==null)
                {
                    _customerMessageRepository = new CustomerMessageRepository(this._sqlContext);
                }
                return _customerMessageRepository;
            }
        }

        public ProjectRepository ProjectRepository
        {
            get
            {
                if (_projectRepository == null)
                {
                    _projectRepository = new ProjectRepository(this._sqlContext);
                }
                return _projectRepository;
            }
        }

        public TitleRepository TitleRepository
        {
            get
            {
                if (_titleRepository==null)
                {
                    _titleRepository = new TitleRepository(this._sqlContext);
                }

                return _titleRepository;
            }


        }

        public CustomerRepository CustomerRepository
        {

            get
            {
                if (_customerRepository==null)
                {
                    _customerRepository = new CustomerRepository(this._sqlContext);
                }

                return _customerRepository;
            }

        }
        public EmployeeRepository EmployeeRepostory
        {
            get {

                if (_employeeRepostory==null)
                {
                    _employeeRepostory = new EmployeeRepository(this._sqlContext);
                }

                return _employeeRepostory;
            }
           
        }

        public ReportRepository ReportRepostor
        {
            get
            {
                if (_reportRepostory==null)
                {
                    _reportRepostory = new ReportRepository(this._sqlContext);
                }

                return _reportRepostory;
            }

        }



        public bool ApplyChanges()
        {
            bool isSuccess = false;

            _transaction = _sqlContext.Database.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

            try
            {
                _sqlContext.SaveChanges();
                _transaction.Commit();
                isSuccess = true;
            }
            catch (Exception)
            {

                _transaction.Rollback();
                isSuccess = false;
            }
            finally
            {
                _transaction.Dispose();
            }
            return isSuccess;
        }

    }
}
