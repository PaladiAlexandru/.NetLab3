using System;

namespace TSP.NET.L3.Refactored
{
	public class Card : IPayment
	{
		public void ChargeMoney(PaymentMethod paymentMethod,
			TicketDetails ticketDetails, Action onPayChangeToMobilePhone)
		{
			ProcessingCenterGateway processingCenterGateway = new ProcessingCenterGateway();
			PaymentDetails paymentDetails = new PaymentDetails();
			paymentDetails.Method = paymentMethod;
			processingCenterGateway.Charge(ticketDetails.Price, paymentDetails);
		}
	}
}
