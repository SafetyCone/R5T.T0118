using System;

using Microsoft.Extensions.DependencyInjection;


namespace R5T.T0118
{
    /// <summary>
    /// Base class for service test fixtures that takes care of implementing the <see cref="IServiceTestFixture"/> marker interface.
    /// </summary>
    /// <typeparam name="TService">The service for which this class is a test fixture.</typeparam>
    public abstract class ServiceTestFixtureBase<TService> : IServiceTestFixture
    {
        protected TService Service { get; private set; }


        public ServiceTestFixtureBase(IServiceProvider serviceProvider)
        {
            this.Service = serviceProvider.GetRequiredService<TService>();
        }
    }
}
