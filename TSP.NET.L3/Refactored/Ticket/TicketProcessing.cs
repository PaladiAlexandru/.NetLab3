using System;

namespace TSP.NET.L3.Refactored
{
	public class TicketProcessing
	{
        public void BuyTicket(TicketDetails ticket,
                              PaymentDetails payment, Action onPayChangeToMobilePhone)
        {
            PaymentHandler paymentHandler = new PaymentHandler();
            paymentHandler.Pay(payment.Method, ticket, onPayChangeToMobilePhone);
        }
    }
}
