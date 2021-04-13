using System.Collections.Generic;
using MediatR;

namespace Ordering.Application.Queries.GetOrdersList
{
    public class GetOrdersListQuery : IRequest<List<OrderResponse>>
    {
        public string UserName { get; set; }
        public GetOrdersListQuery(string userName)
        {
            UserName = userName;
        }
    }
}