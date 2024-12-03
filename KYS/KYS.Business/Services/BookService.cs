using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using KYS.Business.Abstractions;
using KYS.Entities.Models;
using KYS.DataAccess.Repositories;
using KYS.Business.Validators;

namespace KYS.Business.Services
{
    public class BookService : IManager<Book>
    {
        private readonly BookRepository _bookRepository;
        public BookService(BookRepository bRepo)
        {
            _bookRepository = bRepo;
        }
        public void Create(Book entity)
        {
            BookValidator bVal = new BookValidator();
            ValidationResult result = bVal.Validate(entity);

            if (!result.IsValid)
            {
                StringBuilder sb = new StringBuilder();
                result.Errors.ForEach(r => sb.AppendLine(r.ErrorMessage));
                throw new Exception(sb.ToString());
            }

            _bookRepository.Create(entity);
        }

        public void Delete(Guid Id)
        {
            var book = _bookRepository.GetByID(Id);

            if (book != null)
            {
                _bookRepository.Delete(Id);
            }
        }

        public IEnumerable<Book> GetAll()
        {
            return _bookRepository.GetAll();
        }

        public Book GetByID(Guid Id)
        {
            return _bookRepository.GetByID(Id);
        }

        public bool IfEntityExists(Expression<Func<Book, bool>> filter)
        {
            return _bookRepository.IfEntityExists(filter);
        }

        public void Update(Book entity)
        {
            _bookRepository.Update(entity);
        }
    }
}
