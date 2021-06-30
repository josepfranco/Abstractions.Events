namespace Abstractions.Events
{
    public interface IEventFactory
    {
        /// <summary>
        ///     Creates a new event object ready to be used in a producer
        /// </summary>
        /// <param name="aggregateName">the aggregate name (usually the topic)</param>
        /// <param name="payload">an optional payload</param>
        /// <typeparam name="TEventPayload"></typeparam>
        /// <returns></returns>
        Event Create<TEventPayload>(string aggregateName, TEventPayload? payload = null) where TEventPayload : class;
    }
}