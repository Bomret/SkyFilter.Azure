using FluentAssertions;
using Machine.Specifications;
using SkyFilter.Azure.Contracts;
using SkyFilter.Azure.Tables;

namespace SkyFilter.Azure.Tests.WhereLessThan
{
    [Subject(typeof(GenerateTableFilter), "WhereLessThan")]
    internal class When_I_generate_a_filter_where_a_binary_partition_key_is_less_than_an_array_containing_1_50_233
    {
        private static string _expectedFilter;
        private static IAzureTableFilter _result;

        private Establish ctx = () => _expectedFilter = "PartitionKey lt X'0132e9'";

        private Because of = () => _result = GenerateTableFilter.WhereLessThan("PartitionKey", new byte[] { 1, 50, 233 });

        private It should_return_the_expected_filter = () => _result.AsFilterCondition.Should().Be(_expectedFilter);
    }
}