using FluentNHibernate.Mapping;

namespace Suteki.Shop.Maps
{
    public class OrderLineMap : ClassMap<OrderLine>
    {
        public OrderLineMap()
        {
            Id(x => x.Id);

            Map(x => x.ProductName);
            Map(x => x.Quantity);
            Map(x => x.Price);

            References(x => x.Order);
        }
    }
}