using System;

namespace Abstractions.Events.Models
{
    /// <summary>
    /// 
    /// </summary>
    public record Event
    {
        /// <summary>
        /// The unique identifier of this event
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The unique identifier of the aggregate this event belongs to
        /// </summary>
        public string AggregateName { get; set; } = string.Empty;

        /// <summary>
        /// The date & time this event was created at
        /// </summary>
        public DateTime CreatedAt { get; set; } = default;
        
        /// <summary>
        /// The optional extra data this event may contain
        /// </summary>
        public object? Payload { get; set; }
    }
}