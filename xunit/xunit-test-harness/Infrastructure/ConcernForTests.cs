using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace xunit_test_harness.Infrastructure
{
    public class ConcernForTests : ConcernFor<Foo>
    {
        private bool _contextHasBeenExecuted;
        private bool _givenHasBeenExecuted;
        private bool _whenHasBeenExecuted;

        protected override void Context()
        {
            _contextHasBeenExecuted = true;
        }

        protected override Foo Given()
        {
            _givenHasBeenExecuted = true;

            return new Foo();
        }

        protected override void When()
        {
            _whenHasBeenExecuted = true;
        }
        
        [Fact]
        public void ContextShouldBeExecuted()
        {
            Assert.True(_contextHasBeenExecuted);
        }

        [Fact]
        public void GivenShouldBeExecuted()
        {
            Assert.True(_givenHasBeenExecuted);
        }

        [Fact]
        public void SubjectShouldBeAssigned()
        {
            Assert.NotNull(Subject);
        }

        [Fact]
        public void WhenShouldBeExecuted()
        {
            Assert.True(_whenHasBeenExecuted);
        }
    }

    public class Foo
    {
    }
}
