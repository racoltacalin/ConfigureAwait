﻿using System.Linq;
using ApprovalTests;
using Xunit;

public partial class ModuleWeaverTests
{
    [Fact]
    public void InfoMessages()
    {
        Approvals.VerifyAll(testResult.Messages.OrderBy(s => s).Select(x=>x.Text), "Info");
    }

    [Fact]
    public void ErrorMessages()
    {
        Approvals.VerifyAll(testResult.Errors.OrderBy(s => s).Select(x => x.Text), "Error");
    }
}