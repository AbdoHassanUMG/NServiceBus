﻿namespace NServiceBus.Core.Tests.API
{
    using System.Runtime.CompilerServices;
    using NUnit.Framework;
    using PublicApiGenerator;

    [TestFixture]
    public class APIApprovals
    {
#if NET452
        [Test]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public void ApproveNServiceBus__NET452()
        {
            var publicApi = ApiGenerator.GeneratePublicApi(typeof(Endpoint).Assembly, excludeAttributes: new[] { "Particular.Licensing.ReleaseDateAttribute" });
            TestApprover.Verify(publicApi);
        }
#endif

#if NETCOREAPP2_0
        [Test]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public void ApproveNServiceBus__NETSTANDARD2_0()
        {
            var publicApi = ApiGenerator.GeneratePublicApi(typeof(Endpoint).Assembly, excludeAttributes: new[] { "Particular.Licensing.ReleaseDateAttribute" });
            TestApprover.Verify(publicApi);
        }
#endif
    }
}