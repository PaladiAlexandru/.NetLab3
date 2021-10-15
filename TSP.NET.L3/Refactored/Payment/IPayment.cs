using System;
using TSP.NET.L3.Refactored;

namespace TSP.NET.L3.Refactored
{
	public interface IPayment
	{
		void ChargeMoney(PaymentMethod paymentMethod, 
			TicketDetails ticketDetails, Action onPayChangeToMobilePhone);

		/* CARD:
		 * void ChargeCard(TicketDetails ticket, PaymentDetails payment);
		 * 
		 * CASH:
		void AcceptCash(TicketDetails ticket);
		void DispenseChange(TicketDetails ticket, Action onPayChangeToMobilePhone);
		bool TryToDispense(decimal changeAmount);*/
	}
}
