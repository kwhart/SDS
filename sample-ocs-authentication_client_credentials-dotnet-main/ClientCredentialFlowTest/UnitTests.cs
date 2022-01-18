//-----------------------------------------------------------------------
// <copyright file="UnitTests.cs" company="osiSoft">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ClientCredentialFlowTest
{
    using Xunit;

    /// <summary>
    /// Collection of XUnit Tests.
    /// </summary>
    public class UnitTests
    {
        /// <summary>
        /// Trivial Test.
        /// </summary>
        [Fact]
        public void ClientCredentialFlowTest()
        {
            ClientCredentialFlow.Program.Main();
        }
    }
}
