using System;

namespace TSP.NET.L3.Refactored
{
	public class PaymentHandler
	{
        public PaymentHandler()
        {
        }

        public PaymentHandler(PaymentMethod paymentMethod, TicketDetails ticketDetails)
        {

		}

        public void Pay(PaymentMethod method, TicketDetails ticketDetails, Action onPayChangeToMobilePhone)
        {
			IPayment payment = new Card();

			if(method == PaymentMethod.Cash)
            {
				payment = new Cash();
            }

			payment.ChargeMoney(method, ticketDetails, onPayChangeToMobilePhone);
        }
	}
}
