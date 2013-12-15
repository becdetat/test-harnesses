using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace nunit_test_harness.Infrastructure
{
    public class Foo
    {
    }

    [TestFixture]
    public class FooTests : ConcernFor<Foo>
    {
        private bool _contextHasBeenExecuted;
        private bool _givenHasBeenExecuted;
        private bool _whenHasBeenExecuted;
        private bool _disposeHasBeenExecuted;

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

        public override void Dispose()
        {
            _disposeHasBeenExecuted = true;
        }

        [Test]
        public void ContextShouldBeExecuted()
        {
            Assert.IsTrue(_contextHasBeenExecuted);
        }

        [Test]
        public void GivenShouldBeExecuted()
        {
            Assert.IsTrue(_givenHasBeenExecuted);
        }

        [Test]
        public void SubjectShouldBeAssigned()
        {
            Assert.IsNotNull(Subject);
        }

        [Test]
        public void WhenShouldBeExecuted()
        {
            Assert.IsTrue(_whenHasBeenExecuted);
        }

        [Test]
        public void DisposeShouldBeExecuted()
        {
            Assert.IsTrue(_disposeHasBeenExecuted);
        }
    }
}
