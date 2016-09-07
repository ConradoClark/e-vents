using Eventos.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Model.Events
{
    public class EventPricingModel : RichEnum<int, EventPricingModel>
    {
        public static readonly EventPricingModel Free = new EventPricingModel(1);
        public static readonly EventPricingModel Paid = new EventPricingModel(2);
        public static readonly EventPricingModel PaymentOptional = new EventPricingModel(3);
        public static readonly EventPricingModel AlternateCurrency = new EventPricingModel(4);

        private EventPricingModel(int value) : base(value)
        {
        }

        public static implicit operator EventPricingModel(int value)
        {
            return Convert(value);
        }
    }
}
