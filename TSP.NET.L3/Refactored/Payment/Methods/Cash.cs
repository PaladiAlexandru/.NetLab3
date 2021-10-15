using System;

namespace TSP.NET.L3.Refactored
{
	public class Cash : IPayment
	{
		decimal _cashAccepted;

		public void ChargeMoney(PaymentMethod paymentMethod,
			TicketDetails ticketDetails, Action onPayChangeToMobilePhone)
		{
			AcceptCash(ticketDetails);
			DispenseChange(ticketDetails, onPayChangeToMobilePhone);
		}
		private void AcceptCash(TicketDetails ticket)
        {
			var r = new Random();
			_cashAccepted = r.Next((int)ticket.Price, (int)ticket.Price + 1000);
		}

		private void DispenseChange(TicketDetails ticketDetails,
			Action onPayChangeToMobilePhone)
        {
			if (_cashAccepted > ticketDetails.Price &&
				!TryToDispense(_cashAccepted - ticketDetails.Price))
				onPayChangeToMobilePhone?.Invoke();
		}

		private bool TryToDispense(decimal changeAmount)
		{
			return false; //or true :)
		}
	}
}
