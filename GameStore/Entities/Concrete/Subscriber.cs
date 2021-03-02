using GameStore.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Entities.Concrete
{
    public class Subscriber
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
