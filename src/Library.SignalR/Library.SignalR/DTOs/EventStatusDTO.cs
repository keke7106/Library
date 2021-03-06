﻿namespace Library.SignalR.DTOs
{
    public class EventStatusDTO
    {
        public EventStatusEnum Status { get; set; }

        public string ErrorMessage { get; set; }

        public string ErrorCode { get; set; }
    }

    public enum EventStatusEnum
    {
        Finished = 0,
        Error = 1
    }
}