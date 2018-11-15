using System;
using Xunit;

namespace BAMCIS.TimeUnit.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void SecondsToMinutes()
        {
            // ARRANGE

            // ACT 
            long Minutes = TimeUnit.MINUTES.Convert(120, TimeUnit.SECONDS);

            // ASSERT
            Assert.Equal(2, Minutes);
        }

        [Fact]
        public void SecondsToMinutesWithTruncation()
        {
            // ARRANGE

            // ACT 
            long Minutes = TimeUnit.MINUTES.Convert(150, TimeUnit.SECONDS);

            // ASSERT
            Assert.Equal(2, Minutes);
        }

        [Fact]
        public void SecondsToMilliseconds()
        {
            // ARRANGE

            // ACT 
            long Milliseconds = TimeUnit.MILLISECONDS.Convert(11, TimeUnit.SECONDS);

            // ASSERT
            Assert.Equal(11000, Milliseconds);
        }

        [Fact]
        public void NanoSecondsToTicks()
        {
            // ARRANGE

            // ACT 
            long Ticks = TimeUnit.TICKS.Convert(100, TimeUnit.NANOSECONDS);

            // ASSERT
            Assert.Equal(1, Ticks);
        }

        [Fact]
        public void DayToNanoOverFlow()
        {
            // ARRANGE

            // ACT
            long Nanos = TimeUnit.NANOSECONDS.Convert(long.MaxValue - 100, TimeUnit.DAYS);

            // ASSERT
            Assert.Equal(long.MaxValue, Nanos);
        }

        [Fact]
        public void SleepTest()
        {
            // ARRANGE
            DateTime Now = DateTime.Now;

            // ACT
            TimeUnit.SECONDS.Sleep(8);

            // ASSERT
            Assert.True(DateTime.Now >= Now.AddSeconds(8));
        }

        [Fact]
        public void EqualsTest()
        {
            // ARRANGE

            // ACT

            // ASSERT
            Assert.True(TimeUnit.SECONDS == TimeUnit.SECONDS);
        }

        [Fact]
        public void EqualsTest2()
        {
            // ARRANGE

            // ACT

            // ASSERT
            Assert.True(TimeUnit.SECONDS.Equals(TimeUnit.SECONDS));
        }

        [Fact]
        public void NotEqualsTest()
        {
            // ARRANGE

            // ACT

            // ASSERT
            Assert.True(!TimeUnit.SECONDS.Equals(TimeUnit.MICROSECONDS));
        }

        [Fact]
        public void NotEqualsTest2()
        {
            // ARRANGE

            // ACT

            // ASSERT
            Assert.True(TimeUnit.SECONDS != TimeUnit.MICROSECONDS);
        }
    }
}
