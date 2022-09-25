using System;
using Amazon.Lambda.Core;
using Amazon.Lambda.Serialization.SystemTextJson;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(DefaultLambdaJsonSerializer))]

namespace HelloWorld
{
    public class Function
    {
        public string FunctionHandler(User user, ILambdaContext context)
        {
            return user.Name.ToUpper();
        }
    }

    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}