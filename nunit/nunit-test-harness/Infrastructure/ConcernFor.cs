﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace nunit_test_harness.Infrastructure
{
    public abstract class ConcernFor<T>
    {
        protected T Subject;

        [SetUp]
        public virtual void SetUp()
        {
            Context();
            Subject = Given();
            When();
        }

        protected virtual void Context()
        {
        }

        protected abstract T Given();

        protected virtual void When()
        {
        }
    }
}
