using System;

namespace Bridge
{
    /// <summary>
    /// Транспортная компания
    /// </summary>
    abstract class TransportCompany
    {
        private ICarrier _carrier;

        protected TransportCompany(ICarrier carrier)
        {
            Carrier = carrier;
        }

        public ICarrier Carrier
        {
            set => _carrier = value;
        }

        public void SendPackages()
        {
            _carrier.AcceptShipment();
            _carrier.Send();
        }

        public abstract void SendNotification();
    }

    class TransportCompanyA : TransportCompany
    {
        public TransportCompanyA(ICarrier carrier) : base(carrier)
        {
        }

        public override void SendNotification()
        {
            Console.WriteLine("Отправляем уведомление по почте");
        }
    }

    class TransportCompanyB : TransportCompany
    {
        public TransportCompanyB(ICarrier carrier) : base(carrier)
        {
        }

        public override void SendNotification()
        {
            Console.WriteLine("Отправляем уведомление по почте");
            Console.WriteLine("Отправляем смс-уведомление уведомление");
        }
    }
}