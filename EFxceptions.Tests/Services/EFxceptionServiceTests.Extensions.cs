// ---------------------------------------------------------------
// Copyright (c) Hassan Habib, Alice Luo and Shimmy Weitzhandler  All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using EFxceptions.Tests.Brokers;
using EFxceptions.Tests.Models;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace EFxceptions.Tests.Services
{
    public partial class EFxceptionServiceTests
    {
        [Fact]
        public void ShouldConfigureHistoryTable()
        {
            // given.. when
            var options = new DbContextOptionsBuilder<StorageBroker>()
                .UseInMemoryDatabase("TestDatabase")
                .Options;

            var storageBroker = new StorageBroker(options);

            // then
            var entityType =
                storageBroker.Model.FindEntityType(typeof(SomeEntity));

            var isTemporal = entityType.IsTemporal();

            Assert.NotNull(entityType);
            Assert.True(isTemporal);
        }
    }
}