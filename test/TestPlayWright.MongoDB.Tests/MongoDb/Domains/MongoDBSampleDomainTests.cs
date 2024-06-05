using TestPlayWright.Samples;
using Xunit;

namespace TestPlayWright.MongoDB.Domains;

[Collection(TestPlayWrightTestConsts.CollectionDefinitionName)]
public class MongoDBSampleDomainTests : SampleDomainTests<TestPlayWrightMongoDbTestModule>
{

}
