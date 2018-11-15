# BAMCIS TimeUnit

A .NET Core implementation of the Java java.util.concurrent.TimeUnit class.

## Table of Contents
- [Usage](#usage)
- [Revision History](#revision-history)

## Usage

Import the package:

    using BAMCIS.Util.Concurrent;

A simple example:

    long Seconds = TimeUnit.SECONDS.Convert(10, TimeUnit.MINUTES);

This converts 10 minutes into seconds, which results in 600.  You can also convert time units like this:

    long Millis = TimeUnit.MINUTES.ToMilliseconds(1);

You can also perform wait operations:

    TimeUnit.SECONDS.Sleep(5);

This will cause the thread to sleep for 5 seconds.

## Revision History

### 1.0.1
Fixed namespace issue.

### 1.0.0
Initial release of the library.
