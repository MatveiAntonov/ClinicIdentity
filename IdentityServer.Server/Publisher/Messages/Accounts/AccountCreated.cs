﻿namespace Events
{
    public class AccountCreated
    {
        public string Id { get; set; }
        public string PhoneNumber { get; set; } = String.Empty;
        public string Url { get; set; } = String.Empty;
    }
}
