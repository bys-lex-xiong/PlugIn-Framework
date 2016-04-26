﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevSolution.Caching;
using DevSolution.Services;

namespace DevSolution.Tests.Stubs
{
    public class StubClock : IClock
    {
        public StubClock()
        {
            UtcNow = new DateTime(2009, 10, 14, 12, 34, 56, DateTimeKind.Utc);
        }

        public DateTime UtcNow { get; private set; }

        public void Advance(TimeSpan span)
        {
            UtcNow = UtcNow.Add(span);
        }

        public DateTime FutureMoment(TimeSpan span)
        {
            return UtcNow.Add(span);
        }


        public IVolatileToken When(TimeSpan duration)
        {
            return new Clock.AbsoluteExpirationToken(this, duration);
        }

        public IVolatileToken WhenUtc(DateTime absoluteUtc)
        {
            return new Clock.AbsoluteExpirationToken(this, absoluteUtc);
        }
    }
}
