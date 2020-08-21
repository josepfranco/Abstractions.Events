using System;

namespace Abstractions.Events.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Event
    {
        /// <summary>
        /// The unique identifier of this event
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// The unique identifier of the aggregate this event belongs to
        /// </summary>
        public string AggregateName { get; set; }
        
        /// <summary>
        /// The higher the version, the more recent this event is within the store
        /// </summary>
        public ulong Version { get; set; }
        
        /// <summary>
        /// The date & time this event was created at
        /// </summary>
        public DateTime CreatedAt { get; set; }
        
        /// <summary>
        /// The optional extra data this event may contain
        /// </summary>
        public IEventPayload Payload { get; set; }
    }
}