using ModernWebStores.SharedKernel.Events.Concrats;

namespace ModernWebStores.SharedKernel.Events
{
    public static class DomainEvent
    {
        public static IContainer container { get; set; }

        public static void Raise<T>(T args) where T : IDomainEvent
        {
            try
            {
                if (container != null)
                {
                    var obj = container.GetService(typeof(IHandler<T>));
                    ((IHandler<T>)obj).Handler(args));
                }
            }
            catch
            {

            }
        }
    }
}
