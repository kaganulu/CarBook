using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using CarBook.Application.Features.Mediator.Results.BlogResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Interfaces.BlogInterfaces;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetLast3BlogsWithAuthorsQueryHandler : IRequestHandler<GetLast3BlogsWitAuthorsQuery, List<GetLast3BlogsWitAuthorsQueryResult>>
    {
        private readonly IBlogRepository _repository;
        public GetLast3BlogsWithAuthorsQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetLast3BlogsWitAuthorsQueryResult>> Handle(GetLast3BlogsWitAuthorsQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetLast3BlogsWithAuthors();
            return values.Select(x => new GetLast3BlogsWitAuthorsQueryResult
            {
                BlogId = x.BlogId,
                Title = x.Title,
                AuthorId = x.AuthorId,
                CoverImageUrl = x.CoverImageUrl,
                CreatedDate = x.CreatedDate,
                CategoryId = x.CategoryId,
                AuthorName = x.Author.Name
            }).ToList();
        }
    }
}


