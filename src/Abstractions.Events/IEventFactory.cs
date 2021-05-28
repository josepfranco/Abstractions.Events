using Abstractions.Events.Models;

namespace Abstractions.Events
{
    public interface IEventFactory
    {
        /// <summary>
        ///     Creates a new event object ready to be used in a producer
        /// </summary>
        /// <param name="aggregateName">the aggregate name (usually the topic)</param>
        /// <param name="payload">an optional payload</param>
        /// <typeparam name="TEvent"></typeparam>
        /// <returns></returns>
        Event Create<TEvent>(string aggregateName, TEvent? payload = null) where TEvent : class;
    }
}