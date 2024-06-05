using TestPlayWright.MongoDB;
using TestPlayWright.Samples;
using Xunit;

namespace TestPlayWright.MongoDb.Applications;

[Collection(TestPlayWrightTestConsts.CollectionDefinitionName)]
public class MongoDBSampleAppServiceTests : SampleAppServiceTests<TestPlayWrightMongoDbTestModule>
{

}
