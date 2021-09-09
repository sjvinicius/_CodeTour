using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTour.Shared
{
    public abstract class Base : Notifiable<Notification>
    {
        public Base()
        {
            Id = Guid.NewGuid();
            DataCriacao = DateTime.Now;

        }

        public Guid Id { get; set; }

        public DateTime DataCriacao { get; set; }

    }
}
