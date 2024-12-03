using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using KYS.Business.Abstractions;
using KYS.Business.Validators;
using KYS.DataAccess.Repositories;
using KYS.Entities.Models;

namespace KYS.Business.Services
{
    public class AutorService : IManager<Author>
    {
        private readonly AuthorRepository _authorRepository;
        public AutorService(AuthorRepository aRepo)
        {
            _authorRepository = aRepo;
        }
        public void Create(Author entity)
        {
            AuthorValidator aVal = new AuthorValidator();
            ValidationResult result = aVal.Validate(entity);

            if (!result.IsValid)
            {
                StringBuilder sb = new StringBuilder();
                result.Errors.ForEach(r => sb.AppendLine(r.ErrorMessage));
                throw new Exception(sb.ToString());
            }

            _authorRepository.Create(entity);
        }

        public void Delete(Guid Id)
        {
            var aut = _authorRepository.GetByID(Id);

            if (aut != null)
            {
                _authorRepository.Delete(Id);
            }
        }

        public IEnumerable<Author> GetAll()
        {
            return _authorRepository.GetAll();
        }

        public Author GetByID(Guid Id)
        {
            return _authorRepository.GetByID(Id);
        }

        public bool IfEntityExists(Expression<Func<Author, bool>> filter)
        {
            return _authorRepository.IfEntityExists(filter);
        }

        public void Update(Author entity)
        {
            _authorRepository.Update(entity);
        }
    }
}
